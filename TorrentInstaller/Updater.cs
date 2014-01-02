/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TorrentInstaller
{
    class Updater
    {
        private MainWindow mainWindow;

        public Updater(MainWindow mw)
        {
            mainWindow = mw;
        }

        public void Run()
        {
            while (true)
            {
                Thread.Sleep(1000);
                mainWindow.Invoke(mainWindow.updateValDelegate);
            }
        }
    }
}
