using System;
using System.Windows.Forms;


namespace PHPSales.Forms
{
    public partial class AddOrder : Form
    {
        public int orderValue = 0;
        public AddOrder()
        {
            InitializeComponent();
        }

        private void incrementOrderValue(object sender, EventArgs e)
        {
            orderValue++;
        }

        private void decrementOrderValue(object sender, EventArgs e)
        {
            orderValue--;
        }

        private void AddItem(object sender, EventArgs e)
        {
            String name = AddOrdertextBox1.Text;
            int value = 
            RecordFunctions.InsertRecord(name: name, value: orderValue, "2001-02-12");
            orderValue = 0;
        }
        private void Button6_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
