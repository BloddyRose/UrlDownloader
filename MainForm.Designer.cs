namespace UrlDownloader
{
    partial class UrlDownloader
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UrlBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DownloadingLbl = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DownloadedLbl = new System.Windows.Forms.Label();
            this.SpeedLbl = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.ResumeBtn = new System.Windows.Forms.Button();
            this.saveFolderBtn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.ProgressLbl = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.supportResumeLbl = new System.Windows.Forms.Label();
            this.fileSizeLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.filenameLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.savingTxtbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Url:";
            this.toolTip1.SetToolTip(this.label2, "Please enter a url that hase and extension at the end ");
            // 
            // UrlBox
            // 
            this.UrlBox.AllowDrop = true;
            this.UrlBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrlBox.Location = new System.Drawing.Point(46, 4);
            this.UrlBox.Name = "UrlBox";
            this.UrlBox.Size = new System.Drawing.Size(742, 22);
            this.UrlBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.UrlBox, "Please enter a url that hase and extension at the end \r\n");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Status: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Downloading: ";
            // 
            // DownloadingLbl
            // 
            this.DownloadingLbl.AutoSize = true;
            this.DownloadingLbl.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadingLbl.Location = new System.Drawing.Point(171, 136);
            this.DownloadingLbl.Name = "DownloadingLbl";
            this.DownloadingLbl.Size = new System.Drawing.Size(26, 13);
            this.DownloadingLbl.TabIndex = 6;
            this.DownloadingLbl.Text = "N/A";
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLbl.Location = new System.Drawing.Point(171, 112);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(26, 13);
            this.StatusLbl.TabIndex = 5;
            this.StatusLbl.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Downloaded:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Speed:";
            // 
            // DownloadedLbl
            // 
            this.DownloadedLbl.AutoSize = true;
            this.DownloadedLbl.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadedLbl.Location = new System.Drawing.Point(171, 178);
            this.DownloadedLbl.Name = "DownloadedLbl";
            this.DownloadedLbl.Size = new System.Drawing.Size(26, 13);
            this.DownloadedLbl.TabIndex = 10;
            this.DownloadedLbl.Text = "N/A";
            // 
            // SpeedLbl
            // 
            this.SpeedLbl.AutoSize = true;
            this.SpeedLbl.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedLbl.Location = new System.Drawing.Point(171, 159);
            this.SpeedLbl.Name = "SpeedLbl";
            this.SpeedLbl.Size = new System.Drawing.Size(26, 13);
            this.SpeedLbl.TabIndex = 9;
            this.SpeedLbl.Text = "N/A";
            // 
            // StartBtn
            // 
            this.StartBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.StartBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Aqua;
            this.StartBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StartBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.StartBtn.Location = new System.Drawing.Point(243, 70);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 27);
            this.StartBtn.TabIndex = 11;
            this.StartBtn.Text = "Start";
            this.toolTip1.SetToolTip(this.StartBtn, "Start the downloader");
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // PauseBtn
            // 
            this.PauseBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.PauseBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Aqua;
            this.PauseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PauseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.PauseBtn.Location = new System.Drawing.Point(324, 70);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(75, 27);
            this.PauseBtn.TabIndex = 12;
            this.PauseBtn.Text = "Pause";
            this.toolTip1.SetToolTip(this.PauseBtn, "Pause the downloader");
            this.PauseBtn.UseVisualStyleBackColor = true;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // ResumeBtn
            // 
            this.ResumeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ResumeBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Aqua;
            this.ResumeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ResumeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.ResumeBtn.Location = new System.Drawing.Point(405, 70);
            this.ResumeBtn.Name = "ResumeBtn";
            this.ResumeBtn.Size = new System.Drawing.Size(75, 27);
            this.ResumeBtn.TabIndex = 13;
            this.ResumeBtn.Text = "Resume";
            this.toolTip1.SetToolTip(this.ResumeBtn, "Resume the downloader");
            this.ResumeBtn.UseVisualStyleBackColor = true;
            this.ResumeBtn.Click += new System.EventHandler(this.ResumeBtn_Click);
            // 
            // saveFolderBtn
            // 
            this.saveFolderBtn.Location = new System.Drawing.Point(698, 40);
            this.saveFolderBtn.Name = "saveFolderBtn";
            this.saveFolderBtn.Size = new System.Drawing.Size(28, 22);
            this.saveFolderBtn.TabIndex = 14;
            this.saveFolderBtn.Text = "...";
            this.saveFolderBtn.UseVisualStyleBackColor = true;
            this.saveFolderBtn.Click += new System.EventHandler(this.saveFolderBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(502, 103);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(286, 23);
            this.progressBar.TabIndex = 15;
            // 
            // ProgressLbl
            // 
            this.ProgressLbl.AutoSize = true;
            this.ProgressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressLbl.Location = new System.Drawing.Point(727, 84);
            this.ProgressLbl.Name = "ProgressLbl";
            this.ProgressLbl.Size = new System.Drawing.Size(24, 13);
            this.ProgressLbl.TabIndex = 16;
            this.ProgressLbl.Text = "0 %";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Helper";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Support Resume: ";
            // 
            // supportResumeLbl
            // 
            this.supportResumeLbl.AutoSize = true;
            this.supportResumeLbl.Location = new System.Drawing.Point(358, 159);
            this.supportResumeLbl.Name = "supportResumeLbl";
            this.supportResumeLbl.Size = new System.Drawing.Size(27, 13);
            this.supportResumeLbl.TabIndex = 18;
            this.supportResumeLbl.Text = "N/A";
            // 
            // fileSizeLbl
            // 
            this.fileSizeLbl.AutoSize = true;
            this.fileSizeLbl.Location = new System.Drawing.Point(358, 112);
            this.fileSizeLbl.Name = "fileSizeLbl";
            this.fileSizeLbl.Size = new System.Drawing.Size(27, 13);
            this.fileSizeLbl.TabIndex = 20;
            this.fileSizeLbl.Text = "N/A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(260, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "File Size:";
            // 
            // filenameLbl
            // 
            this.filenameLbl.AutoSize = true;
            this.filenameLbl.Location = new System.Drawing.Point(358, 136);
            this.filenameLbl.Name = "filenameLbl";
            this.filenameLbl.Size = new System.Drawing.Size(27, 13);
            this.filenameLbl.TabIndex = 22;
            this.filenameLbl.Text = "N/A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(260, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "File Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(586, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Progress:";
            // 
            // savingTxtbox
            // 
            this.savingTxtbox.Location = new System.Drawing.Point(77, 42);
            this.savingTxtbox.Name = "savingTxtbox";
            this.savingTxtbox.Size = new System.Drawing.Size(615, 20);
            this.savingTxtbox.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "Saving to: ";
            this.toolTip1.SetToolTip(this.label11, "Please enter a url that hase and extension at the end ");
            // 
            // UrlDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 201);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.savingTxtbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.filenameLbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.fileSizeLbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.supportResumeLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ProgressLbl);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.saveFolderBtn);
            this.Controls.Add(this.ResumeBtn);
            this.Controls.Add(this.PauseBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.DownloadedLbl);
            this.Controls.Add(this.SpeedLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DownloadingLbl);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UrlBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "UrlDownloader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Url-Downloader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UrlDownloader_FormClosing);
            this.Load += new System.EventHandler(this.UrlDownloader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UrlBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DownloadingLbl;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label DownloadedLbl;
        private System.Windows.Forms.Label SpeedLbl;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button PauseBtn;
        private System.Windows.Forms.Button ResumeBtn;
        private System.Windows.Forms.Button saveFolderBtn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label ProgressLbl;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label supportResumeLbl;
        private System.Windows.Forms.Label fileSizeLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label filenameLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox savingTxtbox;
        private System.Windows.Forms.Label label11;
    }
}