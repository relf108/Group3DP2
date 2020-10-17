using System;
using System.Windows.Forms;

namespace PHPSales.Forms
{

    public partial class ExportSalesForm : Form
    {

        //TODO
        public ExportSalesForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.LoadForm(new DashboardForm());
        }

        private void btnExportWeekly_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnExportMonthly_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnExportAll_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        
        private void btnExportPredicted_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

    }

}