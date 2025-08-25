namespace DAQLKS
{
    partial class GioiThieu
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.lblMT = new System.Windows.Forms.TextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Controls.Add(this.label18);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1212, 53);
            this.panel3.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Constantia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Window;
            this.label18.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label18.ImageIndex = 0;
            this.label18.Location = new System.Drawing.Point(27, 5);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(680, 44);
            this.label18.TabIndex = 0;
            this.label18.Text = "Tập đoàn khách sạn Mường Thanh";
            // 
            // lblMT
            // 
            this.lblMT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMT.Location = new System.Drawing.Point(0, 61);
            this.lblMT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblMT.Multiline = true;
            this.lblMT.Name = "lblMT";
            this.lblMT.ReadOnly = true;
            this.lblMT.Size = new System.Drawing.Size(670, 597);
            this.lblMT.TabIndex = 18;
            this.lblMT.TextChanged += new System.EventHandler(this.lblQuyDinh_TextChanged);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.Gold;
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(694, 607);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(484, 51);
            this.btnDong.TabIndex = 21;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DAQLKS.Properties.Resources.Thiết_kế_chưa_có_tên__3_;
            this.pictureBox1.Location = new System.Drawing.Point(685, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(469, 529);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // GioiThieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 753);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMT);
            this.Controls.Add(this.panel3);
            this.Name = "GioiThieu";
            this.Text = "GioiThieu";
            this.Load += new System.EventHandler(this.GioiThieu_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox lblMT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDong;
    }
}