using System;
using System.Windows.Forms;

namespace PHPSales.Forms
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            View viewForm = new View();
            viewForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddOrder editForm = new AddOrder();
            editForm.Show();
        }
    }
}
