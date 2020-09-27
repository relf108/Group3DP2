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
                ListViewItem tmp = new ListViewItem(    "Name: " + orderList[i].itemName + " | " +
                                                        "Price: " + orderList[i].itemValue + " | " +
                                                        "Sale Date: " + orderList[i].saleDate);   
                //item tagged with its pk in db so that we are not releying on order box index as this will always be wrong after a remove
                tmp.Tag  = orderList[i].id;
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
            this.Close();
        }

        private void RemoveClick(object sender, EventArgs e)
        {
            //Store index to of item to be removed
            ListViewItem tmp = OrdersListBox.SelectedItem as ListViewItem;
            int removeIndex = Int32.Parse(tmp.Tag.ToString());

            //Calls into sqlite api to delete record at index
            RecordFunctions.DeleteRecord(removeIndex);

            //Re-populate the list box
            PopulateOrders();
        }

        private void EditClick(object sender, EventArgs e)
        {
            //Keep selected index for record update and to preserve the highlighted record
            int boxIndex = OrdersListBox.SelectedIndex;
            
            //Determin primary key for the item in the DB
            ListViewItem tmp = OrdersListBox.SelectedItem as ListViewItem;
            int editIndex = Int32.Parse(tmp.Tag.ToString());

            //edit the record int the DB
            RecordFunctions.EditRecord(editIndex, "Test2", 2.5, "2001-02-12");

            //Re-populate the list box
            PopulateOrders();

            //keep previous selected item highlighted
            OrdersListBox.SelectedIndex = boxIndex;
        }

        private void OrdersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
