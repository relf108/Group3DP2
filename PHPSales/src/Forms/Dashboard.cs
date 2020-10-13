using System;
using System.Windows.Forms;

namespace PHPSales.Forms
{

    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(bool userLevel)
        {
            InitializeComponent();
            if (userLevel == true)
            {
                button3.Enabled = true;
                button4.Enabled = true;
            }
            else
            {
                button3.Enabled = false;
                button4.Enabled = false;
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            UserList UserListForm = new UserList();
            UserListForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ItemList itemListForm = new ItemList();
            itemListForm.Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            PHPApplication.instance.LoadForm(new Login());
        }

        private void exportRecords_Click(object sender, EventArgs e)
        {
            Export export = new Export();
            export.Show();
        }
    }
}
