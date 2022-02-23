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
    public partial class BillPurch : Form
    {
        List<Receipt> Recipts = new List<Receipt>();
        double totlalprice = 0;
        public BillPurch()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            Datelb.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
            StoreComboBox.DataSource = null;
            StoreComboBox.DataSource = StoreData.storeBranches;
            StoreComboBox.DisplayMember = "location";
            CBsupplier.DataSource = StoreData.storeSuppliers;
            CBsupplier.DisplayMember = "Name";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Purchases purchases = new Purchases();
            this.Hide();
            purchases.Show();
        }

        private void StoreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Store selectedStore = StoreComboBox.SelectedItem as Store;
            categoryDrop.DataSource = null;
            categoryDrop.DataSource = selectedStore.storeCategories;
            categoryDrop.DisplayMember = "name";
        }

        private void categoryDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            Store selectedStore = StoreComboBox.SelectedItem as Store;
            //categortClass selectedCategory = CBcategoryName.SelectedItem as categortClass;
            ProductCompoBox.DataSource = null;
            foreach (Category s in selectedStore.storeCategories)
            {
                if (s.name == categoryDrop.Text)
                {
                    ProductCompoBox.DataSource = s.CategoryProducts;
                    ProductCompoBox.DisplayMember = "name";
                }
            }
        }

        private void AddToBillBtn_Click(object sender, EventArgs e)
        {
            ////Set Date
            DateTime now = DateTime.Now;
            string dateOfPurch = now.ToString("dd-MMM-yy hh:mm:ss");

            if (StoreComboBox.SelectedItem == null || categoryDrop.SelectedItem == null ||
                  ProductCompoBox == null || CBsupplier.SelectedItem == null || tbproductprice.Text == "" || PQty.Text == "")
            {
                MessageBox.Show("Please Complete The reast of Requires");
            }
            else
            {
                increaseQuantity();
                CreateBill();
            }

        }
        void increaseQuantity()
        {
            Product Prod = ProductCompoBox.SelectedItem as Product;

            Prod.quantity += int.Parse(PQty.Text);

            //The Total Price Should be deacrease.


        }
        void CreateBill()
        {


            Receipt receipt = new Receipt(StoreComboBox.SelectedItem.ToString(), categoryDrop.SelectedItem.ToString(), ProductCompoBox.SelectedItem.ToString(), CBsupplier.SelectedItem.ToString(), Convert.ToDouble(tbproductprice.Text.ToString()), Convert.ToInt32(PQty.Text.ToString()));
            Recipts.Add(receipt);

            //foreach (Receipt r in Recipts)
            //{
            //    MessageBox.Show(r.Product + r.Store);

            //}

            int quantity = int.Parse(PQty.Text);
            double price = double.Parse(tbproductprice.Text);
            totlalprice += (price * quantity);
            labelTotalPrice.Text = totlalprice.ToString();


            BillGv.DataSource = null;
            BillGv.DataSource = Recipts;


        }


        private void BuyBtn_Click(object sender, EventArgs e)
        {
            StoreData.storeReceipts.AddRange(Recipts);
            MessageBox.Show("Confirmed");
        }
      

        private void buyingPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            tbproductprice.Clear();
            PQty.Clear();
        }

        private void tbproductprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void PQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
