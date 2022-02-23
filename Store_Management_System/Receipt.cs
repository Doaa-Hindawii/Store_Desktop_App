using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Management_System
{
    internal class Receipt
    {
        public string Suplier { set; get; }
        public string Store { get; set; }
        public string Category { set; get; }
        public string Product { set; get; }
        public int Quantity { set; get; }
        public double Price { set; get; }
        public DateTime Time { set; get; }

        static public List<Receipt> Recipts = new List<Receipt>();



        public Receipt() { }
        public Receipt(string store, string category, string product, string suplier, double price, int quantity)
        {
            Store = store;
            Category = category;
            Product = product;
            Suplier = suplier;
            Quantity = quantity;
            Price = price;
            Time = DateTime.Now;

        }
    }
}
