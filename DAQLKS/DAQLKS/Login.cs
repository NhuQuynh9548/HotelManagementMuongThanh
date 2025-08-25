using DAQLKS.ClassLoin;
using DAQLKS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAQLKS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        public static string tenTK = ""
; private void btnDangNhap_Click(object sender, EventArgs e)
        {
            tenTK = txtUserName.Text;
            string matKhau = txtPass.Text;
            if (tenTK.Trim() == "")
            {
                MessageBox.Show("Nhập Tài Khoản", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if (matKhau.Trim() == "")
            {
                MessageBox.Show("Nhập Mật Khẩu ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                string squery = "select * from TaiKhoan where TenDangNhap= '" + tenTK + "' and MatKhau = '" + matKhau + "'";
                if (modify.TaiKhoans(squery).Count > 0)
                {
                    
                    MessageBox.Show("Đăng nhập thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Main main = new Main();
                    main.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Sai Tài Khoản Hoặc Mật Khẩu", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            txtPass.Clear();
            txtUserName.Clear();
            txtUserName.Focus();
        }

       
        

        private void lblDangKy_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dk = new DangKy();
            dk.ShowDialog();
        }

        private void lblQuenMK_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau mk = new QuenMatKhau();
            mk.ShowDialog();
        }

        private void txtPass_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
