using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entity
{
    public class Product
    {
        public int ID { get; set; }
        [DisplayName("Tên sản phẩm")]
        public string Name { get; set; }
        [DisplayName("Mô tả sản phẩm")]
        public string Descriptionn { get; set; }
        [DisplayName("Link ảnh sản phẩm")]
        public string ImagePath { get; set; }
        [DisplayName("Giá bán")]
        public int Price { get; set; }
        [DataType(DataType.Upload)]
        [Display(Name = "File ảnh đại diện")]
        [NotMapped]
        public IFormFile Image { get; set; }
    }
}
