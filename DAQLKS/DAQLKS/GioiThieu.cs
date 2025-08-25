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
    public partial class GioiThieu : Form
    {
        public GioiThieu()
        {
            InitializeComponent();
        }

        private void lblQuyDinh_TextChanged(object sender, EventArgs e)
        {

        }
        private void inGioiThieu()
        {
            lblMT.Text =
            "CÂU CHUYỆN VỀ MƯỜNG THANH\r\n" +
                " “ Không gian thanh thản, tình cảm chân thành” " + "\r\n\r\n" +
            "Tại Mường Thanh, chúng tôi mời bạn cùng khởi hành chuyến đi tìm về không gian thanh thản chứa đựng những nét văn hóa mang đậm tinh thần bản sắc Việt, nơi con người gắn kết và thân ái gửi trao nhau tình cảm chân thành. Trải dọc khắp mọi vùng miền của đất nước Việt Nam xinh đẹp cùng các nước trong khu vực Đông Nam Á, Mường Thanh đồng hành cùng bạn ở khắp nơi, cho mọi hành trình, ở mọi giai đoạn của cuộc sống." + "\r\n\r\n" +
            "Từ khách sạn đầu tiên tọa lạc ở Điện Biên Phủ, Việt Nam, Tập đoàn Khách sạn Mường Thanh đã phát triển thành chuỗi khách sạn cao cấp đạt chuẩn quốc tế với 61 khách sạn thành viên, phủ sóng khắp các địa phương tại Việt Nam và các nước Đông Nam Á. Hệ thống khách sạn Mường Thanh với 4 phân khúc: Mường Thanh Luxury, Mường Thanh Grand, Mường Thanh Holiday và Mường Thanh hướng tới việc phục vụ đa dạng nhu cầu của mọi du khách trong nước và quốc tế. " + "\r\n\r\n" +
            "Từ thiên nhiên núi cao hoang sơ, qua đồng bằng trù phú, miền biển trải dài tiếp nối những đô thị sôi động, thành phố lớn...... hệ thống khách sạn Mường Thanh song hành và mang đến sự hài lòng, tin yêu cho du khách trong và ngoài nước.\r\n\r\nTrong hành trình phát triển với tầm nhìn chiến lược, mong muốn mang đến những sản phẩm dịch vụ chất lượng, tạo nên một thế giới dịch vụ đẳng cấp, Tập đoàn Khách sạn Mường Thanh đã mở rộng sang những lĩnh vực mới như giải trí, thể dục thể thao, vật phẩm lưu niệm... Những thương hiệu như Mường Thanh Safari Diễn Lâm (Vườn thú lớn nhất miền Bắc), VRC (Trung tâm giải trí đa chức năng), Fitness Plus (Trung tâm Finess & Yoga 5 sao), DreamKid (Khu vui chơi học tập dành cho trẻ em),... đều ghi nhận thành công và phục vụ hàng ngàn khách hàng, đáp ứng nhu cầu đa dạng cho nhiều đối tượng với phong cách dịch vụ tận tâm từ trái tim." + "\r\n\r\n" +
            "Những bước đi vững chãi và được đầu tư tâm huyết của Tập đoàn Khách sạn Mường Thanh sẽ là bước đệm quan trọng để Mường Thanh phát triển bền vững và vươn mình mạnh mẽ không chỉ phạm vi đất nước Việt Nam mà còn vươn mình ra trường quốc tế. Chặng đường dài phía trước, người Mường Thanh đồng lòng mở ra tiềm năng phát triển mới, hiện thực khát vọng trở thành thương hiệu đại diện quốc gia trong ngành lưu trú Việt Nam và ghi dấu giá trị khách sạn Việt trên bản đồ thế giới. ";

        }

        private void GioiThieu_Load(object sender, EventArgs e)
        {
            inGioiThieu();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
