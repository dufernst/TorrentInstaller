namespace TorrentInstaller
{
    partial class SettingsMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.restoreDefault = new System.Windows.Forms.PictureBox();
            this.cancelButton = new System.Windows.Forms.PictureBox();
            this.acceptButton = new System.Windows.Forms.PictureBox();
            this.maxDownloadSpeedText = new TorrentInstaller.TransparentLabel();
            this.maxUploadSpeedText = new TorrentInstaller.TransparentLabel();
            this.maxConnectionsText = new TorrentInstaller.TransparentLabel();
            this.allowSeedingText = new TorrentInstaller.TransparentLabel();
            this.allowUnencryptedText = new TorrentInstaller.TransparentLabel();
            this.allowSeeding = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.usedPortText = new TorrentInstaller.TransparentLabel();
            this.useRandomPort = new System.Windows.Forms.RadioButton();
            this.randomUsedText = new TorrentInstaller.TransparentLabel();
            this.useGivenPort = new System.Windows.Forms.RadioButton();
            this.maxDownloadSpeed = new System.Windows.Forms.NumericUpDown();
            this.maxUploadSpeed = new System.Windows.Forms.NumericUpDown();
            this.maxConnections = new System.Windows.Forms.NumericUpDown();
            this.usedPort = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.restoreDefault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxDownloadSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxUploadSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxConnections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usedPort)).BeginInit();
            this.SuspendLayout();
            // 
            // restoreDefault
            // 
            this.restoreDefault.BackColor = System.Drawing.Color.Black;
            this.restoreDefault.BackgroundImage = global::TorrentInstaller.Properties.Resources.Restore_Default_Not_Usable;
            this.restoreDefault.Location = new System.Drawing.Point(137, 348);
            this.restoreDefault.Margin = new System.Windows.Forms.Padding(0);
            this.restoreDefault.Name = "restoreDefault";
            this.restoreDefault.Size = new System.Drawing.Size(181, 21);
            this.restoreDefault.TabIndex = 0;
            this.restoreDefault.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Black;
            this.cancelButton.BackgroundImage = global::TorrentInstaller.Properties.Resources.Cancel_Button_Normal;
            this.cancelButton.Location = new System.Drawing.Point(137, 372);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(91, 32);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.TabStop = false;
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.Color.Black;
            this.acceptButton.BackgroundImage = global::TorrentInstaller.Properties.Resources.Accept_Button_Normal;
            this.acceptButton.Location = new System.Drawing.Point(228, 372);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(0);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(91, 32);
            this.acceptButton.TabIndex = 2;
            this.acceptButton.TabStop = false;
            // 
            // maxDownloadSpeedText
            // 
            this.maxDownloadSpeedText.AutoSize = true;
            this.maxDownloadSpeedText.BackColor = System.Drawing.Color.Transparent;
            this.maxDownloadSpeedText.Font = new System.Drawing.Font("GiovanniITCTT", 9.75F);
            this.maxDownloadSpeedText.ForeColor = System.Drawing.Color.Chocolate;
            this.maxDownloadSpeedText.Location = new System.Drawing.Point(64, 66);
            this.maxDownloadSpeedText.Name = "maxDownloadSpeedText";
            this.maxDownloadSpeedText.Size = new System.Drawing.Size(164, 15);
            this.maxDownloadSpeedText.TabIndex = 3;
            this.maxDownloadSpeedText.Text = "Maximum Download Speed";
            // 
            // maxUploadSpeedText
            // 
            this.maxUploadSpeedText.AutoSize = true;
            this.maxUploadSpeedText.BackColor = System.Drawing.Color.Transparent;
            this.maxUploadSpeedText.Font = new System.Drawing.Font("GiovanniITCTT", 9.75F);
            this.maxUploadSpeedText.ForeColor = System.Drawing.Color.Chocolate;
            this.maxUploadSpeedText.Location = new System.Drawing.Point(82, 96);
            this.maxUploadSpeedText.Name = "maxUploadSpeedText";
            this.maxUploadSpeedText.Size = new System.Drawing.Size(146, 15);
            this.maxUploadSpeedText.TabIndex = 4;
            this.maxUploadSpeedText.Text = "Maximum Upload Speed";
            // 
            // maxConnectionsText
            // 
            this.maxConnectionsText.AutoSize = true;
            this.maxConnectionsText.BackColor = System.Drawing.Color.Transparent;
            this.maxConnectionsText.Font = new System.Drawing.Font("GiovanniITCTT", 9.75F);
            this.maxConnectionsText.ForeColor = System.Drawing.Color.Chocolate;
            this.maxConnectionsText.Location = new System.Drawing.Point(77, 126);
            this.maxConnectionsText.Name = "maxConnectionsText";
            this.maxConnectionsText.Size = new System.Drawing.Size(151, 15);
            this.maxConnectionsText.TabIndex = 5;
            this.maxConnectionsText.Text = "# Maximum Connections";
            // 
            // allowSeedingText
            // 
            this.allowSeedingText.AutoSize = true;
            this.allowSeedingText.BackColor = System.Drawing.Color.Transparent;
            this.allowSeedingText.Font = new System.Drawing.Font("GiovanniITCTT", 9.75F);
            this.allowSeedingText.ForeColor = System.Drawing.Color.Chocolate;
            this.allowSeedingText.Location = new System.Drawing.Point(141, 154);
            this.allowSeedingText.Name = "allowSeedingText";
            this.allowSeedingText.Size = new System.Drawing.Size(87, 15);
            this.allowSeedingText.TabIndex = 6;
            this.allowSeedingText.Text = "Allow Seeding";
            // 
            // allowUnencryptedText
            // 
            this.allowUnencryptedText.AutoSize = true;
            this.allowUnencryptedText.BackColor = System.Drawing.Color.Transparent;
            this.allowUnencryptedText.Font = new System.Drawing.Font("GiovanniITCTT", 9.75F);
            this.allowUnencryptedText.ForeColor = System.Drawing.Color.Chocolate;
            this.allowUnencryptedText.Location = new System.Drawing.Point(37, 182);
            this.allowUnencryptedText.Name = "allowUnencryptedText";
            this.allowUnencryptedText.Size = new System.Drawing.Size(191, 15);
            this.allowUnencryptedText.TabIndex = 7;
            this.allowUnencryptedText.Text = "Allow Unencrypted Connections";
            // 
            // allowSeeding
            // 
            this.allowSeeding.Checked = true;
            this.allowSeeding.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allowSeeding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allowSeeding.Location = new System.Drawing.Point(245, 157);
            this.allowSeeding.Margin = new System.Windows.Forms.Padding(0);
            this.allowSeeding.Name = "allowSeeding";
            this.allowSeeding.Size = new System.Drawing.Size(10, 10);
            this.allowSeeding.TabIndex = 8;
            this.allowSeeding.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(245, 184);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(10, 10);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // usedPortText
            // 
            this.usedPortText.AutoSize = true;
            this.usedPortText.BackColor = System.Drawing.Color.Transparent;
            this.usedPortText.Font = new System.Drawing.Font("GiovanniITCTT", 9.75F);
            this.usedPortText.ForeColor = System.Drawing.Color.Chocolate;
            this.usedPortText.Location = new System.Drawing.Point(167, 210);
            this.usedPortText.Name = "usedPortText";
            this.usedPortText.Size = new System.Drawing.Size(61, 15);
            this.usedPortText.TabIndex = 10;
            this.usedPortText.Text = "Used Port";
            // 
            // useRandomPort
            // 
            this.useRandomPort.BackColor = System.Drawing.Color.Black;
            this.useRandomPort.Checked = true;
            this.useRandomPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.useRandomPort.Location = new System.Drawing.Point(245, 211);
            this.useRandomPort.Margin = new System.Windows.Forms.Padding(0);
            this.useRandomPort.Name = "useRandomPort";
            this.useRandomPort.Size = new System.Drawing.Size(12, 10);
            this.useRandomPort.TabIndex = 11;
            this.useRandomPort.TabStop = true;
            this.useRandomPort.UseVisualStyleBackColor = false;
            // 
            // randomUsedText
            // 
            this.randomUsedText.AutoSize = true;
            this.randomUsedText.BackColor = System.Drawing.Color.Transparent;
            this.randomUsedText.Font = new System.Drawing.Font("GiovanniITCTT", 9.75F);
            this.randomUsedText.ForeColor = System.Drawing.Color.Chocolate;
            this.randomUsedText.Location = new System.Drawing.Point(256, 209);
            this.randomUsedText.Name = "randomUsedText";
            this.randomUsedText.Size = new System.Drawing.Size(52, 15);
            this.randomUsedText.TabIndex = 12;
            this.randomUsedText.Text = "random";
            // 
            // useGivenPort
            // 
            this.useGivenPort.BackColor = System.Drawing.Color.Black;
            this.useGivenPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.useGivenPort.Location = new System.Drawing.Point(319, 211);
            this.useGivenPort.Margin = new System.Windows.Forms.Padding(0);
            this.useGivenPort.Name = "useGivenPort";
            this.useGivenPort.Size = new System.Drawing.Size(12, 10);
            this.useGivenPort.TabIndex = 13;
            this.useGivenPort.UseVisualStyleBackColor = false;
            // 
            // maxDownloadSpeed
            // 
            this.maxDownloadSpeed.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.maxDownloadSpeed.Location = new System.Drawing.Point(245, 61);
            this.maxDownloadSpeed.Margin = new System.Windows.Forms.Padding(0);
            this.maxDownloadSpeed.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.maxDownloadSpeed.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.maxDownloadSpeed.Name = "maxDownloadSpeed";
            this.maxDownloadSpeed.Size = new System.Drawing.Size(100, 20);
            this.maxDownloadSpeed.TabIndex = 18;
            this.maxDownloadSpeed.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // maxUploadSpeed
            // 
            this.maxUploadSpeed.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.maxUploadSpeed.Location = new System.Drawing.Point(245, 91);
            this.maxUploadSpeed.Margin = new System.Windows.Forms.Padding(0);
            this.maxUploadSpeed.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.maxUploadSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxUploadSpeed.Name = "maxUploadSpeed";
            this.maxUploadSpeed.Size = new System.Drawing.Size(100, 20);
            this.maxUploadSpeed.TabIndex = 19;
            this.maxUploadSpeed.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // maxConnections
            // 
            this.maxConnections.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.maxConnections.Location = new System.Drawing.Point(245, 121);
            this.maxConnections.Margin = new System.Windows.Forms.Padding(0);
            this.maxConnections.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.maxConnections.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.maxConnections.Name = "maxConnections";
            this.maxConnections.Size = new System.Drawing.Size(100, 20);
            this.maxConnections.TabIndex = 20;
            this.maxConnections.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // usedPort
            // 
            this.usedPort.Location = new System.Drawing.Point(334, 205);
            this.usedPort.Margin = new System.Windows.Forms.Padding(0);
            this.usedPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.usedPort.Minimum = new decimal(new int[] {
            49152,
            0,
            0,
            0});
            this.usedPort.Name = "usedPort";
            this.usedPort.Size = new System.Drawing.Size(100, 20);
            this.usedPort.TabIndex = 21;
            this.usedPort.Value = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            // 
            // SettingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TorrentInstaller.Properties.Resources.Setting_Menu;
            this.Controls.Add(this.usedPort);
            this.Controls.Add(this.maxConnections);
            this.Controls.Add(this.maxUploadSpeed);
            this.Controls.Add(this.maxDownloadSpeed);
            this.Controls.Add(this.useGivenPort);
            this.Controls.Add(this.randomUsedText);
            this.Controls.Add(this.useRandomPort);
            this.Controls.Add(this.usedPortText);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.allowSeeding);
            this.Controls.Add(this.allowUnencryptedText);
            this.Controls.Add(this.allowSeedingText);
            this.Controls.Add(this.maxConnectionsText);
            this.Controls.Add(this.maxUploadSpeedText);
            this.Controls.Add(this.maxDownloadSpeedText);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.restoreDefault);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SettingsMenu";
            this.Size = new System.Drawing.Size(460, 410);
            ((System.ComponentModel.ISupportInitialize)(this.restoreDefault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxDownloadSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxUploadSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxConnections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usedPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox restoreDefault;
        private System.Windows.Forms.PictureBox cancelButton;
        private System.Windows.Forms.PictureBox acceptButton;
        private TransparentLabel maxDownloadSpeedText;
        private TransparentLabel maxUploadSpeedText;
        private TransparentLabel maxConnectionsText;
        private TransparentLabel allowSeedingText;
        private TransparentLabel allowUnencryptedText;
        private System.Windows.Forms.CheckBox allowSeeding;
        private System.Windows.Forms.CheckBox checkBox1;
        private TransparentLabel usedPortText;
        private System.Windows.Forms.RadioButton useRandomPort;
        private TransparentLabel randomUsedText;
        private System.Windows.Forms.RadioButton useGivenPort;
        private System.Windows.Forms.NumericUpDown maxDownloadSpeed;
        private System.Windows.Forms.NumericUpDown maxUploadSpeed;
        private System.Windows.Forms.NumericUpDown maxConnections;
        private System.Windows.Forms.NumericUpDown usedPort;
    }
}
