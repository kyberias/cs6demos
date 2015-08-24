using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs5demos
{
    public class Demo1
    {
        public decimal Price { get; set; }
        public decimal Tax { get; set; }

        public decimal TotalPrice
        {
            get
            {
                return Price + Tax * Price;
            }
        }
    }
}
