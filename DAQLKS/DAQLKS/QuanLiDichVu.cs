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
    public partial class QuanLiDichVu : Form
    {
        public QuanLiDichVu()
        {
            InitializeComponent();
        }
        String querytableDV = "select * from DichVu";
        ClassLoin.Modify modify = new ClassLoin.Modify();
        public void loadGirdView()
        {
            dataGridViewDV.ReadOnly = true;
            dataGridViewDV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDV.DataSource = modify.GetDataTable(querytableDV);

            int n = dataGridViewDV.Width / 4;
            dataGridViewDV.Columns[0].HeaderText = "Mã Dịch Vụ";
            dataGridViewDV.Columns[0].Width = n;
            dataGridViewDV.Columns[1].HeaderText = "Loại Dịch Vụ";
            dataGridViewDV.Columns[1].Width = n;
            dataGridViewDV.Columns[2].HeaderText = "Tên Dịch Vụ";
            dataGridViewDV.Columns[2].Width = n;
            dataGridViewDV.Columns[3].HeaderText = "Đơn Giá";
            dataGridViewDV.Columns[3].Width = n;
        }
      
     


        private void btnCapNhatDichVu_Click_1(object sender, EventArgs e)
        {
            //int i;
            //i = dataGridViewDV.CurrentRow.Index;
            //String query1 = "update DichVu set LoaiDichVu=N'" + txtLoaiDV.Text + "', TenDV=N'" + txtTenDV.Text + "', DonGia=N'" + txtDonGia.Text + "' where MaDV='" + txtMaDV.Text + "'";
            //modify.Command(query1);
            //loadGirdView();
            try
            {
                int i = dataGridViewDV.CurrentRow.Index;  
                String query1 = "UPDATE DichVu SET LoaiDichVu=N'" + txtLoaiDV.Text + "', TenDV=N'" + txtTenDV.Text + "', DonGia=N'" + txtDonGia.Text + "' WHERE MaDV='" + txtMaDV.Text + "'";
                modify.Command(query1);
                loadGirdView(); 
                MessageBox.Show("Cập nhật dịch vụ thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi cập nhật dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemDichVu_Click_1(object sender, EventArgs e)
        {
            //String queryThemDV;

            //try
            //{
            //    queryThemDV = "insert into DichVu values('" + txtMaDV.Text + "',+ N'" + txtLoaiDV.Text + "', N'" + txtTenDV.Text + "', '" + txtDonGia.Text + "' )";
            //    modify.Command(queryThemDV);

            //}
            //catch
            //{

            //}
            //loadGirdView();
            String queryThemDV;

            try
            {
                // Kiểm tra xem các trường có trống hay không
                if (string.IsNullOrEmpty(txtMaDV.Text) || string.IsNullOrEmpty(txtLoaiDV.Text) || string.IsNullOrEmpty(txtTenDV.Text) || string.IsNullOrEmpty(txtDonGia.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi thêm dịch vụ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Câu lệnh thêm dịch vụ
                queryThemDV = "INSERT INTO DichVu VALUES('" + txtMaDV.Text + "', N'" + txtLoaiDV.Text + "', N'" + txtTenDV.Text + "', '" + txtDonGia.Text + "')";
                modify.Command(queryThemDV);

                // Tải lại dữ liệu sau khi thêm
                loadGirdView();

                // Hiển thị thông báo thêm thành công
                MessageBox.Show("Thêm dịch vụ thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo nếu có lỗi
                MessageBox.Show("Có lỗi khi thêm dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaDichVu_Click_1(object sender, EventArgs e)
        {
            //try
            //{
            //    String query = "DELETE FROM DichVu where MaDV = '" + txtMaDV.Text + "'";
            //    modify.Command(query);
            //    loadGirdView();
            //}
            //catch { }

            try
            {
                // Kiểm tra nếu MaDV đang trống
                if (string.IsNullOrEmpty(txtMaDV.Text))
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ cần xóa.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Câu lệnh xóa dịch vụ
                String query = "DELETE FROM DichVu WHERE MaDV = '" + txtMaDV.Text + "'";
                modify.Command(query);

                // Tải lại dữ liệu sau khi xóa
                loadGirdView();

                // Hiển thị thông báo xóa thành công
                MessageBox.Show("Xóa dịch vụ thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo nếu có lỗi
                MessageBox.Show("Có lỗi khi xóa dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiemDichVu_Click_1(object sender, EventArgs e)
        {
            try
            {
                String querySearch = "select * From DichVu Where MaDV like '%" + txtSearch.Text + "%'or TenDV like '%" + txtSearch.Text + "%' ";
                dataGridViewDV.DataSource = modify.GetDataTable(querySearch);
            }
            catch { }
        }

        private void btnDong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuanLiDichVu_Load_1(object sender, EventArgs e)
        {
            loadGirdView();
        }

        private void dataGridViewDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int i;

            //i = dataGridViewDV.CurrentRow.Index;

            //txtMaDV.Text = dataGridViewDV.Rows[i].Cells[0].Value.ToString();
            //txtLoaiDV.Text = dataGridViewDV.Rows[i].Cells[1].Value.ToString();
            //txtTenDV.Text = dataGridViewDV.Rows[i].Cells[2].Value.ToString();
            //txtDonGia.Text = dataGridViewDV.Rows[i].Cells[3].Value.ToString();
            try
            {
                // Lấy hàng hiện tại đang chọn
                int i = dataGridViewDV.CurrentRow.Index;

                // Hiển thị thông tin từ DataGridView vào các TextBox
                txtMaDV.Text = dataGridViewDV.Rows[i].Cells[0].Value.ToString();
                txtLoaiDV.Text = dataGridViewDV.Rows[i].Cells[1].Value.ToString();
                txtTenDV.Text = dataGridViewDV.Rows[i].Cells[2].Value.ToString();
                txtDonGia.Text = dataGridViewDV.Rows[i].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo nếu có lỗi
                MessageBox.Show("Có lỗi khi hiển thị dữ liệu dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
