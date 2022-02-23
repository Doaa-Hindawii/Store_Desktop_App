using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Management_System
{
    public partial class ViewSupplies : Form
    {
        string selectedSupplierID = "none";
        string selectedCompany = "none";

        public ViewSupplies()
        {
            InitializeComponent();
        }


        // parameterized constructor
        public ViewSupplies(string selectedSupplierID, string selectedCompany)
        {
            //InitializeComponent();
            this.selectedSupplierID = selectedSupplierID;
            this.selectedCompany = selectedCompany;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            this.Hide();
            supplier.Show();
        }

        private void ViewSupplies_Load(object sender, EventArgs e)
        {
            SuppliesDataGridView.DataSource = null;
            SuppliesDataGridView.DataSource = StoreData.storeSuppliers;

        }

        private void SuppliesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
