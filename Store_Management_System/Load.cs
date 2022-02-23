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
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }


        private void Load_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Logo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Store_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        int start = 0;

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            start += 1;
            progressBar1.Value = start;
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                Login main = new Login();
                this.Hide();
                main.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Slogan_Click(object sender, EventArgs e)
        {

        }
    }
}
    

