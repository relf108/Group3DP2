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

            bool UserLvl;
            try 
            {
                UserLvl = UserFunctions.authUser(UsernameTextBox.Text.ToString(), PasswordTextBox.Text.ToString());
                Form1 viewForm = new Form1(UserLvl);
                this.Hide();
                viewForm.Show();
            }
            catch
            {
                MessageBox.Show("failed to login");
            }


        }

        private void Bypass_Click(object sender, EventArgs e)
        {
            Form1 viewForm = new Form1(false);
            this.Hide();
            viewForm.Show();
        }

        private void AdminBypass_Click(object sender, EventArgs e)
        {
            Form1 viewForm = new Form1(true);
            this.Hide();
            viewForm.Show();
        }
    }
}
