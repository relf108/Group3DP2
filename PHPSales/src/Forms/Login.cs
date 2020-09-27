using SqliteAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PHPSales.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            if (UserFunctions.authUser(UsernameTextBox.Text.ToString(), PasswordTextBox.Text.ToString()))
            {
                Form1 viewForm = new Form1();
                this.Hide();
                viewForm.Show();
            }
        }
    }
}
