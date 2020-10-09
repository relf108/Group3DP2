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
    
        public void PopulateItems()
        {
            //Populate the orderlist with sales records in the db
            BindingList<Item> itemList = new BindingList<Item>(InventoryFunctions.listRows());

            // Clear OrdersListBox ready for new data
            ItemsListBox.Items.Clear();

            //iterate through orderList to format and add items to list box 
            for (int i = 0; i < itemList.Count; i++)
            {
                ListViewItem tmp = new ListViewItem("Name: " + itemList[i].name + " | Price: " + itemList[i].value);   
                //item tagged with its pk in db so that we are not releying on order box index as this will always be wrong after a remove
                tmp.Tag  = itemList[i].id;
                ItemsListBox.Items.Add(tmp);
            }

        }
        
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
            PopulateItems();
            
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
            if (OrdersListBox.SelectedIndex >=0)
            {
                ListViewItem tmp = OrdersListBox.SelectedItem as ListViewItem;
                int removeIndex = Int32.Parse(tmp.Tag.ToString());

                //Calls into sqlite api to delete record at index
                RecordFunctions.DeleteRecord(removeIndex);

                //Re-populate the list box
                PopulateOrders();
            }
        }

        private void EditClick(object sender, EventArgs e)
        {
            if (OrdersListBox.SelectedIndex >=0)
            {
                //Keep selected index for record update and to preserve the highlighted record
                int boxIndex = OrdersListBox.SelectedIndex;

                //Determin primary key for the item in the DB
                ListViewItem tmp = OrdersListBox.SelectedItem as ListViewItem;
                int editIndex = Int32.Parse(tmp.Tag.ToString());

                //edit the record int the DB
                EditOrder editorder = new EditOrder(editIndex);
                editorder.Show();

                //Re-populate the list box
                editorder.FormClosed += new FormClosedEventHandler(EditDone);
            }
        }
        private void EditDone(object sender, EventArgs e)
        {
            PopulateOrders();
        }

        private void OrdersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
