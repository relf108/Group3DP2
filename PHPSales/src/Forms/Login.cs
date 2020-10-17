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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblWrongLogin.Visible = false;
            lblEmptyUsername.Visible = false;
            lblEmptyPassword.Visible = false;

            if (tbxUsername.Text == "" || tbxPassword.Text == "")
            {
                lblEmptyUsername.Visible = (tbxUsername.Text == "");
                lblEmptyPassword.Visible = (tbxPassword.Text == "");
                return;
            } 

            try
            {
                bool userLvl = UserFunctions.authUser(tbxUsername.Text.ToString(), tbxPassword.Text.ToString());
                PHPApplication.instance.LoadForm(new Dashboard(userLvl));
            }
            catch
            {
                lblWrongLogin.Visible = true;
                //MessageBox.Show("Failed to login!");
            }
        }

        private void btnUserBypass_Click(object sender, EventArgs e)
        {
            PHPApplication.instance.LoadForm(new Dashboard(false));
        }

        private void btnAdminBypass_Click(object sender, EventArgs e)
        {
            PHPApplication.instance.LoadForm(new Dashboard(true));
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.White;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.Black;
        }
    }

}
