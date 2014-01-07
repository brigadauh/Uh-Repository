namespace GetWeather
{
    partial class FrmWeather
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWeather));
            this.LblTemp = new System.Windows.Forms.Label();
            this.LblPr = new System.Windows.Forms.Label();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.LblWndDir = new System.Windows.Forms.Label();
            this.LblHumid = new System.Windows.Forms.Label();
            this.LblWndChill = new System.Windows.Forms.Label();
            this.LblSky = new System.Windows.Forms.Label();
            this.LblObservTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LblNextRead = new System.Windows.Forms.Label();
            this.BtnHistory = new System.Windows.Forms.Button();
            this.BtnEvent = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.LblStation = new System.Windows.Forms.Label();
            this.WeatherNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // LblTemp
            // 
            this.LblTemp.AutoSize = true;
            this.LblTemp.Location = new System.Drawing.Point(12, 36);
            this.LblTemp.Name = "LblTemp";
            this.LblTemp.Size = new System.Drawing.Size(21, 13);
            this.LblTemp.TabIndex = 1;
            this.LblTemp.Text = "t°C";
            // 
            // LblPr
            // 
            this.LblPr.AutoSize = true;
            this.LblPr.Location = new System.Drawing.Point(12, 49);
            this.LblPr.Name = "LblPr";
            this.LblPr.Size = new System.Drawing.Size(36, 13);
            this.LblPr.TabIndex = 2;
            this.LblPr.Text = "Pr.mm";
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.BtnRefresh.Location = new System.Drawing.Point(81, 148);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(56, 25);
            this.BtnRefresh.TabIndex = 4;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // LblWndDir
            // 
            this.LblWndDir.AutoSize = true;
            this.LblWndDir.Location = new System.Drawing.Point(12, 62);
            this.LblWndDir.Name = "LblWndDir";
            this.LblWndDir.Size = new System.Drawing.Size(32, 13);
            this.LblWndDir.TabIndex = 5;
            this.LblWndDir.Text = "Wind";
            // 
            // LblHumid
            // 
            this.LblHumid.AutoSize = true;
            this.LblHumid.Location = new System.Drawing.Point(12, 75);
            this.LblHumid.Name = "LblHumid";
            this.LblHumid.Size = new System.Drawing.Size(47, 13);
            this.LblHumid.TabIndex = 6;
            this.LblHumid.Text = "Humidity";
            // 
            // LblWndChill
            // 
            this.LblWndChill.AutoSize = true;
            this.LblWndChill.Location = new System.Drawing.Point(12, 88);
            this.LblWndChill.Name = "LblWndChill";
            this.LblWndChill.Size = new System.Drawing.Size(54, 13);
            this.LblWndChill.TabIndex = 7;
            this.LblWndChill.Text = "Wind Chill";
            // 
            // LblSky
            // 
            this.LblSky.AutoSize = true;
            this.LblSky.Location = new System.Drawing.Point(12, 23);
            this.LblSky.Name = "LblSky";
            this.LblSky.Size = new System.Drawing.Size(25, 13);
            this.LblSky.TabIndex = 8;
            this.LblSky.Text = "Sky";
            // 
            // LblObservTime
            // 
            this.LblObservTime.AutoSize = true;
            this.LblObservTime.Location = new System.Drawing.Point(12, 101);
            this.LblObservTime.Name = "LblObservTime";
            this.LblObservTime.Size = new System.Drawing.Size(65, 13);
            this.LblObservTime.TabIndex = 9;
            this.LblObservTime.Text = "Last Update";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LblNextRead
            // 
            this.LblNextRead.AutoSize = true;
            this.LblNextRead.Location = new System.Drawing.Point(12, 114);
            this.LblNextRead.Name = "LblNextRead";
            this.LblNextRead.Size = new System.Drawing.Size(75, 13);
            this.LblNextRead.TabIndex = 10;
            this.LblNextRead.Text = "Next Reading:";
            // 
            // BtnHistory
            // 
            this.BtnHistory.Location = new System.Drawing.Point(21, 179);
            this.BtnHistory.Name = "BtnHistory";
            this.BtnHistory.Size = new System.Drawing.Size(56, 22);
            this.BtnHistory.TabIndex = 11;
            this.BtnHistory.Text = "History";
            this.BtnHistory.UseVisualStyleBackColor = true;
            this.BtnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
            // 
            // BtnEvent
            // 
            this.BtnEvent.Location = new System.Drawing.Point(83, 179);
            this.BtnEvent.Name = "BtnEvent";
            this.BtnEvent.Size = new System.Drawing.Size(54, 22);
            this.BtnEvent.TabIndex = 12;
            this.BtnEvent.Text = "Events";
            this.BtnEvent.UseVisualStyleBackColor = true;
            this.BtnEvent.Click += new System.EventHandler(this.BtnEvent_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.Location = new System.Drawing.Point(143, 179);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(54, 22);
            this.BtnSettings.TabIndex = 13;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // LblStation
            // 
            this.LblStation.AutoSize = true;
            this.LblStation.Location = new System.Drawing.Point(12, 9);
            this.LblStation.Name = "LblStation";
            this.LblStation.Size = new System.Drawing.Size(40, 13);
            this.LblStation.TabIndex = 14;
            this.LblStation.Text = "Station";
            // 
            // WeatherNotifyIcon
            // 
            this.WeatherNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("WeatherNotifyIcon.Icon")));
            this.WeatherNotifyIcon.Text = "Current Weather";
            this.WeatherNotifyIcon.Visible = true;
            this.WeatherNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.WeatherNotifyIcon_MouseDoubleClick);
            // 
            // FrmWeather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 207);
            this.Controls.Add(this.LblStation);
            this.Controls.Add(this.BtnSettings);
            this.Controls.Add(this.BtnEvent);
            this.Controls.Add(this.BtnHistory);
            this.Controls.Add(this.LblNextRead);
            this.Controls.Add(this.LblObservTime);
            this.Controls.Add(this.LblSky);
            this.Controls.Add(this.LblWndChill);
            this.Controls.Add(this.LblHumid);
            this.Controls.Add(this.LblWndDir);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.LblPr);
            this.Controls.Add(this.LblTemp);
            this.Name = "FrmWeather";
            this.Text = "Current Conditions";
            this.Load += new System.EventHandler(this.FrmWeather_Load);
            this.Resize += new System.EventHandler(this.FrmWeather_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTemp;
        private System.Windows.Forms.Label LblPr;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Label LblWndDir;
        private System.Windows.Forms.Label LblHumid;
        private System.Windows.Forms.Label LblWndChill;
        private System.Windows.Forms.Label LblSky;
        private System.Windows.Forms.Label LblObservTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LblNextRead;
        private System.Windows.Forms.Button BtnHistory;
        private System.Windows.Forms.Button BtnEvent;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Label LblStation;
        private System.Windows.Forms.NotifyIcon WeatherNotifyIcon;
    }
}

