using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using SqliteAPI;
using SqliteAPI.Objects;

namespace PHPSales.Forms
{
    public partial class View : Form
    {

        //Populates the order list box with sales records in the db
        //SaleRecord[] orderList = RecordFunctions.GetRecords();
        BindingList<SaleRecord> orderList = new BindingList<SaleRecord>(RecordFunctions.GetRecords());
        public void PopulateOrders()
        {
            orderList = new BindingList<SaleRecord>(RecordFunctions.GetRecords());
            OrdersListBox.Items.Clear();
            for (int i = 0; i < orderList.Count; i++)
            {
                String tmp = new string("Name: " + orderList[i].itemName + " | Price: " + orderList[i].itemValue
                                        + " | Sale Date: " + orderList[i].saleDate);
                OrdersListBox.Items.Add(tmp);
            }

        }
        public View()
        {
            InitializeComponent();
            PopulateOrders();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Viewbutton1_Click(object sender, EventArgs e)
        {

        }

        private void Viewbutton3_Click(object sender, EventArgs e)
        {

        }

        private void EditClick(object sender, EventArgs e)
        {
            //Indexs in the db start at one for some reason but cbf fixing
            int editIndex = OrdersListBox.SelectedIndex + 1;
            RecordFunctions.EditRecord(editIndex, "Test", 2.5, "2001-02-12");
            PopulateOrders();
            OrdersListBox.Refresh();
        }

        private void OrdersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
