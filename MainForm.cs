using AltoHttp;
using System;
using System.IO;
using System.Windows.Forms;

namespace UrlDownloader
{
    public partial class UrlDownloader : Form
    {
        private HttpDownloader downloader;
        public UrlDownloader()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult box = MessageBox.Show("Info", "You need to select a folder where to save the file!", MessageBoxButtons.OKCancel);
                if (DialogResult.OK == box)
                {
                    folderBrowserDialog.ShowDialog();
                    string folder = folderBrowserDialog.SelectedPath;
                    string file = UrlBox.Text;

                    string outputpath = $"{folder}\\{Path.GetFileName(file)}";

                    downloader = new HttpDownloader(file, outputpath);
                    downloader.DownloadCompleted += Downloader_DownloadCompleted;
                    downloader.ProgressChanged += Downloader_ProgressChanged;
                    downloader.Start();

                }
                else
                {

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erorr", $"An erorr appear: {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Downloader_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = (int)e.Progress;
            ProgressLbl.Text = $"{e.Progress.ToString("0.00")} %";
            SpeedLbl.Text = string.Format("{0} MB/s", (e.SpeedInBytes / 1024d / 1024d).ToString("0.00"));
            DownloadedLbl.Text = string.Format("{0} MB/s", (downloader.TotalBytesReceived / 1024d / 1024d).ToString("0.00"));
            StatusLbl.Text = "Downloading...";
            DownloadingLbl.Text = "Yes..";
        }

        private void Downloader_DownloadCompleted(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                MessageBox.Show("Download", "Downloaded Completed", MessageBoxButtons.OK);

                StatusLbl.Text = "N/A";
                DownloadedLbl.Text = "N/A";
                DownloadingLbl.Text = "N/A";
                SpeedLbl.Text = "N/A";
                progressBar.Value = 0;
                ProgressLbl.Text = "0 %";
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
    }
}
