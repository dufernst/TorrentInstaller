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
            this.playButton = new System.Windows.Forms.Button();
            this.mainframe = new System.Windows.Forms.PictureBox();
            this.downloadBar = new System.Windows.Forms.ProgressBar();
            this.downloadSpeed = new TorrentInstaller.TransparentLabel();
            this.debugInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainframe)).BeginInit();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Image = ((System.Drawing.Image)(resources.GetObject("playButton.Image")));
            this.playButton.Location = new System.Drawing.Point(645, 497);
            this.playButton.Margin = new System.Windows.Forms.Padding(0);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(140, 84);
            this.playButton.TabIndex = 1;
            this.playButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.playButton.UseVisualStyleBackColor = true;
            // 
            // mainframe
            // 
            this.mainframe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainframe.BackgroundImage = global::TorrentInstaller.Properties.Resources.LauncherOuter;
            this.mainframe.Location = new System.Drawing.Point(-3, -2);
            this.mainframe.Margin = new System.Windows.Forms.Padding(0);
            this.mainframe.Name = "mainframe";
            this.mainframe.Size = new System.Drawing.Size(804, 599);
            this.mainframe.TabIndex = 0;
            this.mainframe.TabStop = false;
            // 
            // downloadBar
            // 
            this.downloadBar.Location = new System.Drawing.Point(20, 505);
            this.downloadBar.Margin = new System.Windows.Forms.Padding(0);
            this.downloadBar.Name = "downloadBar";
            this.downloadBar.Size = new System.Drawing.Size(592, 23);
            this.downloadBar.Step = 1;
            this.downloadBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.downloadBar.TabIndex = 2;
            // 
            // downloadSpeed
            // 
            this.downloadSpeed.AutoSize = true;
            this.downloadSpeed.BackColor = System.Drawing.Color.Transparent;
            this.downloadSpeed.Font = new System.Drawing.Font("GiovanniITCTT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadSpeed.ForeColor = System.Drawing.Color.Chocolate;
            this.downloadSpeed.Location = new System.Drawing.Point(19, 537);
            this.downloadSpeed.Margin = new System.Windows.Forms.Padding(0);
            this.downloadSpeed.Name = "downloadSpeed";
            this.downloadSpeed.Size = new System.Drawing.Size(87, 15);
            this.downloadSpeed.TabIndex = 3;
            this.downloadSpeed.Text = "Downloading:";
            // 
            // debugInfo
            // 
            this.debugInfo.AutoSize = true;
            this.debugInfo.Font = new System.Drawing.Font("Gentium Book Basic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.debugInfo.Location = new System.Drawing.Point(51, 113);
            this.debugInfo.Name = "debugInfo";
            this.debugInfo.Size = new System.Drawing.Size(77, 17);
            this.debugInfo.TabIndex = 4;
            this.debugInfo.Text = "Debug Info";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.Controls.Add(this.debugInfo);
            this.Controls.Add(this.downloadSpeed);
            this.Controls.Add(this.downloadBar);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.mainframe);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "Cataclysm Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.mainframe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainframe;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.ProgressBar downloadBar;
        private TransparentLabel downloadSpeed;
        private System.Windows.Forms.Label debugInfo;
    }
}

