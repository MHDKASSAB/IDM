using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internet_Download_Manager
{
    public partial class Download : Form
    {
        public Download(Main main)
        {
            InitializeComponent();
            _Main = main;
        }
        WebClient client;
        public string Url { get; set; }
        public string FileName { get; set; }
        public double FileSize { get; set; }
        public double Percentage { get; set; }
        public Main _Main;

        private void start_btn_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri(this.Url);
            FileName = System.IO.Path.GetFileName(uri.AbsolutePath);
            client.DownloadFileAsync(uri, Properties.Settings.Default.Path + "/" + FileName);
        }

        private void Download_Load(object sender, EventArgs e)
        {
            client = new WebClient();
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;
            address_txt.Text = Url;
        }
        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Database.FilesRow row = App.Database.Files.NewFilesRow();
            row.Url = Url;
            row.FileName = FileName;
            row.FileSize = (string.Format("{0:0.##} KB", FileSize / 1024));
            row.DateTime = DateTime.Now;
            App.Database.Files.AddFilesRow(row);
            App.Database.AcceptChanges();
            App.Database.WriteXml(string.Format("{0}/data.dat", Application.StartupPath));
            ListViewItem item = new ListViewItem(row.ID.ToString());
            item.SubItems.Add(row.Url);
            item.SubItems.Add(row.FileName);
            item.SubItems.Add(row.FileSize);
            item.SubItems.Add(row.DateTime.ToLongTimeString());
            _Main.listView1.Items.Add(item);
            this.Close();
        }
        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Minimum = 0;
            double recive = double.Parse(e.BytesReceived.ToString());
            FileSize = double.Parse(e.TotalBytesToReceive.ToString());
            Percentage = recive / FileSize * 100;
            status_lbl.Text = $"Downloaded{string.Format("{0:0.##}", Percentage) }";
            progressBar.Value = int.Parse(Math.Truncate(Percentage).ToString());
            progressBar.Update();
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            client.CancelAsync();
        }

        private void browse_btn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select Your Path." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    path_txt.Text = fbd.SelectedPath;
                    Properties.Settings.Default.Path = path_txt.Text;
                    Properties.Settings.Default.Save();
                }
            }
        }
    }
}
