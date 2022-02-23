using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Management_System
{
     internal class StoreData
    {
        
        public static List<Store> storeBranches = new List<Store>();

        public static List<SupplierUser> storeSuppliers = new List<SupplierUser>();
        public static List<Customer> storeCustomers = new List<Customer>();
        public static List<Receipt> storeReceipts = new List<Receipt>();
        public static List<SaleInvoice> storeInovices = new List<SaleInvoice>();
       // public static adminClass admin1 = new adminClass() { name = "admin", pass = "admin" };




        public static bool checkIfStoreExist(string _location)
        {
            foreach (Store item in storeBranches)
            {
                if (item.location == _location)
                {
                    return true;
                }
            }
            return false;
        }
        //For Supplier
        public static bool checkIfSupplierExist(string sup)
        {
            foreach (SupplierUser suplier in storeSuppliers)
            {
                if (suplier.Name == sup)
                {
                    return true;
                }
            }
            return false;
        }
        
        //public static bool checkIfCategoryExist(string cat)
        //{
        //    foreach (Category category in  )
        //    {
        //        if (suplier.Name == sup)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        //public static bool CheckIfExist(string _company)
        //{
        //    foreach (SupplierUser item in storeSuppliers)
        //    {
        //        if (item.Company == _company)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}
    }
}
