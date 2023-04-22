using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internet_Download_Manager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this Record ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = listView1.SelectedItems.Count; i > 0; i--)
                {
                    ListViewItem item = listView1.SelectedItems[i - 1];
                    App.Database.Files.Rows[item.Index].Delete();
                    listView1.Items[item.Index].Remove();
                }
                //Save
                App.Database.AcceptChanges();
                App.Database.WriteXml(string.Format("{0}/data.dat", Application.StartupPath));

            }
        }

        private void setting_btn_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string FileName = string.Format("{0}/data.dat", Application.StartupPath);
            if (File.Exists(FileName))
                App.Database.ReadXml(FileName);
            foreach (Database.FilesRow row in App.Database.Files)
            {
                ListViewItem item = new ListViewItem(row.ID.ToString());
                item.SubItems.Add(row.Url);
                item.SubItems.Add(row.FileName);
                item.SubItems.Add(row.FileSize);
                item.SubItems.Add(row.DateTime.ToLongTimeString());
                listView1.Items.Add(item);
            }
        }

        private void addurl_btn_Click(object sender, EventArgs e)
        {
            AddUrl addUrl = new AddUrl();
            if (addUrl.ShowDialog() == DialogResult.OK)
            {
                Download download = new Download(this);
                download.Url = addUrl.Url;
                download.Show();
            }
        }

        private void settiing_btn_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.ShowDialog();
        }

        private void remove_btn_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this Record ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = listView1.SelectedItems.Count; i > 0; i--)
                {
                    ListViewItem item = listView1.SelectedItems[i - 1];
                    App.Database.Files.Rows[item.Index].Delete();
                    listView1.Items[item.Index].Remove();
                }
                //Save
                App.Database.AcceptChanges();
                App.Database.WriteXml(string.Format("{0}/data.dat", Application.StartupPath));

            }
        }
    }
}
