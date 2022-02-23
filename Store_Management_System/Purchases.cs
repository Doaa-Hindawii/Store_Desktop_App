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
    public partial class Purchases : Form
    {
        public Purchases()
        {
            InitializeComponent();
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salesButton_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            this.Hide();
            sales.Show();
        }

        private void BillPurBtn_Click(object sender, EventArgs e)
        {
            BillPurch bill = new BillPurch();
            this.Hide();
            bill.Show();
        }

        private void BillSalesBtn_Click(object sender, EventArgs e)
        {
            BillSales bill = new BillSales();
            this.Hide();
            bill.Show();
        }
        private void Purchases_Load(object sender, EventArgs e)
        {
            PurchsDataGridView.DataSource = null;
            PurchsDataGridView.DataSource = StoreData.storeReceipts;

            StoreComboBox.DataSource = null;
            StoreComboBox.DataSource = StoreData.storeReceipts;
            StoreComboBox.DisplayMember = "store";

        }

        private void filterStore()
        {
            List<Receipt> Recipts = new List<Receipt>();
            PurchsDataGridView.DataSource = null;
            foreach (Receipt item in StoreData.storeReceipts)
            {
                if (item.Store == StoreComboBox.Text)
                {
                    Recipts.Add(item);
                   
                }
            }
            PurchsDataGridView.DataSource = Recipts;
        }
        private void filterByMonth()
        {
           // getting the month
           DateTime selectedMonth = DateTime.Parse(monthCalendar.SelectionRange.Start.ToString("dd-MMM-yy hh:mm:ss"));
           string Trimmedmonth = selectedMonth.ToString("MMM-yy");

            // displaying in data grid view
            PurchsDataGridView.DataSource = null;
            PurchsDataGridView.DataSource = StoreData.storeReceipts;
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            filterByMonth();
        }


        private void StoreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterStore();
        }

        private void PurchsTap_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PurchsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}