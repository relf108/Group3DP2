using System;
using System.Windows.Forms;

namespace PHPSales.Forms
{

    public partial class DashboardForm : Form
    {

        public DashboardForm()
        {
            InitializeComponent();
            if (!PHPApplication.Instance.IsAdmin)
            {
                btnManageUsers.Enabled = false;
                btnEditOrders.Enabled = false;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.LoadForm(new LoginForm());
        }

        private void btnExportRecords_Click(object sender, EventArgs e)
        {
            this.LoadForm(new ExportSalesForm());
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            this.LoadForm(new ViewOrdersForm());
        }

        private void btnAddOrders_Click(object sender, EventArgs e)
        {
            this.LoadForm(new AddOrderForm());
        }

        private void btnEditOrders_Click(object sender, EventArgs e)
        {
            this.LoadForm(new EditOrdersForm());
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            this.LoadForm(new ManageUsersForm());
        }

    }

}
