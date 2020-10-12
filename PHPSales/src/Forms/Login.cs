using SqliteAPI;
using System;
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
            bool userLvl;
            try
            {
                userLvl = UserFunctions.authUser(UsernameTextBox.Text.ToString(), PasswordTextBox.Text.ToString());
                Dashboard viewForm = new Dashboard(userLvl);
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
            Dashboard viewForm = new Dashboard(false);
            this.Hide();
            viewForm.Show();
        }

        private void AdminBypass_Click(object sender, EventArgs e)
        {
            Dashboard viewForm = new Dashboard(true);
            this.Hide();
            viewForm.Show();
        }

    }

}
