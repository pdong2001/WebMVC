using Microsoft.AspNetCore.Mvc;
using Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC_Practice.Areas.Practice_II.Controllers
{
    [Area("Practice_II")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail()
        {
            var art = new Article
            {
                Title = "TRƯỜNG ĐẠI HỌC SPKT HƯNG YÊN TỔ CHỨC HỘI NGHỊ TRIỂN KHAI HỌC TẬP NGHỊ QUYẾT ĐẠI HỘI ĐẠI BIỂU TOÀN QUỐC LẦN THỨ XIII CỦA ĐẢNG",
                UpTime = DateTime.Now,
                ID = Guid.NewGuid(),
                Content = "Trong 2 ngày (26-27/6/2021), Ban Thường vụ Đảng ủy trường Đại học SPKT Hưng Yên tổ chức Hội nghị triển khai học tập Nghị quyết Đại hội XIII của Đảng theo hình thức trực tuyến cho 319 cán bộ Đảng viên là báo cáo viên, cán bộ, giảng viên của Nhà trường\n\r\n\r Phát biểu khai mạc Hội nghị," +
                    "PGS.TS.Bùi Trung Thành – Phó Bí thư Đảng ủy,Hiệu trưởng nhà trường nhấn mạnh “Việc tổ chức nghiên cứu,học tập,quán triệt Nghị quyết Đại hội đại biểu toàn quốc lần thứ XIII" +
                    "của Đảng là đợt sinh hoạt chính trị có ý nghĩa hết sức quan trọng về mặt nhận thức,nhằm giúp cán bộ,đảng viên nắm vững nội dung cốt lõi,những điểm mới trong các văn kiện," +
                    "nhất là nhận thức mới,tư duy mới của Đảng ta về quốc phòng - an ninh, bảo vệ Tổ quốc trong tình hình hiện nay.Từ đó, thống nhất về ý chí và hành động trong quá trình triển khai thực hiện," +
                    "liên hệ với chức trách, nhiệm vụ," +
                    "tạo sự chuyển biến rõ rệt về nhận thức, tích cực bảo vệ nền tảng tư tưởng của Đảng, đấu tranh phản bác các quan điểm sai trái, " +
                    "thù địch”.\n\r\n\r\n\r PGS.TS.Bùi Trung Thành – Phó Bí thư Đảng ủy, Hiệu trưởng nhà trường phát biểu khai mạc Hội nghị.\n\r Các đại biểu đã trực tiếp nghiên cứu nội dung chuyên đề: “Những nội dung cốt lõi – Những vấn đề mới trong các văn kiện Đại hội lần thứ XIII của Đảng” do báo cáo viên GVC.TS Nguyễn Trường Cảnh – Ủy viên" +
                    "Ban Thường vụ Đảng ủy - Chủ nhiệm UBKT Đảng ủy – Trưởng khoa Lý luận chính trị trình bày.\n\r\n\r\n\r Với tinh thần nghiêm túc, trách nhiệm, các đồng chí báo cáo viên, cán bộ, giảng viên toàn Trường đã tập trung theo dõi, lĩnh hội những nội dung chủ yếu: Báo cáo của Ban Chấp hành Trung ương Đảng về các" +
                    "văn kiện trình Đại hội XIII của Đảng; Báo cáo chính trị của Ban Chấp hành Trung ương Đảng khóa XII tại Đại hội đại biểu toàn quốc lần thứ XIII của Đảng; Nghị quyết Đại hội lần thứ XIII của Đảng; Chiến lược phát" +
                    "triển kinh tế -xã hội 10 năm 2021 - 2030 và Kế hoạch phát triển kinh tế - xã hội 5 năm 2021 - 2025; Báo cáo của Ban Chấp hành Trung ương Đảng khóa XII về tổng kết công tác xây dựng Đảng và thi hành Điều lệ" +
                    "Đảng.\n\r Kết quả của Hội nghị là cơ sở để cấp ủy các cấp tiếp tục lãnh đạo, chỉ đạo chặt chẽ việc nghiên cứu, học tập, quán triệt và triển khai thực hiện Nghị quyết đến 100 % cán bộ, đảng viên và quần chúng trong" +
                    "đơn vị; Xây dựng chương trình, kế hoạch thực hiện Nghị quyết sát với thực tiễn nhiệm vụ của từng đơn vị.Các phòng, khoa, các cán bộ, giảng viên tiếp tục nghiên cứu những nội dung mới của Nghị quyết để sớm đưa" +
                    "ra các giải pháp cụ thể, triển khai phù hợp với thực tiễn hoạt động của nhà trường."
            };
            return View(art);
        }
    }
}
