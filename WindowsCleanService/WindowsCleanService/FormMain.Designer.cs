namespace WindowsCleanService
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.cbTemp = new System.Windows.Forms.CheckBox();
            this.cbPrefetch = new System.Windows.Forms.CheckBox();
            this.cbInstallerTemp = new System.Windows.Forms.CheckBox();
            this.cbDownloadTemp = new System.Windows.Forms.CheckBox();
            this.cbCleanMgr = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_execute = new System.Windows.Forms.Button();
            this.cbWindowsErrorReports = new System.Windows.Forms.CheckBox();
            this.cbWindowsTemp = new System.Windows.Forms.CheckBox();
            this.cbUserTemp = new System.Windows.Forms.CheckBox();
            this.cbRecycleBin = new System.Windows.Forms.CheckBox();
            this.cbWindowsLogs = new System.Windows.Forms.CheckBox();
            this.listBoxLogs = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTemp
            // 
            this.cbTemp.AutoSize = true;
            this.cbTemp.Location = new System.Drawing.Point(14, 23);
            this.cbTemp.Name = "cbTemp";
            this.cbTemp.Size = new System.Drawing.Size(53, 17);
            this.cbTemp.TabIndex = 0;
            this.cbTemp.Text = "Temp";
            this.cbTemp.UseVisualStyleBackColor = true;
            // 
            // cbPrefetch
            // 
            this.cbPrefetch.AutoSize = true;
            this.cbPrefetch.Location = new System.Drawing.Point(14, 46);
            this.cbPrefetch.Name = "cbPrefetch";
            this.cbPrefetch.Size = new System.Drawing.Size(66, 17);
            this.cbPrefetch.TabIndex = 1;
            this.cbPrefetch.Text = "Prefetch";
            this.cbPrefetch.UseVisualStyleBackColor = true;
            // 
            // cbInstallerTemp
            // 
            this.cbInstallerTemp.AutoSize = true;
            this.cbInstallerTemp.Location = new System.Drawing.Point(14, 69);
            this.cbInstallerTemp.Name = "cbInstallerTemp";
            this.cbInstallerTemp.Size = new System.Drawing.Size(92, 17);
            this.cbInstallerTemp.TabIndex = 2;
            this.cbInstallerTemp.Text = "Installer Temp";
            this.cbInstallerTemp.UseVisualStyleBackColor = true;
            // 
            // cbDownloadTemp
            // 
            this.cbDownloadTemp.AutoSize = true;
            this.cbDownloadTemp.Location = new System.Drawing.Point(14, 92);
            this.cbDownloadTemp.Name = "cbDownloadTemp";
            this.cbDownloadTemp.Size = new System.Drawing.Size(104, 17);
            this.cbDownloadTemp.TabIndex = 3;
            this.cbDownloadTemp.Text = "Download Temp";
            this.cbDownloadTemp.UseVisualStyleBackColor = true;
            // 
            // cbCleanMgr
            // 
            this.cbCleanMgr.AutoSize = true;
            this.cbCleanMgr.Location = new System.Drawing.Point(14, 115);
            this.cbCleanMgr.Name = "cbCleanMgr";
            this.cbCleanMgr.Size = new System.Drawing.Size(71, 17);
            this.cbCleanMgr.TabIndex = 4;
            this.cbCleanMgr.Text = "CleanMgr";
            this.cbCleanMgr.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_execute);
            this.groupBox1.Controls.Add(this.cbWindowsErrorReports);
            this.groupBox1.Controls.Add(this.cbWindowsTemp);
            this.groupBox1.Controls.Add(this.cbUserTemp);
            this.groupBox1.Controls.Add(this.cbRecycleBin);
            this.groupBox1.Controls.Add(this.cbWindowsLogs);
            this.groupBox1.Controls.Add(this.cbTemp);
            this.groupBox1.Controls.Add(this.cbCleanMgr);
            this.groupBox1.Controls.Add(this.cbPrefetch);
            this.groupBox1.Controls.Add(this.cbDownloadTemp);
            this.groupBox1.Controls.Add(this.cbInstallerTemp);
            this.groupBox1.Location = new System.Drawing.Point(12, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 147);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções";
            // 
            // btn_execute
            // 
            this.btn_execute.Location = new System.Drawing.Point(254, 53);
            this.btn_execute.Name = "btn_execute";
            this.btn_execute.Size = new System.Drawing.Size(80, 45);
            this.btn_execute.TabIndex = 5;
            this.btn_execute.Text = "Executar";
            this.btn_execute.UseVisualStyleBackColor = true;
            this.btn_execute.Click += new System.EventHandler(this.btn_execute_Click);
            // 
            // cbWindowsErrorReports
            // 
            this.cbWindowsErrorReports.AutoSize = true;
            this.cbWindowsErrorReports.Location = new System.Drawing.Point(127, 46);
            this.cbWindowsErrorReports.Name = "cbWindowsErrorReports";
            this.cbWindowsErrorReports.Size = new System.Drawing.Size(105, 17);
            this.cbWindowsErrorReports.TabIndex = 12;
            this.cbWindowsErrorReports.Text = "Windows Report";
            this.cbWindowsErrorReports.UseVisualStyleBackColor = true;
            // 
            // cbWindowsTemp
            // 
            this.cbWindowsTemp.AutoSize = true;
            this.cbWindowsTemp.Location = new System.Drawing.Point(127, 23);
            this.cbWindowsTemp.Name = "cbWindowsTemp";
            this.cbWindowsTemp.Size = new System.Drawing.Size(100, 17);
            this.cbWindowsTemp.TabIndex = 11;
            this.cbWindowsTemp.Text = "Windows Temp";
            this.cbWindowsTemp.UseVisualStyleBackColor = true;
            // 
            // cbUserTemp
            // 
            this.cbUserTemp.AutoSize = true;
            this.cbUserTemp.Location = new System.Drawing.Point(127, 115);
            this.cbUserTemp.Name = "cbUserTemp";
            this.cbUserTemp.Size = new System.Drawing.Size(78, 17);
            this.cbUserTemp.TabIndex = 10;
            this.cbUserTemp.Text = "User Temp";
            this.cbUserTemp.UseVisualStyleBackColor = true;
            // 
            // cbRecycleBin
            // 
            this.cbRecycleBin.AutoSize = true;
            this.cbRecycleBin.Location = new System.Drawing.Point(127, 92);
            this.cbRecycleBin.Name = "cbRecycleBin";
            this.cbRecycleBin.Size = new System.Drawing.Size(83, 17);
            this.cbRecycleBin.TabIndex = 8;
            this.cbRecycleBin.Text = "Recycle Bin";
            this.cbRecycleBin.UseVisualStyleBackColor = true;
            // 
            // cbWindowsLogs
            // 
            this.cbWindowsLogs.AutoSize = true;
            this.cbWindowsLogs.Location = new System.Drawing.Point(127, 69);
            this.cbWindowsLogs.Name = "cbWindowsLogs";
            this.cbWindowsLogs.Size = new System.Drawing.Size(96, 17);
            this.cbWindowsLogs.TabIndex = 7;
            this.cbWindowsLogs.Text = "Windows Logs";
            this.cbWindowsLogs.UseVisualStyleBackColor = true;
            // 
            // listBoxLogs
            // 
            this.listBoxLogs.FormattingEnabled = true;
            this.listBoxLogs.Location = new System.Drawing.Point(12, 343);
            this.listBoxLogs.Name = "listBoxLogs";
            this.listBoxLogs.Size = new System.Drawing.Size(350, 303);
            this.listBoxLogs.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsCleanService.Properties.Resources._24255;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 186);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(374, 668);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBoxLogs);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[WCS] - Windows Clean Service";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbTemp;
        private System.Windows.Forms.CheckBox cbPrefetch;
        private System.Windows.Forms.CheckBox cbInstallerTemp;
        private System.Windows.Forms.CheckBox cbDownloadTemp;
        private System.Windows.Forms.CheckBox cbCleanMgr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_execute;
        private System.Windows.Forms.ListBox listBoxLogs;
        private System.Windows.Forms.CheckBox cbUserTemp;
        private System.Windows.Forms.CheckBox cbRecycleBin;
        private System.Windows.Forms.CheckBox cbWindowsLogs;
        private System.Windows.Forms.CheckBox cbWindowsErrorReports;
        private System.Windows.Forms.CheckBox cbWindowsTemp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

