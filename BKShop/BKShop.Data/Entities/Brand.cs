﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.Data.Entities
{
    public class Brand
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public List<Product> Products { set; get; }
    }
}