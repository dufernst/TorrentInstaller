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
            this.downloadBar = new System.Windows.Forms.ProgressBar();
            this.debugInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minimiseButton = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.windowbar = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.Button();
            this.bottomBar = new System.Windows.Forms.PictureBox();
            this.remainingStats = new TorrentInstaller.TransparentLabel();
            this.downloadSpeed = new TorrentInstaller.TransparentLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimiseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomBar)).BeginInit();
            this.SuspendLayout();
            // 
            // downloadBar
            // 
            this.downloadBar.Location = new System.Drawing.Point(20, 534);
            this.downloadBar.Margin = new System.Windows.Forms.Padding(0);
            this.downloadBar.Name = "downloadBar";
            this.downloadBar.Size = new System.Drawing.Size(592, 23);
            this.downloadBar.Step = 1;
            this.downloadBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.downloadBar.TabIndex = 2;
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TorrentInstaller.Properties.Resources.Bg_Default;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 480);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
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
            this.playButton.Image = ((System.Drawing.Image)(resources.GetObject("playButton.Image")));
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.Controls.Add(this.minimiseButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.windowbar);
            this.Controls.Add(this.remainingStats);
            this.Controls.Add(this.debugInfo);
            this.Controls.Add(this.downloadSpeed);
            this.Controls.Add(this.downloadBar);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.bottomBar);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Cataclysm Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimiseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.ProgressBar downloadBar;
        private TransparentLabel downloadSpeed;
        private System.Windows.Forms.Label debugInfo;
        private TransparentLabel remainingStats;
        private System.Windows.Forms.PictureBox windowbar;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox minimiseButton;
        private System.Windows.Forms.PictureBox bottomBar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

