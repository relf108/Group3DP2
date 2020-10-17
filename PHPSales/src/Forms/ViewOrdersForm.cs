using System;
using System.ComponentModel;
using System.Windows.Forms;
using SqliteAPI;
using SqliteAPI.Objects;

namespace PHPSales.Forms
{

    public partial class ViewOrdersForm : Form
    {

        public ViewOrdersForm()
        {
            InitializeComponent();
            PopulateOrders();
            PopulateItems();
        }

        private void PopulateItems()
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
                tmp.Tag = itemList[i].id;
                ItemsListBox.Items.Add(tmp);
            }
        }

        private void PopulateOrders()
        {
            //Populate the orderlist with sales records in the db
            BindingList<SaleRecord> orderList = new BindingList<SaleRecord>(RecordFunctions.GetRecords());

            // Clear OrdersListBox ready for new data
            OrdersListBox.Items.Clear();

            //iterate through orderList to format and add items to list box 
            for (int i = 0; i < orderList.Count; i++)
            {
                ListViewItem tmp = new ListViewItem("Order number: " + orderList[i].orderID + " | " +
                                                        "Name: " + orderList[i].itemName + " | " +
                                                        "Price: " + orderList[i].itemValue + " | " +
                                                        "Sale Date: " + orderList[i].saleDate);
                //item tagged with its pk in db so that we are not releying on order box index as this will always be wrong after a remove
                tmp.Tag = orderList[i].id;
                OrdersListBox.Items.Add(tmp);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.LoadForm(new DashboardForm());
        }

        private void btnRemove_Click(object sender, EventArgs e)
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (OrdersListBox.SelectedIndex >= 0)
            {
                //Keep selected index for record update and to preserve the highlighted record
                int boxIndex = OrdersListBox.SelectedIndex;

                //Determin primary key for the item in the DB
                ListViewItem tmp = OrdersListBox.SelectedItem as ListViewItem;
                int editIndex = Int32.Parse(tmp.Tag.ToString());
                string editDate = RecordFunctions.getRecordByID(editIndex).saleDate;

                //edit the record int the DB
                EditOrderPopup editorder = new EditOrderPopup(editIndex,editDate);
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
