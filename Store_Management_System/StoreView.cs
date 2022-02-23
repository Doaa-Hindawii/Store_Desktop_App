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
    public partial class StoreView : Form
    {
        CategoryView category;
        public StoreView()
        {
            InitializeComponent();
            category = new CategoryView();
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
            if(StoreData.checkIfStoreExist(LocationTb.Text))
                {
                MessageBox.Show("this store exist before");

                }
            else if (LocationTb.Text == "")
            {
                MessageBox.Show("not valid");
            }
            else
            {
                Store store = new Store();
                store.location = LocationTb.Text;
                StoreData.storeBranches.Add(store);
                StoreTbl.DataSource = null;
                StoreTbl.DataSource = StoreData.storeBranches;

            }
            //int flag = 0;

            //if (StoreData.checkIfExist(LocationTb.Text))
            //{
            //    if (LocationTb.Text != "")
            //    {
            //        for (int i = 0; i < StoreData.storeBranches.Count; i++)
            //        {
            //            if (StoreData.checkIfExist(LocationTb.Text))
            //            {
            //                flag = 1;
            //            }
            //        }
            //        Store store = new Store();
            //        store.location = LocationTb.Text;
            //        StoreData.storeBranches.Add(store);
            //        StoreTbl.DataSource = null;
            //        StoreTbl.DataSource = StoreData.storeBranches;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Not Valid");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Location Exists before");
            //}

        }

        //New
        private void NewBtn_Click(object sender, EventArgs e)
        {
            LocationTb.Clear();
        }

        //Edit
        private void EditBtn_Click(object sender, EventArgs e)
        {
            int index=StoreTbl.CurrentCell.RowIndex;
            if(StoreData.checkIfStoreExist(LocationTb.Text)||LocationTb.Text == "")
            {
                MessageBox.Show("not valid");
            }
            else
            {
                StoreData.storeBranches[index].location = LocationTb.Text;
                StoreTbl.DataSource = null;
                StoreTbl.DataSource = StoreData.storeBranches;
            }
        }

        //Delete
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            
            Store newstore = new Store();
            if (StoreData.checkIfStoreExist(LocationTb.Text))
            {
                foreach (Store store in StoreData.storeBranches)
                {
                    if (LocationTb.Text == store.location)
                    {
                        newstore = store;
                    }
                }
                StoreData.storeBranches.Remove(newstore);
                StoreTbl.DataSource = null;
                StoreTbl.DataSource = StoreData.storeBranches;
            }
            else
            {
                MessageBox.Show("not valid");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void StoreTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}       
