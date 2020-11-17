// Thanks Alto For the great library 
using AltoHttp;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Windows.Shell;

namespace UrlDownloader
{
    public partial class UrlDownloader : Form
    {
        // global variabiles
        private HttpDownloader downloader;
        private readonly TaskbarItemInfo taskbar = new TaskbarItemInfo();
        private bool isResume;
        private string filename;
        private long filesize;
        private static string folder;
        private static string file;
        private static string outputpath;
        // Constructor
        public UrlDownloader()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Downloading the file 
                linkToFileFolder.Visible = false;
                downloader = new HttpDownloader(file, outputpath);
                
                downloader.DownloadCompleted += Downloader_DownloadCompleted;
                downloader.ProgressChanged += Downloader_ProgressChanged;
                downloader.DownloadInfoReceived += Downloader_DownloadInfoReceived;
                if (string.IsNullOrEmpty(UrlBox.Text) && string.IsNullOrEmpty(savingTxtbox.Text))
                {
                    MessageBox.Show("Fields can't be empty!", "Error");
                    UrlBox.Focus();
                    return;
                }
                else
                {
                    downloader.Start();
                    if (isResume == false)
                    {
                        supportResumeLbl.Text = "No";
                        PauseBtn.Enabled = false;
                        ResumeBtn.Enabled = false;
                    }
                    else
                    {
                        supportResumeLbl.Text = "Yes";
                        PauseBtn.Enabled = true;
                        ResumeBtn.Enabled = true;
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error appear: {ex.Message}", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Downloader_DownloadInfoReceived(object sender, EventArgs e)
        {
            isResume = downloader.Info.AcceptRange;
            filename = downloader.Info.ServerFileName;
            filesize = downloader.Info.Length;
            filenameLbl.Text = filename;
            fileSizeLbl.Text = filesize.ToString("0.00") + " MB";
        }

        private void Downloader_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = (int)e.Progress;
            ProgressLbl.Text = $"{e.Progress.ToString("0.00")} %";
            SpeedLbl.Text = string.Format("{0} MB/s", (e.SpeedInBytes / 1024d / 1024d).ToString("0.00"));
            DownloadedLbl.Text = string.Format("{0} MB/s", (downloader.TotalBytesReceived / 1024d / 1024d).ToString("0.00"));
            StatusLbl.Text = "Downloading...";
            DownloadingLbl.Text = "Yes..";
            taskbar.ProgressState = TaskbarItemProgressState.Normal;
            taskbar.ProgressValue = e.Progress;
        }

        private void Downloader_DownloadCompleted(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                MessageBox.Show("Download Done... Reseting label values to normal...", "Downloaded Completed", MessageBoxButtons.OK);

                StatusLbl.Text = "N/A";
                DownloadedLbl.Text = "N/A";
                DownloadingLbl.Text = "N/A";
                SpeedLbl.Text = "N/A";
                progressBar.Value = 0;
                ProgressLbl.Text = "0 %";
                supportResumeLbl.Text = "N/A";
                filenameLbl.Text = "N/A";
                fileSizeLbl.Text = "N/A";
                taskbar.ProgressState = TaskbarItemProgressState.None;
                taskbar.ProgressValue = 0;
                linkToFileFolder.Visible = true;
            });
        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            if (downloader != null)
            {
                downloader.Pause();
            }
        }

        private void ResumeBtn_Click(object sender, EventArgs e)
        {
            if (downloader != null)
            {
                downloader.Resume();
            }
        }

        private void UrlDownloader_Load(object sender, EventArgs e)
        {
            linkToFileFolder.Visible = false;
        }

        private void saveFolderBtn_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            folder = folderBrowserDialog.SelectedPath;
            file = UrlBox.Text;
            savingTxtbox.Text = folder;

            outputpath = $"{folder}\\{Path.GetFileName(file)}";
        }

        private void UrlDownloader_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }

        private void linkToFileFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!String.IsNullOrEmpty(folder))
            {
                string argument = "/select, \"" + outputpath + "\"";
                Process.Start("explorer", argument);
            }
        }
    }
}
