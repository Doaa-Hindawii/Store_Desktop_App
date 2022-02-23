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
    public partial class BillSales : Form
    {
       
        SaleInvoice saleInvoice = null;// new SaleInvoice();
        double totalPrice, SaleInvoiceprice, flag = 0;//flag to know if any prosucts added to the bill
        
        public BillSales()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            saleInvoice = new SaleInvoice();
            Datelb.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
            StoreComboBox.DataSource = null;
            StoreComboBox.DataSource = StoreData.storeBranches;
            StoreComboBox.DisplayMember = "location";
            CBcustomers.DataSource = StoreData.storeCustomers;
            CBcustomers.DisplayMember = "Name";
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            this.Hide();
            sales.Show();
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
            if (ProductCompoBox.SelectedItem == null || PQty.Text == ""
                || txtSalePrice.Text==""|| ProductCompoBox.Text=="")
            {
                MessageBox.Show("invalid inputs");
            }
            else
            {

                //int Quantity, double Buyingprice, double Saleprice, string name
                Product selectedproduct = ProductCompoBox.SelectedItem as Product;
                
                if (selectedproduct.quantity < int.Parse(PQty.Text))
                {
                    MessageBox.Show("this quantity is not avalable");
                }
                else if (selectedproduct.quantity == 0)
                {
                    MessageBox.Show("No products avalable");
                }
                else
                {
                    saleInvoice.Store = StoreComboBox.Text;
                    saleInvoice.addSaleProduct(int.Parse(PQty.Text),
                        double.Parse(txtSalePrice.Text), ProductCompoBox.Text);
                    List<Product> products = saleInvoice.saleProductsList();
                    BillGv.DataSource = null;
                    BillGv.DataSource = products;

                    foreach (Product product in products)
                    {
                        totalPrice += product.salePrice *int.Parse(PQty.Text);

                    }
                    flag = 1;
                    labelTotalPrice.Text = totalPrice.ToString();
                    SaleInvoiceprice = totalPrice;
                    totalPrice = 0;
                    selectedproduct.quantity -= int.Parse(PQty.Text);
                }
            }
        
           

            

        }

        private void SaleBtn_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                MessageBox.Show("invalid inputs");
            }
            else 
            {
                if (string.IsNullOrEmpty(CBcustomers.Text))
                {
                    MessageBox.Show("Please select your customer!");
                }
                else
                {
                    saleInvoice.customerNme = CBcustomers.SelectedItem.ToString();
                    saleInvoice.totalPrice = SaleInvoiceprice;

                    //////////////
                    StoreData.storeInovices.Add(saleInvoice);
                    MessageBox.Show("Done Successfully");
                    saleInvoice = new SaleInvoice();
                    flag = 0;
                    labelTotalPrice.Text = "";
                    //Datelb.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
                    txtSalePrice.Text = "";
                    PQty.Text = "";
                    BillGv.DataSource = null;
                }
            }
            
        }

        private void btnNewBill_Click(object sender, EventArgs e)
        {
            
        }

        private void CBcustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tbCustomer_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ProductCompoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            //foreach(Product product in  currentSelectedproducts)
            //{
            //    if(product != null)
            //    {
            //        if(ProductCompoBox.Text == product.name)
            //        {
            //            lablebuyprice.Text = product.salePrice.ToString();
            //        }
            //    }
            //}
           
            
                //Product selectedproduct = ProductCompoBox.SelectedItem as Product
                //lablebuyprice.Text = selectedproduct.salePrice.ToString();

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }


        private void CustomerAddBtn_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.name = tbCustomer.Text;
            StoreData.storeCustomers.Add(customer);
            tbCustomer.Clear();
            CBcustomers.DataSource = null;
            CBcustomers.DataSource = StoreData.storeCustomers;
            CBcustomers.DisplayMember = "Name";
        }

        private void lablebuyprice_Click(object sender, EventArgs e)
        {

        }

        private void txtSalePrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSalePrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
