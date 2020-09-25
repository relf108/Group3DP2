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
        
        public void PopulateOrders()
        {
            //Populate the orderlist with sales records in the db
            BindingList<SaleRecord> orderList = new BindingList<SaleRecord>(RecordFunctions.GetRecords());

            // Clear OrdersListBox ready for new data
            AddOrderlistBox1.Items.Clear();

            //iterate through orderList to format and add items to list box 
            for (int i = 0; i < orderList.Count; i++)
            {
                ListViewItem tmp = new ListViewItem("Name: " + orderList[i].itemName + " | Price: " + orderList[i].itemValue
                                                    + " | Sale Date: " + orderList[i].saleDate);   
                //item tagged with its pk in db so that we are not releying on order box index as this will always be wrong after a remove
                tmp.Tag  = orderList[i].id;
                AddOrderlistBox1.Items.Add(tmp);
            }

        }
        public AddOrder()
        {
            InitializeComponent();
            PopulateOrders();
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
            PopulateOrders();
        }
        private void Button6_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
