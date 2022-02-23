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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void suppliersButton_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            this.Hide();
            supplier.Show();
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
            StoreView storeView = new StoreView();
            this.Hide();
            storeView.Show();
        }

        private void PurchBtn_Click(object sender, EventArgs e)
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
        private void filterStore()
        {
            List<SaleInvoice> saleInvoices = new List<SaleInvoice>();
            salesDataGridView.DataSource = null;
            foreach (SaleInvoice item in StoreData.storeInovices)
            {
                if (item.Store == StoreComboBox.Text)
                {
                    saleInvoices.Add(item);

                }
            }
            salesDataGridView.DataSource = saleInvoices;
        }
        private void StoreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterStore();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            salesDataGridView.DataSource = null;
            salesDataGridView.DataSource = StoreData.storeInovices;

            StoreComboBox.DataSource = null;
            StoreComboBox.DataSource = StoreData.storeInovices;
            StoreComboBox.DisplayMember = "store";
        }
    }
}
