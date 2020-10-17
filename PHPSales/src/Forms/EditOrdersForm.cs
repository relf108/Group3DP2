using System;
using System.ComponentModel;
using System.Windows.Forms;
using SqliteAPI.Objects;
using SqliteAPI;

namespace PHPSales.Forms
{

    public partial class EditOrdersForm : Form
    {
    
        public EditOrdersForm()
        {
            InitializeComponent();
            PopulateItems();
        }

        public void PopulateItems()
        {
            //Populate the orderlist with sales records in the db
            BindingList<Item> itemList = new BindingList<Item>(InventoryFunctions.listRows());

            // Clear OrdersListBox ready for new data
            ItemListBox.Items.Clear();

            //iterate through orderList to format and add items to list box 
            for (int i = 0; i < itemList.Count; i++)
            {
                ListViewItem tmp = new ListViewItem("Item name: " + itemList[i].name + " | Value: " + itemList[i].value);
                //item tagged with its pk in db so that we are not releying on order box index as this will always be wrong after a remove
                tmp.Tag = itemList[i].id;
                ItemListBox.Items.Add(tmp);
            }

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.LoadForm(new DashboardForm());
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                InventoryFunctions.InsertItem(nameTextBox.Text, Math.Round(Double.Parse(valueTextBox.Text), 2));
            }
            catch
            {
                MessageBox.Show("Invalid item");
            }
            PopulateItems();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemListBox.SelectedIndex >= 0)
            {
                string temp = (ItemListBox.SelectedItem as ListViewItem).Tag.ToString();
                try
                {
                    InventoryFunctions.DeleteItem(Int32.Parse(temp));
                }
                catch
                {
                    MessageBox.Show("Can't remove the item");
                }
                PopulateItems();
            }
        }

    }

}
