namespace Internet_Download_Manager
{
    partial class Download
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
            this.browse_btn = new System.Windows.Forms.Button();
            this.start_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.status_lbl = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.path_txt = new System.Windows.Forms.TextBox();
            this.address_txt = new System.Windows.Forms.TextBox();
            this.path_lbl = new System.Windows.Forms.Label();
            this.address_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // browse_btn
            // 
            this.browse_btn.Location = new System.Drawing.Point(407, 57);
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.Size = new System.Drawing.Size(31, 26);
            this.browse_btn.TabIndex = 15;
            this.browse_btn.Text = "...";
            this.browse_btn.UseVisualStyleBackColor = true;
            this.browse_btn.Click += new System.EventHandler(this.browse_btn_Click);
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(326, 142);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(75, 28);
            this.start_btn.TabIndex = 13;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Location = new System.Drawing.Point(245, 142);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(75, 28);
            this.stop_btn.TabIndex = 14;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // status_lbl
            // 
            this.status_lbl.AutoSize = true;
            this.status_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.status_lbl.Location = new System.Drawing.Point(188, 107);
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(125, 20);
            this.status_lbl.TabIndex = 12;
            this.status_lbl.Text = "Downloaded 0%";
            this.status_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(100, 89);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(301, 15);
            this.progressBar.TabIndex = 11;
            // 
            // path_txt
            // 
            this.path_txt.Location = new System.Drawing.Point(100, 57);
            this.path_txt.Name = "path_txt";
            this.path_txt.Size = new System.Drawing.Size(301, 26);
            this.path_txt.TabIndex = 9;
            // 
            // address_txt
            // 
            this.address_txt.Location = new System.Drawing.Point(100, 24);
            this.address_txt.Name = "address_txt";
            this.address_txt.ReadOnly = true;
            this.address_txt.Size = new System.Drawing.Size(301, 26);
            this.address_txt.TabIndex = 10;
            // 
            // path_lbl
            // 
            this.path_lbl.AutoSize = true;
            this.path_lbl.Location = new System.Drawing.Point(44, 60);
            this.path_lbl.Name = "path_lbl";
            this.path_lbl.Size = new System.Drawing.Size(50, 20);
            this.path_lbl.TabIndex = 8;
            this.path_lbl.Text = "Path :";
            this.path_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // address_lbl
            // 
            this.address_lbl.AutoSize = true;
            this.address_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.address_lbl.Location = new System.Drawing.Point(18, 27);
            this.address_lbl.Name = "address_lbl";
            this.address_lbl.Size = new System.Drawing.Size(76, 20);
            this.address_lbl.TabIndex = 7;
            this.address_lbl.Text = "Address :";
            this.address_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Download
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 194);
            this.Controls.Add(this.browse_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.status_lbl);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.path_txt);
            this.Controls.Add(this.address_txt);
            this.Controls.Add(this.path_lbl);
            this.Controls.Add(this.address_lbl);
            this.Name = "Download";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Download";
            this.Load += new System.EventHandler(this.Download_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browse_btn;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Label status_lbl;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox path_txt;
        private System.Windows.Forms.TextBox address_txt;
        private System.Windows.Forms.Label path_lbl;
        private System.Windows.Forms.Label address_lbl;
    }
}