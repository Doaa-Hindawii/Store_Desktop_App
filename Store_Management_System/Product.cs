using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Management_System
{
    internal class Product
    {
        public int quantity { get; set; }
        public double buyingPrice { get; set; }
        public double salePrice { get; set; }
        public string name { get; set; }
        public Product() { }
        public Product(string _name)
        {
            name = _name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
