namespace Internet_Download_Manager
{
    partial class AddUrl
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
            this.cancel_btn = new System.Windows.Forms.Button();
            this.ok_btn = new System.Windows.Forms.Button();
            this.url_txt = new System.Windows.Forms.TextBox();
            this.url_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel_btn
            // 
            this.cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_btn.Location = new System.Drawing.Point(277, 46);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(76, 34);
            this.cancel_btn.TabIndex = 5;
            this.cancel_btn.Text = "&Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // ok_btn
            // 
            this.ok_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok_btn.Location = new System.Drawing.Point(359, 14);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(41, 26);
            this.ok_btn.TabIndex = 6;
            this.ok_btn.Text = "&OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // url_txt
            // 
            this.url_txt.Location = new System.Drawing.Point(71, 14);
            this.url_txt.Name = "url_txt";
            this.url_txt.Size = new System.Drawing.Size(282, 26);
            this.url_txt.TabIndex = 4;
            // 
            // url_lbl
            // 
            this.url_lbl.AutoSize = true;
            this.url_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.url_lbl.Location = new System.Drawing.Point(28, 17);
            this.url_lbl.Name = "url_lbl";
            this.url_lbl.Size = new System.Drawing.Size(37, 20);
            this.url_lbl.TabIndex = 3;
            this.url_lbl.Text = "Url :";
            this.url_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddUrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 94);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.url_txt);
            this.Controls.Add(this.url_lbl);
            this.Name = "AddUrl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddUrl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.TextBox url_txt;
        private System.Windows.Forms.Label url_lbl;
    }
}