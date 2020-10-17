using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using SqliteAPI;
using SqliteAPI.Objects;


namespace PHPSales.Forms
{

    public partial class AddOrderForm : Form
    {

        public int itemQuantity = 0;
        public List<Item> curOrder = new List<Item>();

        public AddOrderForm()
        {
            InitializeComponent();
            PopulateItems();
            PopulateOrder();
        }

        //currently modifying this to be a list of items in the inventory
        public void PopulateItems()
        {
            //Populate the orderlist with sales records in the db
            BindingList<Item> itemList = new BindingList<Item>(InventoryFunctions.listRows());

            // Clear OrdersListBox ready for new data
            ItemListBox.Items.Clear();

            //iterate through orderList to format and add items to list box 
            for (int i = 0; i < itemList.Count; i++)
            {
                ListViewItem tmp = new ListViewItem("Name: " + itemList[i].name + " | Price: " + itemList[i].value);   
                //item tagged with its pk in db so that we are not releying on order box index as this will always be wrong after a remove
                tmp.Tag  = itemList[i].id.ToString();
                ItemListBox.Items.Add(tmp);
            }
        }

        public void PopulateOrder()
        {
            double total = 0;
            CurrentOrderListBox.Items.Clear();
            for (int i = 0; i < curOrder.Count; i++)
            {
                ListViewItem tmp1 = new ListViewItem("Name: " + curOrder[i].name + " | Price: " + curOrder[i].value);
                total += curOrder[i].value;
                tmp1.Tag = curOrder[i].id.ToString();
                CurrentOrderListBox.Items.Add(tmp1);
            }
            ListViewItem tmp = new ListViewItem("Total: "+total.ToString());
            CurrentOrderListBox.Items.Add(tmp);
        }

        private void AddCurOrder(object sender, EventArgs e)
        {
            if (curOrder.Count > 0)
            {
                int orderid = RecordFunctions.getOrderID() + 1;
                for (int i = 0; i < curOrder.Count; i++)
                {
                    RecordFunctions.InsertRecord(orderid,curOrder[i].name ,curOrder[i].value, DateTime.Now.ToString());
                }
                curOrder = new List<Item>();
                PopulateOrder();
            }
            else
            {
                MessageBox.Show("No item selected");
            }    
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.LoadForm(new DashboardForm());
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ItemListBox.SelectedIndex >= 0)
            {
                string tmp = (ItemListBox.SelectedItem as ListViewItem).Tag.ToString();
                int itemIndex = Int32.Parse(tmp);
                curOrder.Add(InventoryFunctions.getItemByID(itemIndex));
            }
            PopulateOrder();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (CurrentOrderListBox.SelectedIndex >= 0)
            {
                curOrder.Remove(curOrder[CurrentOrderListBox.SelectedIndex]);
                PopulateOrder();
            }
            else
            {
                MessageBox.Show("No item in current order list selected");
            }
        }

    }

}
