using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC_Practice.Areas.Practice_I.Models.Interface
{
    public interface IStudent
    {
        [Required]
        public int ID { get; set; }

        public string Name { get; set; }

        public DateTime Birth { get; set; }

        public string Domicile { get; set; }
        [DefaultValue(0)]
        public double Math { get; set; }
        [DefaultValue(0)]
        public double Chemistry { get; set; }
        [DefaultValue(0)]
        public double TotalMark { get; }
    }
}
