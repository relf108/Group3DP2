using System;
using System.ComponentModel;
using System.Windows.Forms;
using SqliteAPI;
using SqliteAPI.Objects;


namespace PHPSales.Forms
{
    public partial class AddOrder : Form
    {
        public int orderValue = 0;
        
        
        //currently modifying this to be a list of items in the inventory
        public void PopulateItems()
        {
            //Populate the orderlist with sales records in the db
            BindingList<Item> itemList = new BindingList<Item>(InventoryFunctions.listRows());

            // Clear OrdersListBox ready for new data
            AddOrderlistBox1.Items.Clear();

            //iterate through orderList to format and add items to list box 
            for (int i = 0; i < itemList.Count; i++)
            {
                ListViewItem tmp = new ListViewItem("Name: " + itemList[i].name + " | Price: " + itemList[i].value);   
                //item tagged with its pk in db so that we are not releying on order box index as this will always be wrong after a remove
                tmp.Tag  = itemList[i].id;
                AddOrderlistBox1.Items.Add(tmp);
            }

        }
        public AddOrder()
        {
            InitializeComponent();
            PopulateItems();
        }

        private void incrementOrderValue(object sender, EventArgs e)
        {
            orderValue++;
        }

        private void decrementOrderValue(object sender, EventArgs e)
        {
            orderValue--;
        }

        private void AddItem(object sender, EventArgs e)
        {
            String name = AddOrdertextBox1.Text;
            RecordFunctions.InsertRecord(name: name, value: orderValue, "2001-02-12");
            orderValue = 0;
            PopulateItems();
        }
        private void Button6_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
