﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestaurant.Model
{
    public class Menus
    {
        public int MenusID { get; set; }
        public int GoodID { get; set; }
        public decimal Good { get; set; }
        public decimal GoodDiscount { get; set; }
        public string GoodExplation { get; set; }

    }
}
