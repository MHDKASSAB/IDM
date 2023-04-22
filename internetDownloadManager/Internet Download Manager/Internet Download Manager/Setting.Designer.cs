namespace Internet_Download_Manager
{
    partial class Setting
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
            this.save_btn = new System.Windows.Forms.Button();
            this.browse_btn = new System.Windows.Forms.Button();
            this.path_txt = new System.Windows.Forms.TextBox();
            this.path_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(289, 49);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 29);
            this.save_btn.TabIndex = 6;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // browse_btn
            // 
            this.browse_btn.Location = new System.Drawing.Point(370, 17);
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.Size = new System.Drawing.Size(31, 26);
            this.browse_btn.TabIndex = 7;
            this.browse_btn.Text = "...";
            this.browse_btn.UseVisualStyleBackColor = true;
            this.browse_btn.Click += new System.EventHandler(this.browse_btn_Click);
            // 
            // path_txt
            // 
            this.path_txt.Location = new System.Drawing.Point(80, 17);
            this.path_txt.Name = "path_txt";
            this.path_txt.Size = new System.Drawing.Size(284, 26);
            this.path_txt.TabIndex = 5;
            // 
            // path_lbl
            // 
            this.path_lbl.AutoSize = true;
            this.path_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.path_lbl.Location = new System.Drawing.Point(28, 20);
            this.path_lbl.Name = "path_lbl";
            this.path_lbl.Size = new System.Drawing.Size(46, 20);
            this.path_lbl.TabIndex = 4;
            this.path_lbl.Text = "Path:";
            this.path_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 94);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.browse_btn);
            this.Controls.Add(this.path_txt);
            this.Controls.Add(this.path_lbl);
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button browse_btn;
        private System.Windows.Forms.TextBox path_txt;
        private System.Windows.Forms.Label path_lbl;
    }
}