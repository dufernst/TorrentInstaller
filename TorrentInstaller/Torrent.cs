/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/. */

using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MonoTorrent;
using MonoTorrent.Common;
using MonoTorrent.Client;
using MonoTorrent.Dht;
using MonoTorrent.Dht.Listeners;
using MonoTorrent.BEncoding;

namespace TorrentInstaller
{
    public class WoWTorrent
    {
        private String savePath;
        private String launcherFiles;
        private String fastResumeFile;
        private String dhtNodesFile;
        private String torrentFile;

        private String usedFastResume;
        private int listenPort;

        private Torrent torrent;
        private TorrentSettings torrentSettings;
        private TorrentManager torrentManager;
        private ClientEngine clientEngine;
        private FastResume fastResume;

        private int averagedUploadSpeed;
        private int averagedDownloadSpeed;

        public WoWTorrent()
        {
            savePath = Environment.CurrentDirectory;
            launcherFiles = Path.Combine(savePath, "LauncherData");
            fastResumeFile = Path.Combine(launcherFiles, "fastresume.data");
            dhtNodesFile = Path.Combine(launcherFiles, "DHTNodes.data");
            torrentFile = Path.Combine(launcherFiles, "wow.torrent");

            listenPort = getFreePort();

            Directory.CreateDirectory(launcherFiles);
            StreamWriter w1 = File.AppendText(fastResumeFile);
            w1.Close();
            StreamWriter w2 = File.AppendText(dhtNodesFile);
            w2.Close();

            averagedUploadSpeed = 0;
            averagedDownloadSpeed = 0;

            startEngine();
            startDHT();
            initFastResume();
            initTorrent();
        }

        private void startEngine()
        {
            EngineSettings engineSettings = new EngineSettings(savePath, listenPort);

            engineSettings.SavePath = savePath;
            engineSettings.AllowedEncryption = MonoTorrent.Client.Encryption.EncryptionTypes.RC4Full |
                                               MonoTorrent.Client.Encryption.EncryptionTypes.RC4Header;
            engineSettings.PreferEncryption = true;
            engineSettings.GlobalMaxHalfOpenConnections = 10;

            clientEngine = new ClientEngine(engineSettings);
            clientEngine.ChangeListenEndpoint(new IPEndPoint(IPAddress.Any, listenPort));
        }

        private void startDHT()
        {
            byte[] nodes = null;
            try
            {
                nodes = File.ReadAllBytes(dhtNodesFile);
            }
            catch {}

            DhtListener dhtListner = new DhtListener(new IPEndPoint(IPAddress.Any, listenPort));
            DhtEngine dht = new DhtEngine(dhtListner);
            clientEngine.RegisterDht(dht);
            dhtListner.Start();
            clientEngine.DhtEngine.Start(nodes);
        }

        private void initFastResume()
        {
            BEncodedList bl;
            try
            {
                bl = (BEncodedList) BEncodedValue.Decode(File.ReadAllBytes(fastResumeFile));
            }
            catch
            {
                bl = new BEncodedList();
            }

            foreach (BEncodedDictionary item in bl)
                fastResume = new FastResume(item);

            // already cleanup the previous fast resume file
            File.Delete(fastResumeFile);
        }

        private void initTorrent()
        {
            try
            {
                torrent = Torrent.Load(torrentFile);
                
            }
            catch {}

            // remove non existing trackers
            List<RawTrackerTier> toRemove = new List<RawTrackerTier>();
            torrent.AnnounceUrls.ToList().ForEach(delegate(RawTrackerTier t)
            {
                t.ToList().ForEach(delegate(String s)
                {
                    try
                    {
                        Uri result;
                        Uri.TryCreate(s, UriKind.Absolute, out result);
                        Dns.GetHostAddresses(result.Host);
                    }
                    catch
                    {
                        toRemove.Add(t);
                    }
                });
            });
            toRemove.ForEach(delegate(RawTrackerTier t) { torrent.AnnounceUrls.Remove(t); });

            torrentSettings = new TorrentSettings(4, 100, 600 * 1024, 60 * 1024, false);
            torrentSettings.EnablePeerExchange = true;
            torrentSettings.UseDht = true;
            torrentManager = new TorrentManager(torrent, savePath, torrentSettings, savePath);

            usedFastResume = "false";
            if (fastResume != null)
            {
                if (torrentManager.InfoHash == fastResume.Infohash)
                {
                    torrentManager.LoadFastResume(fastResume);
                    usedFastResume = "true";
                }
            }

            clientEngine.Register(torrentManager);
            torrentManager.Start();
        }

        private int getFreePort()
        {
            Socket sock = new Socket(
                            AddressFamily.InterNetwork,
                            SocketType.Stream,
                            ProtocolType.Tcp);

            sock.Bind(new IPEndPoint(IPAddress.Any, 0));
            int freePort = ((IPEndPoint)sock.LocalEndPoint).Port;
            sock.Dispose();

            return freePort;
        }

        public void Stop()
        {
            if (torrentManager.State != TorrentState.Hashing)
            {
                torrentManager.Stop();

                while (torrentManager.State != TorrentState.Stopped)
                    Thread.Sleep(250);

                BEncodedList bl = new BEncodedList();
                FastResume fr = torrentManager.SaveFastResume();
                BEncodedDictionary item = fr.Encode();
                bl.Add(item);
                File.WriteAllBytes(fastResumeFile, bl.Encode());
            }
            else
                torrentManager.Stop();

            File.WriteAllBytes(dhtNodesFile, clientEngine.DhtEngine.SaveNodes());
            clientEngine.Dispose();
        }

        public void setSettings()
        {
            torrentManager.Settings.MaxDownloadSpeed = 100;
        }

        public int getUsedPort()
        {
            return listenPort;
        }

        public int getUploadSpeed()
        {
            return torrentManager.Monitor.UploadSpeed;
        }

        public int getDownloadSpeed()
        {
            return torrentManager.Monitor.DownloadSpeed;
        }

        public int getAveragedUploadSpeed()
        {
            averagedUploadSpeed = (averagedUploadSpeed * 4 + torrentManager.Monitor.UploadSpeed) / 5;
            return averagedUploadSpeed;
        }

        public int getAveragedDownloadSpeed()
        {
            averagedDownloadSpeed = (averagedDownloadSpeed * 4 + torrentManager.Monitor.DownloadSpeed) / 5;
            return averagedDownloadSpeed;
        }

        public double getProgress()
        {
            return torrentManager.Progress;
        }

        public long getTorrentSize()
        {
            return torrent.Size;
        }

        public String getOtherStats()
        {
            String debug;
            debug = "";
            torrent.AnnounceUrls.ToList().
                ForEach(delegate(RawTrackerTier t)
                {
                    t.ToList().ForEach(delegate(String s)
                    {
                        debug += s + "\n"; 
                    });
                });

            return debug +=
                    "State: " + torrentManager.State + "\n" +
                    "Name: " + torrentManager.Torrent.Name + "\n" +
                    "Progress: " + torrentManager.Progress + "\n" +
                    "Downloaded: " + torrentManager.Monitor.DataBytesDownloaded + "\n" +
                    "Uploaded: " + torrentManager.Monitor.DataBytesUploaded + "\n" +
                    "Read rate: " + clientEngine.DiskManager.ReadRate + "\n" +
                    "Write rate: " + clientEngine.DiskManager.WriteRate + "\n" +
                    "Warning: " + torrentManager.TrackerManager.CurrentTracker.WarningMessage + "\n" +
                    "Failure: " + torrentManager.TrackerManager.CurrentTracker.FailureMessage + "\n" +
                    "OConnections: " + clientEngine.ConnectionManager.OpenConnections + "\n" +
                    "HOConnections: " + clientEngine.ConnectionManager.HalfOpenConnections + "\n" +
                    "MOConnections: " + clientEngine.ConnectionManager.MaxOpenConnections + "\n" +
                    "MHOConnections: " + clientEngine.ConnectionManager.MaxHalfOpenConnections + "\n" +
                    "Fast resume used: " + usedFastResume + "\n" +
                    "Total download: " + torrent.Size + "\n";
        }
    }
}
