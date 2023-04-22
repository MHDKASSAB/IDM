using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internet_Download_Manager
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void browse_btn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select Your Path." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                    path_txt.Text = fbd.SelectedPath;

            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(path_txt.Text))
            {
                Properties.Settings.Default.Path = path_txt.Text;
                Properties.Settings.Default.Save();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Select Your Path", "Setting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
