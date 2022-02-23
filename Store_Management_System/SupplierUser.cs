using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Management_System
{
    internal class SupplierUser
    {
        public string Name { get; set; }

       

        public SupplierUser(  string _name)
        {
            Name = _name;
          
        }
        public SupplierUser()
        {

        }
        public override string ToString()
        {
            return Name;
        }
    }
}
