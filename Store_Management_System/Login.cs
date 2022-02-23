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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            //Case Empty
            if (string.IsNullOrEmpty(RoleDrop.Text))
            {
                MessageBox.Show("Please select your role!");
            }
            if (UName.Text == "" || Pwd.Text == "")
            {
                MessageBox.Show("Provide User Name and Password");
            }
            //Case valid
            else if ((RoleDrop.SelectedItem.ToString() == "Admin") && UName.Text == admin.Name && Pwd.Text == admin.Password)
            {
                StoreView store = new StoreView();
                this.Hide();
                store.Show();
            }
            else
            {
                //case any eggplant
                MessageBox.Show("Not Exist User Name or Password");
                RoleDrop.Text = null;
                UName.Text = "";
                Pwd.Text = "";
            }

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            RoleDrop.Text = null;
            UName.Text = "";
            Pwd.Text = "";
        }
    }
}
