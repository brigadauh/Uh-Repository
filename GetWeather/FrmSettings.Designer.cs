namespace GetWeather
{
    partial class FrmSettings
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
            this.LstStation = new System.Windows.Forms.ListBox();
            this.SetBtnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstStation
            // 
            this.LstStation.FormattingEnabled = true;
            this.LstStation.Location = new System.Drawing.Point(28, 43);
            this.LstStation.Name = "LstStation";
            this.LstStation.Size = new System.Drawing.Size(231, 147);
            this.LstStation.TabIndex = 0;
            // 
            // SetBtnSave
            // 
            this.SetBtnSave.Location = new System.Drawing.Point(97, 209);
            this.SetBtnSave.Name = "SetBtnSave";
            this.SetBtnSave.Size = new System.Drawing.Size(78, 23);
            this.SetBtnSave.TabIndex = 1;
            this.SetBtnSave.Text = "Save";
            this.SetBtnSave.UseVisualStyleBackColor = true;
            this.SetBtnSave.Click += new System.EventHandler(this.SetBtnSave_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.SetBtnSave);
            this.Controls.Add(this.LstStation);
            this.Name = "FrmSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstStation;
        private System.Windows.Forms.Button SetBtnSave;
    }
}