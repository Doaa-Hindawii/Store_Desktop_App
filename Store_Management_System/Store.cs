using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Management_System
{
    internal class Store
    {
        public string location { get; set; }
        public List<Category> storeCategories = new List<Category>();
        public List<Receipt> Recipts = new List<Receipt>();
        public  bool checkIfCategoryExist(string cat)
        {
            foreach (Category category in storeCategories )
            {
                if (category.name == cat)
                {
                    return true;
                }
            }
            return false;
        }
        public bool check(Category c,Product p)
        {
        return  c.CategoryProducts.Contains(p);
        }
        public override string ToString()
        {
            return location;
        }
    }
}
