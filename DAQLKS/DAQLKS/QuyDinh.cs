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
    public partial class QuyDinh : Form
    {
        public QuyDinh()
        {
            InitializeComponent();
        }

        public void inQuyDinh()
        {
            lblQuyDinh.Text =
                "1. Khách hàng xuất trình một trong các giấy tờ pháp lý thể hiện thông tin về số định danh cá nhân theo quy định của pháp luật khi làm thủ tục đăng ký nhận phòng." + "\r\n\r\n" +
                "2. Khách hàng không được mang vào khách sạn các loại vũ khí, chất phóng xạ, chất có độc tính, các chất gây cháy nổ, vật nuôi, trái cây nặng mùi và những hàng cấm khác theo quy định của pháp luật hoặc của Chính quyền địa phương.\r\n\r\n" +
                "3. Nghiêm cấm mọi hình thức cờ bạc, sử dụng ma túy trong khu vực Khách sạn. Trong trường hợp vi phạm thì Khách hàng phải hoàn toàn chịu trách nhiệm trước pháp luật Việt Nam và Khách sạn.\r\n\r\n" +
                "4. Khách hàng không được nấu ăn, không hút thuốc trong phòng ngủ và các khu vực công cộng ngoại trừ khu vực hút thuốc.\r\n\r\n" +
                "5.Thời gian nhận phòng là 14h00 chiều và thời gian trả phòng là 12h00 trưa. Nếu khách hàng nhận phòng sớm hơn hoặc trả phòng muộn hơn thời gian trên thì sẽ phải thanh toán các phụ phí tương ứng theo quy định của Khách sạn.\r\n\r\n" +
                "6. Tài sản có giá trị như đồ trang sức, tiền và các thiết bị điện tử cá nhân phải được cất giữ trong két sắt tại phòng. Khách sạn không có trách nhiệm pháp lý đối với những mất mát hay hư hại về tài sản cá nhân của Khách hàng trong trường hợp Khách hàng không thực hiện theo quy định.\r\n\r\n" +
                "7. Đảm bảo người thân đến thăm khách hàng tại khách sạn phải đăng ký tại quầy Lễ tân và tuân thủ nội quy của khách sạn.\r\n\r\n" +
                "8. Vì lý do an ninh, khách hàng không được tự ý đổi phòng hoặc di chuyển trang thiết bị, đồ đạc trong phòng sang phòng khác mà không thông báo cho quầy lễ tân.\r\n\r\n" +
                "9. Khách hàng thanh toán toàn bộ các hóa đơn và trả chìa khóa phòng cho lễ tân trước khi rời khách sạn.\r\n\r\n" +
                "10. Thực hiện các thủ tục khác theo quy định của Mường Thanh và cơ quan chức năng quản lý lưu trú tại địa phương tại từng thời điểm (nếu có).\r\n\r\n" + "\r\nChúc Quý khách một kỳ nghỉ vui vẻ!\r\n\r\n";
        }
        
        

        private void QuyDinh_Load_1(object sender, EventArgs e)
        {
            inQuyDinh();
        }

        private void btnDong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
