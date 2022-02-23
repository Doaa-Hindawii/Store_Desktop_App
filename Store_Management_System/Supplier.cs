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
    public partial class Supplier : Form
    {

        public Supplier()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewSuppliesButton_Click(object sender, EventArgs e)
        {
            ViewSupplies supplies = new ViewSupplies();
            this.Hide();
            supplies.Show();
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            ProductView product = new ProductView();
            this.Hide();
            product.Show();
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            CategoryView category = new CategoryView();
            this.Hide();
            category.Show();
        }

        private void StoreBtn_Click(object sender, EventArgs e)
        {
            StoreView store = new StoreView();
            this.Hide();
            store.Show();
        }

        private void salesButton_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            this.Hide();
            sales.Show();
        }

        private void RepPurBtn_Click(object sender, EventArgs e)
        {
            Purchases purchases = new Purchases();
            this.Hide();
            purchases.Show();
        }

        private void BillSalesBtn_Click(object sender, EventArgs e)
        {
            BillSales billSales = new BillSales();
            this.Hide();
            billSales.Show();
        }

        private void BillPurBtn_Click(object sender, EventArgs e)
        {
            BillPurch billPurch = new BillPurch();
            this.Hide();
            billPurch.Show();
        }


        //Add
        private void addSupButton_Click(object sender, EventArgs e)
        {
            

            if (StoreData.checkIfSupplierExist(supplierTxtbox.Text))
            {
                MessageBox.Show("this supplier exist before");

            }
            else if (supplierTxtbox.Text == "")
            {
                MessageBox.Show("not valid");
            }
            else
            {
               SupplierUser supp = new SupplierUser();
                supp.Name= supplierTxtbox.Text;
                StoreData.storeSuppliers.Add(supp);
                SupplierDataGridView.DataSource = null;
                SupplierDataGridView.DataSource = StoreData.storeSuppliers;

                




    }
}



        //Edit
        private void EditSupButton_Click(object sender, EventArgs e)
        {
            int index = SupplierDataGridView.CurrentCell.RowIndex;
            if (StoreData.checkIfSupplierExist(supplierTxtbox.Text) || supplierTxtbox.Text == "")
            {
                MessageBox.Show("not valid");
            }
            else
            {
                StoreData.storeSuppliers[index].Name = supplierTxtbox.Text;
                SupplierDataGridView.DataSource = null;
                SupplierDataGridView.DataSource = StoreData.storeSuppliers;
            }
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
           
            supplierTxtbox.Clear();
        }

        private void deleteSupButton_Click(object sender, EventArgs e)
        {
           
            SupplierUser supplier = new SupplierUser();
            if (StoreData.checkIfSupplierExist(supplierTxtbox.Text))
            {
                foreach (SupplierUser sup in StoreData.storeSuppliers)
                {
                    if (supplierTxtbox.Text == sup.Name)
                    {
                        supplier = sup;
                    }
                }
                StoreData.storeSuppliers.Remove(supplier);
                SupplierDataGridView.DataSource = null;
                SupplierDataGridView.DataSource = StoreData.storeSuppliers;
               

            }
            else
            {
                MessageBox.Show("not valid");
            }
        }

        private void supplierButton_Click(object sender, EventArgs e)
        {

        }

        private void SupplierDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
