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

        public MainWindow(WoWTorrent torrent)
        {
            updateValDelegate = new UpdateValuesDel(UpdateValues);
            this.FormClosing += MainWindowClosing;
            wtorrent = torrent;
            InitializeComponent();
            initPlayButton();
            initDownloadBar();
            CreateUpdaterThread();
        }

        private void MainWindowClosing(object sender, EventArgs e)
        {
            updaterThread.Abort();
        }

        private void CreateUpdaterThread()
        {
            updater = new Updater(this);
            updaterThread = new Thread(new ThreadStart(updater.Run));
            updaterThread.Start();
        }

        public void UpdateValues()
        {
            setUploadSpeed(wtorrent.getUploadSpeed());
            setDownloadSpeed(wtorrent.getDownloadSpeed());
            setProgress((int)(wtorrent.getProgress()));
            debugInfo.Text = wtorrent.getOtherStats();
        }

        private void initPlayButton()
        {
            playButton.Click += new EventHandler(playClick);
            playButton.MouseEnter += new EventHandler(playEnter);
            playButton.MouseLeave += new EventHandler(playLeave);
        }

        private void initDownloadBar()
        {
            setProgress(0);
            initDownloadSpeed();
        }

        private void setProgress(int progress)
        {
            downloadBar.Value = progress;
        }

        private void initDownloadSpeed()
        {
            downloadSpeed.Parent = mainframe;
            setDownloadSpeed(0);
            setUploadSpeed(0);
        }

        private void setDownloadSpeed(int download)
        {
            currentDownloadSpeed = download;
            downloadSpeed.Text = "Downloading:   " + getSpeedString(currentDownloadSpeed) + "\n" +
                             "Uploading:         " + getSpeedString(currentUploadSpeed);
        }

        private void setUploadSpeed(int upload)
        {
            currentUploadSpeed = upload;
            downloadSpeed.Text = "Downloading:   " + getSpeedString(currentDownloadSpeed) + "\n" +
                             "Uploading:         " + getSpeedString(currentUploadSpeed);
        }

        private String getSpeedString(int speed)
        {
            double dspeed = (double)speed;
            dspeed = dspeed / 1024;
            String ex;

            if (dspeed / 1000 >= 1.0 && (dspeed / 1000) / 1000 < 1.0)
            {
                dspeed = Math.Truncate((dspeed / 1024) * 100) / 100;
                ex = "MB/s";
            }
            else if ((dspeed / 1000) / 1000 >= 1.0)
            {
                dspeed = Math.Truncate(((dspeed / 1024) / 1024) * 100) / 100;
                ex = "GB/s";
            }
            else
            {
                dspeed = Math.Truncate(dspeed * 100) / 100;
                ex = "KB/s";
            }

            return dspeed + "  " + ex;
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
    }
}
