namespace DAQLKS
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblChuVu = new System.Windows.Forms.Label();
            this.imageListIMG = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageListIcon = new System.Windows.Forms.ImageList(this.components);
            this.panelSlider = new System.Windows.Forms.Panel();
            this.btnSubAccount = new System.Windows.Forms.Button();
            this.btnSubLogOut = new System.Windows.Forms.Button();
            this.btnSubComment = new System.Windows.Forms.Button();
            this.btnSubAbout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSlider = new System.Windows.Forms.Button();
            this.btnQuanLiNV = new System.Windows.Forms.Button();
            this.btnQuanLiPhong = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnQuyDinh = new System.Windows.Forms.Button();
            this.btnSDDVTT = new System.Windows.Forms.Button();
            this.btnQLDichVu = new System.Windows.Forms.Button();
            this.btnQLHoaDon = new System.Windows.Forms.Button();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.btnNhanPhong = new System.Windows.Forms.Button();
            this.panelSlider.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(715, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(809, 67);
            this.label1.TabIndex = 21;
            this.label1.Tag = "";
            this.label1.Text = "Quản Lí Đặt Phòng Khách Sạn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(1514, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 106);
            this.label2.TabIndex = 22;
            this.label2.Tag = "";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblChuVu
            // 
            this.lblChuVu.AutoSize = true;
            this.lblChuVu.Location = new System.Drawing.Point(342, 68);
            this.lblChuVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChuVu.Name = "lblChuVu";
            this.lblChuVu.Size = new System.Drawing.Size(0, 16);
            this.lblChuVu.TabIndex = 34;
            this.lblChuVu.Click += new System.EventHandler(this.lblChuVu_Click);
            // 
            // imageListIMG
            // 
            this.imageListIMG.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIMG.ImageStream")));
            this.imageListIMG.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIMG.Images.SetKeyName(0, "timetable.png");
            this.imageListIMG.Images.SetKeyName(1, "key-chain.png");
            this.imageListIMG.Images.SetKeyName(2, "bill.png");
            this.imageListIMG.Images.SetKeyName(3, "analytics.png");
            this.imageListIMG.Images.SetKeyName(4, "payment.png");
            this.imageListIMG.Images.SetKeyName(5, "QLDV.png");
            this.imageListIMG.Images.SetKeyName(6, "man.png");
            this.imageListIMG.Images.SetKeyName(7, "management.png");
            this.imageListIMG.Images.SetKeyName(8, "rule.png");
            this.imageListIMG.Images.SetKeyName(9, "nv.png");
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // imageListIcon
            // 
            this.imageListIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIcon.ImageStream")));
            this.imageListIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIcon.Images.SetKeyName(0, "menu.png");
            this.imageListIcon.Images.SetKeyName(1, "user.png");
            this.imageListIcon.Images.SetKeyName(2, "logout.png");
            this.imageListIcon.Images.SetKeyName(3, "question.png");
            this.imageListIcon.Images.SetKeyName(4, "info.png");
            this.imageListIcon.Images.SetKeyName(5, "facebook.png");
            this.imageListIcon.Images.SetKeyName(6, "zalo.png");
            this.imageListIcon.Images.SetKeyName(7, "hotel.png");
            // 
            // panelSlider
            // 
            this.panelSlider.BackColor = System.Drawing.Color.Navy;
            this.panelSlider.Controls.Add(this.btnSubAccount);
            this.panelSlider.Controls.Add(this.btnSubLogOut);
            this.panelSlider.Controls.Add(this.btnSubComment);
            this.panelSlider.Controls.Add(this.btnSubAbout);
            this.panelSlider.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlider.Location = new System.Drawing.Point(81, 0);
            this.panelSlider.Margin = new System.Windows.Forms.Padding(4);
            this.panelSlider.Name = "panelSlider";
            this.panelSlider.Size = new System.Drawing.Size(240, 795);
            this.panelSlider.TabIndex = 24;
            this.panelSlider.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSlider_Paint);
            // 
            // btnSubAccount
            // 
            this.btnSubAccount.BackColor = System.Drawing.Color.Navy;
            this.btnSubAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSubAccount.FlatAppearance.BorderSize = 0;
            this.btnSubAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSubAccount.ForeColor = System.Drawing.Color.White;
            this.btnSubAccount.ImageIndex = 0;
            this.btnSubAccount.Location = new System.Drawing.Point(0, 543);
            this.btnSubAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubAccount.Name = "btnSubAccount";
            this.btnSubAccount.Size = new System.Drawing.Size(240, 63);
            this.btnSubAccount.TabIndex = 6;
            this.btnSubAccount.Text = "Acount";
            this.btnSubAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubAccount.UseVisualStyleBackColor = false;
            this.btnSubAccount.Click += new System.EventHandler(this.btnSubAccount_Click);
            // 
            // btnSubLogOut
            // 
            this.btnSubLogOut.BackColor = System.Drawing.Color.Navy;
            this.btnSubLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSubLogOut.FlatAppearance.BorderSize = 0;
            this.btnSubLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubLogOut.ForeColor = System.Drawing.Color.White;
            this.btnSubLogOut.ImageIndex = 0;
            this.btnSubLogOut.Location = new System.Drawing.Point(0, 606);
            this.btnSubLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubLogOut.Name = "btnSubLogOut";
            this.btnSubLogOut.Size = new System.Drawing.Size(240, 63);
            this.btnSubLogOut.TabIndex = 6;
            this.btnSubLogOut.Text = "Đăng Xuất";
            this.btnSubLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubLogOut.UseVisualStyleBackColor = false;
            this.btnSubLogOut.Click += new System.EventHandler(this.btnSubLogOut_Click);
            // 
            // btnSubComment
            // 
            this.btnSubComment.BackColor = System.Drawing.Color.Navy;
            this.btnSubComment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSubComment.FlatAppearance.BorderSize = 0;
            this.btnSubComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSubComment.ForeColor = System.Drawing.Color.White;
            this.btnSubComment.ImageIndex = 0;
            this.btnSubComment.Location = new System.Drawing.Point(0, 669);
            this.btnSubComment.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubComment.Name = "btnSubComment";
            this.btnSubComment.Size = new System.Drawing.Size(240, 63);
            this.btnSubComment.TabIndex = 6;
            this.btnSubComment.Text = "Đánh giá của bạn";
            this.btnSubComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubComment.UseVisualStyleBackColor = false;
            this.btnSubComment.Click += new System.EventHandler(this.btnSubHelp_Click);
            // 
            // btnSubAbout
            // 
            this.btnSubAbout.BackColor = System.Drawing.Color.Navy;
            this.btnSubAbout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSubAbout.FlatAppearance.BorderSize = 0;
            this.btnSubAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSubAbout.ForeColor = System.Drawing.Color.White;
            this.btnSubAbout.ImageIndex = 0;
            this.btnSubAbout.Location = new System.Drawing.Point(0, 732);
            this.btnSubAbout.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubAbout.Name = "btnSubAbout";
            this.btnSubAbout.Size = new System.Drawing.Size(240, 63);
            this.btnSubAbout.TabIndex = 6;
            this.btnSubAbout.Text = "Giới Thiệu";
            this.btnSubAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubAbout.UseVisualStyleBackColor = false;
            this.btnSubAbout.Click += new System.EventHandler(this.btnSubAbout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Controls.Add(this.btnAbout);
            this.panel1.Controls.Add(this.btnSlider);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(81, 795);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.DarkBlue;
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnUser.Image = global::DAQLKS.Properties.Resources.icons8_account_64;
            this.btnUser.Location = new System.Drawing.Point(0, 543);
            this.btnUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(81, 63);
            this.btnUser.TabIndex = 5;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.DarkBlue;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnLogOut.Image = global::DAQLKS.Properties.Resources.icons8_export_48;
            this.btnLogOut.Location = new System.Drawing.Point(0, 606);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(81, 63);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Navy;
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnHelp.Image = global::DAQLKS.Properties.Resources.icons8_help_50;
            this.btnHelp.Location = new System.Drawing.Point(0, 669);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(81, 63);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Navy;
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAbout.Image = global::DAQLKS.Properties.Resources.icons8_information_48;
            this.btnAbout.Location = new System.Drawing.Point(0, 732);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(81, 63);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSlider
            // 
            this.btnSlider.BackColor = System.Drawing.Color.Gold;
            this.btnSlider.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSlider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(252)))));
            this.btnSlider.ImageIndex = 0;
            this.btnSlider.ImageList = this.imageListIcon;
            this.btnSlider.Location = new System.Drawing.Point(0, 0);
            this.btnSlider.Margin = new System.Windows.Forms.Padding(4);
            this.btnSlider.Name = "btnSlider";
            this.btnSlider.Size = new System.Drawing.Size(81, 63);
            this.btnSlider.TabIndex = 0;
            this.btnSlider.UseVisualStyleBackColor = false;
            this.btnSlider.Click += new System.EventHandler(this.btnSlider_Click);
            // 
            // btnQuanLiNV
            // 
            this.btnQuanLiNV.BackColor = System.Drawing.Color.MediumPurple;
            this.btnQuanLiNV.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Italic);
            this.btnQuanLiNV.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnQuanLiNV.ImageIndex = 9;
            this.btnQuanLiNV.ImageList = this.imageListIMG;
            this.btnQuanLiNV.Location = new System.Drawing.Point(1075, 340);
            this.btnQuanLiNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuanLiNV.Name = "btnQuanLiNV";
            this.btnQuanLiNV.Size = new System.Drawing.Size(219, 405);
            this.btnQuanLiNV.TabIndex = 25;
            this.btnQuanLiNV.Text = "Quản Lí Người Dùng";
            this.btnQuanLiNV.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnQuanLiNV.UseVisualStyleBackColor = false;
            this.btnQuanLiNV.Click += new System.EventHandler(this.btnQuanLiNV_Click_1);
            // 
            // btnQuanLiPhong
            // 
            this.btnQuanLiPhong.BackColor = System.Drawing.Color.MediumPurple;
            this.btnQuanLiPhong.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Italic);
            this.btnQuanLiPhong.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnQuanLiPhong.ImageIndex = 7;
            this.btnQuanLiPhong.ImageList = this.imageListIMG;
            this.btnQuanLiPhong.Location = new System.Drawing.Point(842, 340);
            this.btnQuanLiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuanLiPhong.Name = "btnQuanLiPhong";
            this.btnQuanLiPhong.Size = new System.Drawing.Size(225, 405);
            this.btnQuanLiPhong.TabIndex = 26;
            this.btnQuanLiPhong.Text = "Quản Lí Phòng";
            this.btnQuanLiPhong.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnQuanLiPhong.UseVisualStyleBackColor = false;
            this.btnQuanLiPhong.Click += new System.EventHandler(this.btnQuanLiPhong_Click_1);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.MediumPurple;
            this.btnThongKe.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Italic);
            this.btnThongKe.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnThongKe.ImageIndex = 3;
            this.btnThongKe.ImageList = this.imageListIMG;
            this.btnThongKe.Location = new System.Drawing.Point(842, 114);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(452, 218);
            this.btnThongKe.TabIndex = 27;
            this.btnThongKe.Text = "Thống Kê Doanh Thu";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click_1);
            // 
            // btnQuyDinh
            // 
            this.btnQuyDinh.BackColor = System.Drawing.Color.MediumPurple;
            this.btnQuyDinh.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Italic);
            this.btnQuyDinh.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnQuyDinh.ImageIndex = 8;
            this.btnQuyDinh.ImageList = this.imageListIMG;
            this.btnQuyDinh.Location = new System.Drawing.Point(1318, 561);
            this.btnQuyDinh.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuyDinh.Name = "btnQuyDinh";
            this.btnQuyDinh.Size = new System.Drawing.Size(471, 183);
            this.btnQuyDinh.TabIndex = 28;
            this.btnQuyDinh.Text = "Quy Định";
            this.btnQuyDinh.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnQuyDinh.UseVisualStyleBackColor = false;
            this.btnQuyDinh.Click += new System.EventHandler(this.btnQuyDinh_Click_1);
            // 
            // btnSDDVTT
            // 
            this.btnSDDVTT.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSDDVTT.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Italic);
            this.btnSDDVTT.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSDDVTT.Image = global::DAQLKS.Properties.Resources.icons8_refund_64;
            this.btnSDDVTT.Location = new System.Drawing.Point(349, 561);
            this.btnSDDVTT.Margin = new System.Windows.Forms.Padding(4);
            this.btnSDDVTT.Name = "btnSDDVTT";
            this.btnSDDVTT.Size = new System.Drawing.Size(476, 183);
            this.btnSDDVTT.TabIndex = 29;
            this.btnSDDVTT.Text = "Sử Dụng Dịch Vụ Thanh Toán";
            this.btnSDDVTT.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSDDVTT.UseVisualStyleBackColor = false;
            this.btnSDDVTT.Click += new System.EventHandler(this.btnSDDVTT_Click_1);
            // 
            // btnQLDichVu
            // 
            this.btnQLDichVu.BackColor = System.Drawing.Color.MediumPurple;
            this.btnQLDichVu.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Italic);
            this.btnQLDichVu.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnQLDichVu.ImageKey = "QLDV.png";
            this.btnQLDichVu.ImageList = this.imageListIMG;
            this.btnQLDichVu.Location = new System.Drawing.Point(1557, 114);
            this.btnQLDichVu.Margin = new System.Windows.Forms.Padding(4);
            this.btnQLDichVu.Name = "btnQLDichVu";
            this.btnQLDichVu.Size = new System.Drawing.Size(232, 439);
            this.btnQLDichVu.TabIndex = 30;
            this.btnQLDichVu.Text = "Quản Lí Dịch Vụ";
            this.btnQLDichVu.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnQLDichVu.UseVisualStyleBackColor = false;
            this.btnQLDichVu.Click += new System.EventHandler(this.btnQLDichVu_Click_1);
            // 
            // btnQLHoaDon
            // 
            this.btnQLHoaDon.BackColor = System.Drawing.Color.MediumPurple;
            this.btnQLHoaDon.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Italic);
            this.btnQLHoaDon.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnQLHoaDon.Image = global::DAQLKS.Properties.Resources.icons8_bill_64;
            this.btnQLHoaDon.Location = new System.Drawing.Point(1322, 114);
            this.btnQLHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnQLHoaDon.Name = "btnQLHoaDon";
            this.btnQLHoaDon.Size = new System.Drawing.Size(232, 439);
            this.btnQLHoaDon.TabIndex = 31;
            this.btnQLHoaDon.Text = "Quản Lí Hóa Đơn";
            this.btnQLHoaDon.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnQLHoaDon.UseVisualStyleBackColor = false;
            this.btnQLHoaDon.Click += new System.EventHandler(this.btnQLHoaDon_Click_1);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.BackColor = System.Drawing.Color.MediumPurple;
            this.btnDatPhong.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnDatPhong.Image = global::DAQLKS.Properties.Resources.icons8_check_book_64;
            this.btnDatPhong.Location = new System.Drawing.Point(353, 114);
            this.btnDatPhong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(232, 439);
            this.btnDatPhong.TabIndex = 32;
            this.btnDatPhong.Text = "Đặt Phòng";
            this.btnDatPhong.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click_1);
            // 
            // btnNhanPhong
            // 
            this.btnNhanPhong.BackColor = System.Drawing.Color.MediumPurple;
            this.btnNhanPhong.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Italic);
            this.btnNhanPhong.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnNhanPhong.Image = global::DAQLKS.Properties.Resources.icons8_approval_64;
            this.btnNhanPhong.Location = new System.Drawing.Point(593, 114);
            this.btnNhanPhong.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhanPhong.Name = "btnNhanPhong";
            this.btnNhanPhong.Size = new System.Drawing.Size(232, 439);
            this.btnNhanPhong.TabIndex = 33;
            this.btnNhanPhong.Text = "Nhận Phòng";
            this.btnNhanPhong.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnNhanPhong.UseVisualStyleBackColor = false;
            this.btnNhanPhong.Click += new System.EventHandler(this.btnNhanPhong_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1852, 795);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblChuVu);
            this.Controls.Add(this.btnQuanLiNV);
            this.Controls.Add(this.btnQuanLiPhong);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnQuyDinh);
            this.Controls.Add(this.btnSDDVTT);
            this.Controls.Add(this.btnQLDichVu);
            this.Controls.Add(this.btnQLHoaDon);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.btnNhanPhong);
            this.Controls.Add(this.panelSlider);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load_1);
            this.panelSlider.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblChuVu;
        private System.Windows.Forms.Button btnQuanLiNV;
        private System.Windows.Forms.ImageList imageListIMG;
        private System.Windows.Forms.Button btnQuanLiPhong;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnQuyDinh;
        private System.Windows.Forms.Button btnSDDVTT;
        private System.Windows.Forms.Button btnQLDichVu;
        private System.Windows.Forms.Button btnQLHoaDon;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Button btnNhanPhong;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.ImageList imageListIcon;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Panel panelSlider;
        private System.Windows.Forms.Button btnSubAccount;
        private System.Windows.Forms.Button btnSubLogOut;
        private System.Windows.Forms.Button btnSubComment;
        private System.Windows.Forms.Button btnSubAbout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSlider;
    }
}