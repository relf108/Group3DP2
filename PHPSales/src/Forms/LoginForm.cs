using SqliteAPI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PHPSales.Forms
{

    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblWrongLogin.Visible = false;
            lblEmptyUsername.Visible = (tbxUsername.Text == "");
            lblEmptyPassword.Visible = (tbxPassword.Text == "");
            if (tbxUsername.Text == "" || tbxPassword.Text == "") return;

            try
            {
                bool isAdmin = UserFunctions.authUser(tbxUsername.Text.ToString(), tbxPassword.Text.ToString());
                PHPApplication.Instance.IsAdmin = isAdmin;
                this.LoadForm(new DashboardForm());
            }
            catch
            {
                lblWrongLogin.Visible = true;
            }
        }

        private void btnUserBypass_Click(object sender, EventArgs e)
        {
            PHPApplication.Instance.IsAdmin = false;
            this.LoadForm(new DashboardForm());
        }

        private void btnAdminBypass_Click(object sender, EventArgs e)
        {
            PHPApplication.Instance.IsAdmin = true;
            this.LoadForm(new DashboardForm());
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
