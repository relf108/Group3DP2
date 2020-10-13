using SqliteAPI;
using System;
using System.Drawing;
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
            try
            {
                bool userLvl = UserFunctions.authUser(UsernameTextBox.Text.ToString(), PasswordTextBox.Text.ToString());
                PHPApplication.instance.LoadForm(new Dashboard(userLvl));
            }
            catch
            {
                MessageBox.Show("Failed to login!");
            }
        }

        private void Bypass_Click(object sender, EventArgs e)
        {
            PHPApplication.instance.LoadForm(new Dashboard(false));
        }

        private void AdminBypass_Click(object sender, EventArgs e)
        {
            PHPApplication.instance.LoadForm(new Dashboard(true));
        }

        private void buttonLogin_MouseEnter(object sender, EventArgs e)
        {
            buttonLogin.ForeColor = Color.White;
        }

        private void buttonLogin_MouseLeave(object sender, EventArgs e)
        {
            buttonLogin.ForeColor = Color.Black;
        }
    }

}
