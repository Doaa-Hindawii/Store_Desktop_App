using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Management_System
{
    internal class Category
    {
        public string name { get; set; }
        public List<Product> CategoryProducts = new List<Product>();
        public bool checkIfProductExist(string p)
        {
            foreach (Product pr in CategoryProducts)
            {
                if (pr.name== p)
                {
                    return true;
                }
            }
            return false;
        }

        public Category(string _name)
        {
            name = _name;
        }
        public Category()
        { }

        public override string ToString()
        {
            return name;
        }
    }
}
