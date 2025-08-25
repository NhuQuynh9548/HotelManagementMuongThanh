﻿using DAQLKS.ClassLoin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAQLKS
{
    public partial class Main : Form
    {
        bool hiden = true;
        int pw;
        private string tenDangNhap = "";
        Modify modify = new Modify();
        public Main()
        {
            InitializeComponent();
            pw = panelSlider.Width;
            //panelSlider.Width = 0;
            this.tenDangNhap = Login.tenTK;
        }

        private void btnSubLogOut_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn chắc chắn muốn đăng xuất không?", "Xác Nhận Đăng Xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Login lg = new Login();
            lg.Show();
            this.Close();

        }

        private void btnSubAccount_Click(object sender, EventArgs e)
        {
            ThongTinTaiKhoan tk = new ThongTinTaiKhoan(tenDangNhap);
            tk.ShowDialog();

        }

        private void btnSDDVTT_Click_1(object sender, EventArgs e)
        {
            string squery = "Select HoTen from NhanVien where TenDangNhap = '" + tenDangNhap + "'";
            string HoTen = modify.GetID(squery);
            SuDungDichVuVaThanToan dvtt = new SuDungDichVuVaThanToan(HoTen);
            dvtt.ShowDialog();

        }

        private void btnSlider_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (hiden)
            {
                panelSlider.Width = panelSlider.Width + 10;
                if (panelSlider.Width >= pw)
                {
                    timer1.Stop();
                    hiden = false;
                    this.Refresh();
                }
            }
            else
            {
                panelSlider.Width = panelSlider.Width - 10;
                if (panelSlider.Width <= 0)
                {
                    timer1.Stop();
                    hiden = true;
                    this.Refresh();
                }
            }

        }

        private void btnDatPhong_Click_1(object sender, EventArgs e)
        {
            DatPhong dp = new DatPhong();
            dp.ShowDialog();
            this.Hide();
        }

        private void btnNhanPhong_Click_1(object sender, EventArgs e)
        {
            NhanPhong np = new NhanPhong();
            np.ShowDialog();
        }

        private void btnQuanLiPhong_Click_1(object sender, EventArgs e)
        {
            QuanLiPhong qlp = new QuanLiPhong();
            qlp.ShowDialog();
        }

        private void btnQuanLiNV_Click_1(object sender, EventArgs e)
        {
            QuanLyNhanVien qlnv = new QuanLyNhanVien();
            qlnv.ShowDialog();
        }

        private void Main_Load_1(object sender, EventArgs e)
        {
            this.btnQuanLiNV.Enabled = false;
            this.btnQuanLiPhong.Enabled = false;
            this.btnQLDichVu.Enabled = false;
            this.btnQuanLiNV.Enabled = false;
            this.btnThongKe.Enabled = false;
            string chucVu = "";
            DataTableReader reader = modify.GetDataTable("Select ChucVu From NhanVien Where TenDangNhap = '" + tenDangNhap + "' ").CreateDataReader();
            while (reader.Read())
            {
                chucVu = reader.GetString(0);
            }
            if (chucVu == "Admin")
            {
                this.btnQuanLiNV.Enabled = true;
                this.btnQuanLiPhong.Enabled = true;
                this.btnQLDichVu.Enabled = true;
                this.btnQuanLiNV.Enabled = true;
                this.btnThongKe.Enabled=true;
            }
            lblChuVu.Text = chucVu;
        }

        private void btnThongKe_Click_1(object sender, EventArgs e)
        {
            ThongKe tk = new ThongKe();
            tk.ShowDialog();
        }

       
        private void btnQLHoaDon_Click_1(object sender, EventArgs e)
        {
            QuanLyHoaDon QLHD = new QuanLyHoaDon();
            QLHD.ShowDialog();
        }

        private void btnQLDichVu_Click_1(object sender, EventArgs e)
        {
            QuanLiDichVu s = new QuanLiDichVu();
            s.ShowDialog();
        }

        private void btnQuyDinh_Click_1(object sender, EventArgs e)
        {
            QuyDinh qd = new QuyDinh();
            qd.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblChuVu_Click(object sender, EventArgs e)
        {

        }

        private void panelSlider_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSubHelp_Click(object sender, EventArgs e)
        {
            DanhGia dg = new DanhGia();
            dg.ShowDialog();
        }

        private void btnSubAbout_Click(object sender, EventArgs e)
        {
            GioiThieu gt = new GioiThieu();
            gt.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

        }
    }
}
