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
    public partial class CategoryView : Form
    {
        public CategoryView()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProdsBTN_Click(object sender, EventArgs e)
        {
            ProductView product = new ProductView();
            this.Hide();
            product.Show();
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


        //Add
        private void AddBtn_Click(object sender, EventArgs e)
        {
            Store selectedStore = StoreDrop.SelectedItem as Store;
            string catname = CatNameTb.Text;
            if(selectedStore.checkIfCategoryExist(catname))
            {
                MessageBox.Show("this Category was added before");
            }
            else if (catname == "")
            {
                MessageBox.Show("not valid");
            }
            else
            {
                Category Newcategory = new Category(catname);
                selectedStore.storeCategories.Add(Newcategory);
                LoadCata(selectedStore);
            }

          
        }

        private void StoreDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StoreDrop.SelectedIndex != -1)
            {
                Store selectedstore = StoreDrop.SelectedItem as Store;
                CatTbl.DataSource = null;
                CatTbl.DataSource = selectedstore.storeCategories;
            }
                //Store selectedStore = StoreDrop.SelectedItem as Store;
                //LoadCata(selectedStore);
            }
        private void CategoryView_Load(object sender, EventArgs e)
        {
            StoreDrop.DataSource = null;
            StoreDrop.DataSource = StoreData.storeBranches;
            StoreDrop.DisplayMember = "location";
        }

       
        void LoadCata(Store selectedStore)
        {
            CatTbl.DataSource = null;
            CatTbl.DataSource = selectedStore.storeCategories;

        }

        //New
        private void NewBtn_Click(object sender, EventArgs e)
        {
            CatNameTb.Clear();
        }

        private void CatNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Store selectedStore = StoreDrop.SelectedItem as Store;
            string categoryname = CatNameTb.Text;
            Category category = new Category();
            if (selectedStore.checkIfCategoryExist(categoryname))
            {
                foreach (Category c in selectedStore.storeCategories)
                {
                    if (c.name == categoryname)
                    {
                        category = c;
                    }
                }

                selectedStore.storeCategories.Remove(category);
                LoadCata(selectedStore);
            }
            else
            {
                MessageBox.Show("not valid");

            }
            }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            //int index = SupplierDataGridView.CurrentCell.RowIndex;
            //if (StoreData.checkIfSupplierExist(supplierTxtbox.Text) || supplierTxtbox.Text == "")
            //{
            //    MessageBox.Show("not valid");
            //}
            //else
            //{
            //    StoreData.storeSuppliers[index].Name = supplierTxtbox.Text;
            //    SupplierDataGridView.DataSource = null;
            //    SupplierDataGridView.DataSource = StoreData.storeSuppliers;
            //}
            //******
            Store selectedStore = StoreDrop.SelectedItem as Store;

             int index = CatTbl.CurrentCell.RowIndex;
            //int index2 = CatTbl.CurrentRow.Index;
           // int index = CatTbl.CurrentRow.Index;
                if (selectedStore.checkIfCategoryExist(CatNameTb.Text) || CatNameTb.Text == "")
                {
                    MessageBox.Show("not valid");
                }
                else
                {
                    selectedStore.storeCategories[index].name = CatNameTb.Text;
                    CatTbl.DataSource = null;
                    CatTbl.DataSource = selectedStore.storeCategories;
                }
            //int index=StoreTbl.CurrentCell.RowIndex;
            //if (StoreDrop.SelectedIndex != -1)
            //{
            //    Store selectedstore = StoreDrop.SelectedItem as Store;
            //    CatTbl.DataSource = null;
            //    CatTbl.DataSource = selectedstore.storeCategories;

            //string categoryname = CatNameTb.Text;

            //if(selectedStore.checkIfCategoryExist(categoryname)||(categoryname == ""))
            //{
            //    MessageBox.Show("not valid");
            //}
            //else
            //{
            //    selectedStore.storeCategories[index].name = categoryname;
            //    LoadCata(selectedStore);
            //}
            //if (StoreData.checkIfSupplierExist(supplierTxtbox.Text) || supplierTxtbox.Text == "")
            //{
            //    MessageBox.Show("not valid");
            //}
            //else
            //{
            //    StoreData.storeSuppliers[index].Name = supplierTxtbox.Text;
            //    SupplierDataGridView.DataSource = null;
            //    SupplierDataGridView.DataSource = StoreData.storeSuppliers;
            //}
        }

        private void CatTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if()
            //*********note it************
            //if (StoreDrop.SelectedIndex != -1)
            //{
            //    Store selectedstore = StoreDrop.SelectedItem as Store;
            //    CatTbl.DataSource = null;
            //    CatTbl.DataSource = selectedstore.storeCategories;
            //}
                //    Category selectedCategory = CatDrop.SelectedItem as Category;
                //    ProdTbl.DataSource = null;
                //    ProdTbl.DataSource = selectedCategory.CategoryProducts;
                //if (CatDrop.SelectedIndex != -1)
                //{
                //    Category selectedCategory = CatDrop.SelectedItem as Category;
                //    ProdTbl.DataSource = null;
                //    ProdTbl.DataSource = selectedCategory.CategoryProducts;
                //}
                // }
            }

        private void BillPurBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void salesButton_Click_1(object sender, EventArgs e)
        {

        }
    }
    }

