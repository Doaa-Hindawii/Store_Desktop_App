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
    public partial class ProductView : Form
    {
        public ProductView()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void CatBtn_Click(object sender, EventArgs e)
        {
            CategoryView category = new CategoryView();
            this.Hide();
            category.Show();
        }

        private void SuppsBtn_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            this.Hide();
            supplier.Show();
        }

        private void StoreBtn_Click(object sender, EventArgs e)
        {
            StoreView storeView = new StoreView();
            this.Hide();
            storeView.Show();
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



        private void StoreDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            Store selectedStore = StoreDrop.SelectedItem as Store;
            CatDrop.DataSource = null;
            CatDrop.DataSource = selectedStore.storeCategories;
            CatDrop.DisplayMember = "name";
        }

        //Add
        private void AddBtn_Click(object sender, EventArgs e)
        {
           
            Store selectedStore = StoreDrop.SelectedItem as Store;
            Category selectedCategory = CatDrop.SelectedItem as Category;
           // Product p = new Product();
            string nameOfProduct = ProdName.Text;
            if(selectedCategory.checkIfProductExist(nameOfProduct))
            {
                MessageBox.Show("this product was added before");

            }
           else if ((nameOfProduct == "")|| (ProdPrice.Text == "") || (salepricetextbox.Text == ""))
            {
                MessageBox.Show("not valid");
            }
           
            else {
                Product pr = new Product(nameOfProduct);
                pr.buyingPrice = double.Parse(ProdPrice.Text);
                pr.salePrice = double.Parse(salepricetextbox.Text);
                selectedCategory.CategoryProducts.Add(pr);
                ProdTbl.DataSource = null;
                ProdTbl.DataSource = selectedCategory.CategoryProducts;
            }
 

        }
        void LoadProduct(Category selectedCategory)
        {
            ProdTbl.DataSource = null;
            ProdTbl.DataSource = selectedCategory.CategoryProducts;

        }

        //New
        private void NewBtn_Click(object sender, EventArgs e)
        {
            ProdName.Clear();
            ProdPrice.Clear();
            salepricetextbox.Clear();
        }

        private void CatDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Store selectedStore = StoreDrop.SelectedItem as Store;
            if(CatDrop.SelectedIndex!= -1)
            { 
            Category selectedCategory = CatDrop.SelectedItem as Category;
            ProdTbl.DataSource = null;
            ProdTbl.DataSource = selectedCategory.CategoryProducts;
            }
            
        }

        private void ProductView_Load(object sender, EventArgs e)
        {

            StoreDrop.DataSource = null;
            StoreDrop.DataSource = StoreData.storeBranches;
            StoreDrop.DisplayMember = "location";

            Store selectedStore = StoreDrop.SelectedItem as Store;


            CatDrop.DataSource = null;
            CatDrop.DataSource = selectedStore.storeCategories;
            CatDrop.DisplayMember = "name";
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Store selectedStore = StoreDrop.SelectedItem as Store;
            Category selectedCategory = CatDrop.SelectedItem as Category;
            string productname = ProdName.Text;
            Product newprod = new Product();
            if(selectedCategory.checkIfProductExist(productname))
            {
                foreach(Product p in selectedCategory.CategoryProducts)
                {
                    if(p.name == productname)
                    {
                        newprod = p;
                    }
                }
                //  int index = selectedCategory.CategoryProducts.IndexOf(newprod);
                selectedCategory.CategoryProducts.Remove(newprod);
                ProdTbl.DataSource = null;
                ProdTbl.DataSource = selectedCategory.CategoryProducts;



            }
        }

        private void ProdPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void salepricetextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
    }

