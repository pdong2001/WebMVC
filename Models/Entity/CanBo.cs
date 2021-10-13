using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CanBo
    {
        [Key]
        [DisplayName("Mã cán bộ")]
        public int ID { get; set; }
        [Required(ErrorMessage = "Tên không được để chống!")]
        [DisplayName("Họ và tên")]
        public string Name { get; set; }
        [DisplayName("Địa chỉ")]
        public string Address { get; set; }
        [DisplayName("Số điện thoại")]
        public string PhoneNumber { get; set; }

        [DisplayName("Ảnh đại diện")]
        public string ImageSrc { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "File ảnh đại diện")]
        [NotMapped]
        public IFormFile Image { get; set; }
    }
}
