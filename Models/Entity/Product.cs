﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entity
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Descriptionn { get; set; }
        public string ImagePath { get; set; }
        public int Price { get; set; }
    }
}
