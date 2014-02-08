/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/. */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TorrentInstaller
{
    public partial class MainWindow : Form
    {
        public delegate void UpdateValuesDel();
        public UpdateValuesDel updateValDelegate;
        private int currentUploadSpeed = 0;
        private int currentDownloadSpeed = 0;
        private WoWTorrent wtorrent;
        private Thread updaterThread;
        private Updater updater;

        private bool mouseDownOnTopBar;
        private int mouseDownX;
        private int mouseDownY;

        public MainWindow(WoWTorrent torrent)
        {
            updateValDelegate = new UpdateValuesDel(UpdateValues);
            this.FormClosing += MainWindowClosing;
            wtorrent = torrent;
            InitializeComponent();
            initPlayButton();
            initTopBar();
            initDownloadBar();
            CreateUpdaterThread();
        }

        private void MainWindowClosing(object sender, EventArgs e)
        {
            updaterThread.Abort();
            wtorrent.Stop();
        }

        private void CreateUpdaterThread()
        {
            updater = new Updater(this);
            updaterThread = new Thread(new ThreadStart(updater.Run));
            updaterThread.Start();
        }

        public void UpdateValues()
        {
            setUploadSpeed(wtorrent.getAveragedUploadSpeed());
            setDownloadSpeed(wtorrent.getAveragedDownloadSpeed());
            setProgress((int)(wtorrent.getProgress()));
            debugInfo.Text = wtorrent.getOtherStats();
        }

        private void initPlayButton()
        {
            playButton.Click += new EventHandler(playClick);
            playButton.MouseEnter += new EventHandler(playEnter);
            playButton.MouseLeave += new EventHandler(playLeave);
        }

        private void initTopBar()
        {
            mouseDownOnTopBar = false;
            closeButton.Click += new EventHandler(topCloseClick);
            closeButton.MouseEnter += new EventHandler(topCloseEnter);
            closeButton.MouseLeave += new EventHandler(topCloseLeave);
            minimiseButton.Click += new EventHandler(topMinimiseClick);
            minimiseButton.MouseEnter += new EventHandler(topMinimiseEnter);
            minimiseButton.MouseLeave += new EventHandler(topMinimiseLeave);
            windowbar.MouseDown += new MouseEventHandler(topBarMouseDown);
            windowbar.MouseUp += new MouseEventHandler(topBarMouseUp);
            windowbar.MouseMove += new MouseEventHandler(topBarMouseMove);
        }

        private void initDownloadBar()
        {
            setProgress(0);
            initDownloadSpeed();
            initRemaining();
        }

        private void setProgress(int progress)
        {
            int cds = (currentDownloadSpeed == 0 ? 1 : currentDownloadSpeed);
            long toDownload = ((100 - progress) * wtorrent.getTorrentSize()) / 100;
            downloadBar.Value = progress;
            remainingStats.Text = "Time remaining:           " +
                                  getTimeString(toDownload / cds) + "\n" +
                                  "Download remaining: " +
                                  getSizeString(toDownload);
        }

        private void initDownloadSpeed()
        {
            downloadSpeed.Parent = bottomBar;
            // when changing the parent the location becomes relative to the new parent
            downloadSpeed.Location = new Point(downloadSpeed.Location.X - downloadSpeed.Parent.Location.X,
                                                downloadSpeed.Location.Y - downloadSpeed.Parent.Location.Y);
            setDownloadSpeed(0);
            setUploadSpeed(0);
        }

        private void initRemaining()
        {
            remainingStats.Parent = bottomBar;
            // when changing the parent the location becomes relative to the new parent
            remainingStats.Location = new Point(remainingStats.Location.X - remainingStats.Parent.Location.X,
                                                remainingStats.Location.Y - remainingStats.Parent.Location.Y);
            remainingStats.Text = "Time remaining:     " + "\n" +
                                  "Download remaining: ";
        }

        private void setDownloadSpeed(int download)
        {
            currentDownloadSpeed = download;
            downloadSpeed.Text = "Downloading:   " + getSizeString(currentDownloadSpeed) + "/s\n" +
                             "Uploading:         " + getSizeString(currentUploadSpeed) + "/s";
        }

        private void setUploadSpeed(int upload)
        {
            currentUploadSpeed = upload;
            downloadSpeed.Text = "Downloading:   " + getSizeString(currentDownloadSpeed) + "/s\n" +
                             "Uploading:         " + getSizeString(currentUploadSpeed) + "/s";
        }

        private String getSizeString(long size)
        {
            if (size < 0)
                return "wtf";

            double dsize = (double)size;
            dsize = dsize / 1024;
            String ex;

            if (dsize / 1000 >= 1.0 && (dsize / 1000) / 1000 < 1.0)
            {
                dsize = Math.Truncate((dsize / 1024) * 100) / 100;
                ex = "MB";
            }
            else if ((dsize / 1000) / 1000 >= 1.0)
            {
                dsize = Math.Truncate(((dsize / 1024) / 1024) * 100) / 100;
                ex = "GB";
            }
            else
            {
                dsize = Math.Truncate(dsize * 100) / 100;
                ex = "KB";
            }

            return dsize + "  " + ex;
        }

        private String getTimeString(long seconds)
        {
            String result = "";
            long minutes = (long) Math.Floor( (double) seconds / 60.0);
            long hours = (long)Math.Floor( (double) minutes / 60);
            long days = (long)Math.Floor((double) hours / 24);

            if (days > 0)
                result += days + "d  ";
            if (hours > 0)
                result += hours % 24 + "h  ";
            if (minutes > 0 && days == 0)
                result += minutes % 60 + "m  ";
            if (seconds > 0 && hours == 0)
                result += seconds % 60 + "s";

            if (days > 14)
                result = ".....";

            return result;
        }

        private void playClick(object sender, EventArgs e)
        {
            playButton.Image = Properties.Resources.PlayButtonPress;
        }

        private void playEnter(object sender, EventArgs e)
        {
            playButton.Image = Properties.Resources.Play_Hover;
        }

        private void playLeave(object sender, EventArgs e)
        {
            playButton.Image = Properties.Resources.Play_No_Hover;
        }

        private void topCloseClick(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.Top_Bar_Close_Click;
            this.Close();
        }

        private void topCloseEnter(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.Top_Bar_Close_Hover;
        }

        private void topCloseLeave(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.Top_Bar_Close_Normal;
        }

        private void topMinimiseClick(object sender, EventArgs e)
        {
            minimiseButton.Image = Properties.Resources.Top_Bar_Minimize_Click;
            this.WindowState = FormWindowState.Minimized;
        }

        private void topMinimiseEnter(object sender, EventArgs e)
        {
            minimiseButton.Image = Properties.Resources.Top_Bar_Minimize_Hover;
        }

        private void topMinimiseLeave(object sender, EventArgs e)
        {
            minimiseButton.Image = Properties.Resources.Top_Bar_Minimize_Normal;
        }

        private void topBarMouseDown(object sender, MouseEventArgs e)
        {
            mouseDownOnTopBar = true;
            mouseDownX = e.X;
            mouseDownY = e.Y;
        }

        private void topBarMouseUp(object sender, MouseEventArgs e)
        {
            mouseDownOnTopBar = false;
        }

        private void topBarMouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDownOnTopBar)
            {
                this.Location = new Point(this.Left + e.X - mouseDownX,
                                        this.Top + e.Y - mouseDownY);
            }
        }
    }
}
