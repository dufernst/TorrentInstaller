namespace TorrentInstaller
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.debugInfo = new System.Windows.Forms.Label();
            this.remainingStats = new TorrentInstaller.TransparentLabel();
            this.downloadSpeed = new TorrentInstaller.TransparentLabel();
            this.minimiseButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.windowbar = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.Button();
            this.bottomBar = new System.Windows.Forms.PictureBox();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.optionMenu = new TorrentInstaller.TransparentPictureBox();
            this.settingsMenu = new TorrentInstaller.SettingsMenu();
            this.progressBar = new TorrentInstaller.AnimatedProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.minimiseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar)).BeginInit();
            this.SuspendLayout();
            // 
            // debugInfo
            // 
            this.debugInfo.AutoSize = true;
            this.debugInfo.Font = new System.Drawing.Font("Gentium Book Basic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.debugInfo.Location = new System.Drawing.Point(51, 142);
            this.debugInfo.Name = "debugInfo";
            this.debugInfo.Size = new System.Drawing.Size(77, 17);
            this.debugInfo.TabIndex = 4;
            this.debugInfo.Text = "Debug Info";
            // 
            // remainingStats
            // 
            this.remainingStats.AutoSize = true;
            this.remainingStats.BackColor = System.Drawing.Color.Transparent;
            this.remainingStats.Font = new System.Drawing.Font("GiovanniITCTT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingStats.ForeColor = System.Drawing.Color.Chocolate;
            this.remainingStats.Location = new System.Drawing.Point(414, 578);
            this.remainingStats.Margin = new System.Windows.Forms.Padding(0);
            this.remainingStats.Name = "remainingStats";
            this.remainingStats.Size = new System.Drawing.Size(101, 15);
            this.remainingStats.TabIndex = 5;
            this.remainingStats.Text = "Time remaining:";
            // 
            // downloadSpeed
            // 
            this.downloadSpeed.AutoSize = true;
            this.downloadSpeed.BackColor = System.Drawing.Color.Transparent;
            this.downloadSpeed.Font = new System.Drawing.Font("GiovanniITCTT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadSpeed.ForeColor = System.Drawing.Color.Chocolate;
            this.downloadSpeed.Location = new System.Drawing.Point(19, 578);
            this.downloadSpeed.Margin = new System.Windows.Forms.Padding(0);
            this.downloadSpeed.Name = "downloadSpeed";
            this.downloadSpeed.Size = new System.Drawing.Size(87, 15);
            this.downloadSpeed.TabIndex = 3;
            this.downloadSpeed.Text = "Downloading:";
            // 
            // minimiseButton
            // 
            this.minimiseButton.BackgroundImage = global::TorrentInstaller.Properties.Resources.Top_Bar_Minimize_Normal;
            this.minimiseButton.Location = new System.Drawing.Point(754, 4);
            this.minimiseButton.Name = "minimiseButton";
            this.minimiseButton.Size = new System.Drawing.Size(20, 20);
            this.minimiseButton.TabIndex = 10;
            this.minimiseButton.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::TorrentInstaller.Properties.Resources.Top_Bar_Close_Normal;
            this.closeButton.Location = new System.Drawing.Point(776, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.TabIndex = 9;
            this.closeButton.TabStop = false;
            // 
            // windowbar
            // 
            this.windowbar.BackgroundImage = global::TorrentInstaller.Properties.Resources.Top_Bar;
            this.windowbar.Location = new System.Drawing.Point(-3, 0);
            this.windowbar.Margin = new System.Windows.Forms.Padding(0);
            this.windowbar.Name = "windowbar";
            this.windowbar.Size = new System.Drawing.Size(804, 29);
            this.windowbar.TabIndex = 6;
            this.windowbar.TabStop = false;
            // 
            // playButton
            // 
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Image = global::TorrentInstaller.Properties.Resources.PlayButtonDisabled;
            this.playButton.Location = new System.Drawing.Point(643, 524);
            this.playButton.Margin = new System.Windows.Forms.Padding(0);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(140, 84);
            this.playButton.TabIndex = 1;
            this.playButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.playButton.UseVisualStyleBackColor = true;
            // 
            // bottomBar
            // 
            this.bottomBar.BackgroundImage = global::TorrentInstaller.Properties.Resources.Bottom_Bar;
            this.bottomBar.Location = new System.Drawing.Point(0, 504);
            this.bottomBar.Name = "bottomBar";
            this.bottomBar.Size = new System.Drawing.Size(800, 120);
            this.bottomBar.TabIndex = 11;
            this.bottomBar.TabStop = false;
            // 
            // imageBox
            // 
            this.imageBox.BackgroundImage = global::TorrentInstaller.Properties.Resources.Bg_Default;
            this.imageBox.Location = new System.Drawing.Point(0, 24);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(800, 480);
            this.imageBox.TabIndex = 12;
            this.imageBox.TabStop = false;
            // 
            // optionMenu
            // 
            this.optionMenu.BackColor = System.Drawing.Color.Transparent;
            this.optionMenu.BackgroundImage = global::TorrentInstaller.Properties.Resources.ExSign;
            this.optionMenu.Location = new System.Drawing.Point(719, 47);
            this.optionMenu.Name = "optionMenu";
            this.optionMenu.Size = new System.Drawing.Size(64, 63);
            this.optionMenu.TabIndex = 15;
            this.optionMenu.TabStop = false;
            // 
            // settingsMenu
            // 
            this.settingsMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsMenu.BackgroundImage")));
            this.settingsMenu.Location = new System.Drawing.Point(166, 59);
            this.settingsMenu.Margin = new System.Windows.Forms.Padding(0);
            this.settingsMenu.Name = "settingsMenu";
            this.settingsMenu.Size = new System.Drawing.Size(460, 410);
            this.settingsMenu.TabIndex = 14;
            // 
            // progressBar
            // 
            this.progressBar.BackgroundImage = global::TorrentInstaller.Properties.Resources.Progress_Bar_Not_Seeding;
            this.progressBar.Location = new System.Drawing.Point(19, 562);
            this.progressBar.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(595, 9);
            this.progressBar.TabIndex = 13;
            this.progressBar.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.Controls.Add(this.optionMenu);
            this.Controls.Add(this.settingsMenu);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.minimiseButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.windowbar);
            this.Controls.Add(this.remainingStats);
            this.Controls.Add(this.debugInfo);
            this.Controls.Add(this.downloadSpeed);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.bottomBar);
            this.Controls.Add(this.imageBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Cataclysm Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.minimiseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private TransparentLabel downloadSpeed;
        private System.Windows.Forms.Label debugInfo;
        private TransparentLabel remainingStats;
        private System.Windows.Forms.PictureBox windowbar;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox minimiseButton;
        private System.Windows.Forms.PictureBox bottomBar;
        private System.Windows.Forms.PictureBox imageBox;
        private AnimatedProgressBar progressBar;
        private SettingsMenu settingsMenu;
        private TransparentPictureBox optionMenu;
    }
}

