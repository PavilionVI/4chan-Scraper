namespace _4chanScraper
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gbPath = new System.Windows.Forms.GroupBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.cbWEBM = new System.Windows.Forms.CheckBox();
            this.rbOrg = new System.Windows.Forms.RadioButton();
            this.rbUID = new System.Windows.Forms.RadioButton();
            this.cbDuplicates = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.pbMain = new System.Windows.Forms.ProgressBar();
            this.gbDownload = new System.Windows.Forms.GroupBox();
            this.txtThread = new System.Windows.Forms.TextBox();
            this.gbPath.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.gbDownload.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPath
            // 
            this.gbPath.Controls.Add(this.btnPath);
            this.gbPath.Controls.Add(this.txtPath);
            this.gbPath.Location = new System.Drawing.Point(12, 7);
            this.gbPath.Name = "gbPath";
            this.gbPath.Size = new System.Drawing.Size(349, 54);
            this.gbPath.TabIndex = 3;
            this.gbPath.TabStop = false;
            this.gbPath.Text = "Directory";
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(266, 18);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(75, 23);
            this.btnPath.TabIndex = 0;
            this.btnPath.Text = "Browse";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(9, 20);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(248, 20);
            this.txtPath.TabIndex = 0;
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.cbWEBM);
            this.gbOptions.Controls.Add(this.rbOrg);
            this.gbOptions.Controls.Add(this.rbUID);
            this.gbOptions.Controls.Add(this.cbDuplicates);
            this.gbOptions.Enabled = false;
            this.gbOptions.Location = new System.Drawing.Point(12, 66);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(349, 69);
            this.gbOptions.TabIndex = 4;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // cbWEBM
            // 
            this.cbWEBM.AutoSize = true;
            this.cbWEBM.Location = new System.Drawing.Point(9, 40);
            this.cbWEBM.Name = "cbWEBM";
            this.cbWEBM.Size = new System.Drawing.Size(114, 17);
            this.cbWEBM.TabIndex = 2;
            this.cbWEBM.Text = "Download .WEBM";
            this.cbWEBM.UseVisualStyleBackColor = true;
            // 
            // rbOrg
            // 
            this.rbOrg.AutoSize = true;
            this.rbOrg.Checked = true;
            this.rbOrg.Location = new System.Drawing.Point(215, 39);
            this.rbOrg.Name = "rbOrg";
            this.rbOrg.Size = new System.Drawing.Size(115, 17);
            this.rbOrg.TabIndex = 4;
            this.rbOrg.TabStop = true;
            this.rbOrg.Text = "Keep original name";
            this.rbOrg.UseVisualStyleBackColor = true;
            // 
            // rbUID
            // 
            this.rbUID.AutoSize = true;
            this.rbUID.Location = new System.Drawing.Point(215, 18);
            this.rbUID.Name = "rbUID";
            this.rbUID.Size = new System.Drawing.Size(126, 17);
            this.rbUID.TabIndex = 3;
            this.rbUID.Text = "Use issued upload ID";
            this.rbUID.UseVisualStyleBackColor = true;
            this.rbUID.CheckedChanged += new System.EventHandler(this.rbUID_CheckedChanged);
            // 
            // cbDuplicates
            // 
            this.cbDuplicates.AutoSize = true;
            this.cbDuplicates.Checked = true;
            this.cbDuplicates.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDuplicates.Location = new System.Drawing.Point(9, 19);
            this.cbDuplicates.Name = "cbDuplicates";
            this.cbDuplicates.Size = new System.Drawing.Size(143, 17);
            this.cbDuplicates.TabIndex = 1;
            this.cbDuplicates.Text = "Omit duplicate file names";
            this.cbDuplicates.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(266, 50);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pbMain
            // 
            this.pbMain.Enabled = false;
            this.pbMain.Location = new System.Drawing.Point(9, 50);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(248, 23);
            this.pbMain.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbMain.TabIndex = 3;
            // 
            // gbDownload
            // 
            this.gbDownload.Controls.Add(this.txtThread);
            this.gbDownload.Controls.Add(this.btnStart);
            this.gbDownload.Controls.Add(this.pbMain);
            this.gbDownload.Enabled = false;
            this.gbDownload.Location = new System.Drawing.Point(12, 140);
            this.gbDownload.Name = "gbDownload";
            this.gbDownload.Size = new System.Drawing.Size(349, 86);
            this.gbDownload.TabIndex = 5;
            this.gbDownload.TabStop = false;
            this.gbDownload.Text = "Download";
            // 
            // txtThread
            // 
            this.txtThread.Location = new System.Drawing.Point(9, 20);
            this.txtThread.Name = "txtThread";
            this.txtThread.Size = new System.Drawing.Size(332, 20);
            this.txtThread.TabIndex = 5;
            this.txtThread.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtThread_KeyDown);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 238);
            this.Controls.Add(this.gbPath);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.gbDownload);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4chan Scraper | Idle";
            this.gbPath.ResumeLayout(false);
            this.gbPath.PerformLayout();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.gbDownload.ResumeLayout(false);
            this.gbDownload.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gbPath;
        internal System.Windows.Forms.Button btnPath;
        internal System.Windows.Forms.TextBox txtPath;
        internal System.Windows.Forms.GroupBox gbOptions;
        internal System.Windows.Forms.CheckBox cbWEBM;
        internal System.Windows.Forms.RadioButton rbOrg;
        internal System.Windows.Forms.RadioButton rbUID;
        internal System.Windows.Forms.CheckBox cbDuplicates;
        internal System.Windows.Forms.Button btnStart;
        internal System.Windows.Forms.ProgressBar pbMain;
        internal System.Windows.Forms.GroupBox gbDownload;
        internal System.Windows.Forms.TextBox txtThread;
    }
}

