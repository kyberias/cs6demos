﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs6demos
{
    // Expression-bodied members
    public class Demo1
    {
        public decimal Price { get; set; }
        public decimal Tax { get; set; }

        public decimal TotalPrice => Price + Tax * Price;
    }
}
