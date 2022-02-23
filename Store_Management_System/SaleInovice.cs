using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Management_System
{
    internal class SaleInvoice
    {
        public SaleInvoice(string store)
        {
            Store = store;
        }
        public string Store { get; set; }
        //public string storeName { get; set; }
        //public string categoryName { get; set; }
        //public string productName { get; set; }
        //public int quantity { get; set; }
        //public double buyingPrice { get; set; }
        //public double salePrice { get; set; }
        public string customerNme { get; set; }
        public double totalPrice { get; set; }
        
        private DateTime saleDate;
        
        private List<Product> saleProducts=new List<Product>();
        public SaleInvoice()
        {
            saleDate = DateTime.Now;
        }
        public void addSaleProduct(int Quantity,
            double Saleprice, string name)
        {
            Product p = new Product(name);
            p.quantity = Quantity;
            p.salePrice = Saleprice;
            
            saleProducts.Add(p);
        }
        public List<Product> saleProductsList()
        {
            return saleProducts;
        }

    }
}
