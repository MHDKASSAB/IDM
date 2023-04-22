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
    public partial class AddUrl : Form
    {
        public AddUrl()
        {
            InitializeComponent();
        }
        public string Url { get; set; }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            this.Url = url_txt.Text;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
