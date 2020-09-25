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

        public void PopulateOrders()
        {
            //Populate the orderlist with sales records in the db
            BindingList<SaleRecord> orderList = new BindingList<SaleRecord>(RecordFunctions.GetRecords());

            // Clear OrdersListBox ready for new data
            OrdersListBox.Items.Clear();

            //iterate through orderList to format and add items to list box 
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

        private void RemoveClick(object sender, EventArgs e)
        {
            //Store index to of item to be removed
            int removeIndex = OrdersListBox.SelectedIndex;

            //Calls into sqlite api to delete record at index
            RecordFunctions.DeleteRecord(removeIndex +1);

            //Re-populate the list box
            PopulateOrders();
        }

        private void EditClick(object sender, EventArgs e)
        {
            //Keep selected index for record update and to preserve the highlighted record
            int editIndex = OrdersListBox.SelectedIndex;

            //edit the record int the DB
            //Indexs in the db start at one for some reason, may fix later
            RecordFunctions.EditRecord(editIndex + 1, "Test2", 2.5, "2001-02-12");

            //Re-populate the list box
            PopulateOrders();

            //keep previous selected item highlighted
            OrdersListBox.SelectedIndex = editIndex;
        }

        private void OrdersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
