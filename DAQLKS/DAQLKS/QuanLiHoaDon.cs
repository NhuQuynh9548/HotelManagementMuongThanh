using DAQLKS.ClassLoin;
using DAQLKS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DAQLKS
{
    public partial class QuanLyHoaDon : Form
    {
        public QuanLyHoaDon()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
       
    

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void QuanLyHoaDon_Load_1(object sender, EventArgs e)
        {
            Load_Gridview();
        }
        private void Load_Gridview()
        {
            try
            {
                int n = gvHoaDon.Width / 10;
                string squery = "SELECT hd.MaHD, hd.TongTien, kh.HoTen, hd.TrangThaiTT, hd.NguoiThanhToan, hd.NgayThanhToan " +
                                "FROM HoaDon hd INNER JOIN KhachHang kh ON hd.MaKH = kh.MaKH";

                DataTable dt = modify.GetDataTable(squery);
                gvHoaDon.DataSource = dt;

                gvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gvHoaDon.ReadOnly = true;

                gvHoaDon.Columns[0].HeaderText = "MaHD";
                gvHoaDon.Columns[0].Width = n;

                gvHoaDon.Columns[1].HeaderText = "Tổng Tiền";
                gvHoaDon.Columns[1].Width = n * 2;

                gvHoaDon.Columns[2].HeaderText = "Họ Tên";
                gvHoaDon.Columns[2].Width = n * 2;

                gvHoaDon.Columns[3].HeaderText = "Trạng Thái";
                gvHoaDon.Columns[3].Width = n;

                gvHoaDon.Columns[4].HeaderText = "Người Thanh Toán";
                gvHoaDon.Columns[4].Width = n * 2;

                gvHoaDon.Columns[5].HeaderText = "Ngày Thanh toán";
                gvHoaDon.Columns[5].Width = n * 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }

        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            int n = gvHoaDon.Width / 10;
            string searchText = txtSearch.Text.Trim();

            // Nếu không có gì được nhập vào, tải lại tất cả hóa đơn
            if (string.IsNullOrEmpty(searchText))
            {
                Load_Gridview(); // Tải lại tất cả hóa đơn
                return;
            }

            string squery = "SELECT hd.MaHD, hd.TongTien, kh.HoTen, hd.TrangThaiTT, hd.NguoiThanhToan, hd.NgayThanhToan " +
                            "FROM HoaDon hd, KhachHang kh " +
                            "WHERE hd.MaKH = kh.MaKH AND (kh.HoTen LIKE N'%" + searchText + "%' OR hd.NguoiThanhToan LIKE N'%" + searchText + "%')";

            gvHoaDon.DataSource = modify.GetDataTable(squery);

            // Cập nhật lại tiêu đề cột
            gvHoaDon.Columns[0].HeaderText = "MaHD";
            gvHoaDon.Columns[0].Width = n;

            gvHoaDon.Columns[1].HeaderText = "Tổng Tiền";
            gvHoaDon.Columns[1].Width = n * 2;

            gvHoaDon.Columns[2].HeaderText = "Họ Tên";
            gvHoaDon.Columns[2].Width = n * 2;

            gvHoaDon.Columns[3].HeaderText = "Trạng Thái";
            gvHoaDon.Columns[3].Width = n;

            gvHoaDon.Columns[4].HeaderText = "Người Thanh Toán";
            gvHoaDon.Columns[4].Width = n * 2;

            gvHoaDon.Columns[5].HeaderText = "Ngày Thanh toán";
            gvHoaDon.Columns[5].Width = n * 2;
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string hoTen = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần hủy.");
                return;
            }

            // Xác nhận với người dùng
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn hủy hóa đơn của khách hàng " + hoTen + " không?",
                                                 "Xác nhận hủy",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // Sử dụng kết nối từ lớp Connection
                using (SqlConnection connection = Connection.GetSqlConnection())
                {
                    try
                    {
                        connection.Open();
                        string updateQuery = "UPDATE HoaDon SET TrangThaiTT = 'Canceled' WHERE MaKH IN (SELECT MaKH FROM KhachHang WHERE HoTen = @HoTen)";

                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@HoTen", hoTen);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Hủy hóa đơn thành công.");
                                Load_Gridview(); 
                            }
                            else
                            {
                                MessageBox.Show("Không thể hủy hóa đơn. Vui lòng kiểm tra lại.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close(); // Đảm bảo đóng kết nối
                    }
                }
            }
        }

        private void gvHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            //if (gvHoaDon.SelectedRows.Count > 0)
            //{
            //    // Lấy MaHD của hàng đã chọn
            //    string TenKH = gvHoaDon.SelectedRows[0].Cells[0].Value.ToString();
            //    txtSearch.Text = TenKH; // Hiển thị mã hóa đơn lên txtSearch
            //}
            //else
            //{
            //    txtSearch.Clear(); // Xóa nội dung nếu không có hàng nào được chọn
            //}
        }
    }
}
