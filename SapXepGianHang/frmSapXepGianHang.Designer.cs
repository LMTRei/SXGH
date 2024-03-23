namespace SapXepGianHang
{
    partial class frmSapXepGianHang
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
            this.btnReFresh = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.lbSupport = new System.Windows.Forms.Label();
            this.tbSupport = new System.Windows.Forms.TrackBar();
            this.flpLabel = new System.Windows.Forms.FlowLayoutPanel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbSupport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReFresh
            // 
            this.btnReFresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReFresh.Enabled = false;
            this.btnReFresh.Location = new System.Drawing.Point(12, 518);
            this.btnReFresh.Name = "btnReFresh";
            this.btnReFresh.Size = new System.Drawing.Size(106, 23);
            this.btnReFresh.TabIndex = 11;
            this.btnReFresh.Text = "Làm Mới";
            this.btnReFresh.UseVisualStyleBackColor = true;
            this.btnReFresh.Click += new System.EventHandler(this.btnReFresh_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadFile.Location = new System.Drawing.Point(12, 489);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(106, 23);
            this.btnLoadFile.TabIndex = 10;
            this.btnLoadFile.Text = "Tải Dữ Liệu";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // lbSupport
            // 
            this.lbSupport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSupport.AutoSize = true;
            this.lbSupport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbSupport.Location = new System.Drawing.Point(889, 489);
            this.lbSupport.Name = "lbSupport";
            this.lbSupport.Size = new System.Drawing.Size(72, 13);
            this.lbSupport.TabIndex = 9;
            this.lbSupport.Text = "Support {0}";
            // 
            // tbSupport
            // 
            this.tbSupport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSupport.Enabled = false;
            this.tbSupport.LargeChange = 1;
            this.tbSupport.Location = new System.Drawing.Point(777, 496);
            this.tbSupport.Maximum = 9;
            this.tbSupport.Name = "tbSupport";
            this.tbSupport.Size = new System.Drawing.Size(281, 45);
            this.tbSupport.TabIndex = 8;
            this.tbSupport.Value = 1;
            this.tbSupport.Scroll += new System.EventHandler(this.tbSupport_Scroll);
            // 
            // flpLabel
            // 
            this.flpLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpLabel.AutoScroll = true;
            this.flpLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpLabel.Location = new System.Drawing.Point(12, 12);
            this.flpLabel.Name = "flpLabel";
            this.flpLabel.Size = new System.Drawing.Size(1046, 471);
            this.flpLabel.TabIndex = 7;
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbLogo.Image = global::SapXepGianHang.Properties.Resources.logoteam3;
            this.pbLogo.Location = new System.Drawing.Point(124, 489);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(52, 52);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 12;
            this.pbLogo.TabStop = false;
            this.pbLogo.Visible = false;
            // 
            // frmSapXepGianHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 553);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnReFresh);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.lbSupport);
            this.Controls.Add(this.tbSupport);
            this.Controls.Add(this.flpLabel);
            this.Name = "frmSapXepGianHang";
            this.Text = "Sắp Xếp Gian Hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSapXepGianHang_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tbSupport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnReFresh;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Label lbSupport;
        private System.Windows.Forms.TrackBar tbSupport;
        private System.Windows.Forms.FlowLayoutPanel flpLabel;
    }
}

