using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMVC_Practice.Areas.Practice_I.Models.Interface;

namespace WebMVC_Practice.Areas.Practice_I.Models
{
    public class Student : IStudent
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Birth { get; set; }
        public string Domicile { get; set; }
        public double Math { get; set; }
        public double Chemistry { get; set; }
        public double TotalMark { get => Math + Chemistry; }
    }
}
