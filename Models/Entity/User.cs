using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entity
{
    public class User
    {
        [Required]
        [DisplayName("Mã")]
        public Guid ID { get; set; }
        [DisplayName("Họ và tên")]
        public string Name { get; set; }
        [DisplayName("Tên tài khoản")]
        public string AccName { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("Số điện thoại")]
        public string PhoneNumber { get; set; }
        [DisplayName("Ngày sinh")]
        public DateTime DateOfBirth { get; set; }
        [DisplayName("Ngày đăng ký")]
        public DateTime RegistryDate {get; set; }
        [DisplayName("Địa chỉ thường trú")]
         public string Address { get; set; }
        [DisplayName("Nguyên quán")]
        public string Domicile { get; set; }

    }
}
