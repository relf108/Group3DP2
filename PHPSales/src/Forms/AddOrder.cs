using System;
using System.ComponentModel;
using System.Windows.Forms;
using SqliteAPI;
using SqliteAPI.Objects;


namespace PHPSales.Forms
{
    public partial class AddOrder : Form
    {
        public int itemQuantity = 0;
        
        
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
                tmp.Tag  = itemList[i].id.ToString();
                AddOrderlistBox1.Items.Add(tmp);
            }

        }
        public AddOrder()
        {
            InitializeComponent();
            PopulateItems();
        }

        private void AddItem(object sender, EventArgs e)
        {
            ListViewItem tmp = AddOrderlistBox1.SelectedItem as ListViewItem;
            int itemIndex = Int32.Parse(tmp.Tag.ToString());
            
            RecordFunctions.InsertRecord(name: InventoryFunctions.getItemByID(itemIndex).name, value: InventoryFunctions.getItemByID(itemIndex).value, "2001-02-12");
            itemQuantity = 0;
            PopulateItems();
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
