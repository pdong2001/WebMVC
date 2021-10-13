using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entity
{
    public class Article
    {
        public Guid ID { get; set; }
        [DisplayName("Tiêu đề")]
        public string Title { get; set; }
        [DisplayName("Nội dung")]
        public string Content { get; set; }
        [DisplayName("Loại")]
        public ArticleType Type { get; set; }
        [DisplayName("Ngày đăng")]
        public DateTime UpTime { get; set; }
    }
}
