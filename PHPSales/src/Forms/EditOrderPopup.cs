using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SqliteAPI;
using SqliteAPI.Objects;

namespace PHPSales.Forms
{
    public partial class EditOrderPopup : Form
    {
        int id;
        public EditOrderPopup(int editIndex,string editDate)
        {
            InitializeComponent();
            populateItems();
            id = editIndex;
            textBox3.Text = editDate;
        }

        public void populateItems()
        {
            BindingList<Item> itemList = new BindingList<Item>(InventoryFunctions.listRows());
            List<string> index = new List<string>();
            for (int i=0;i<itemList.Count;i++)
            {
                index.Add(itemList[i].name);
            }
            itemComboBox.DataSource = index;
            textBox2.Text = InventoryFunctions.getItemByName(index[0]).value.ToString();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            try
            {
                RecordFunctions.EditRecord(id, itemComboBox.SelectedItem.ToString(), Math.Round(float.Parse(textBox2.Text), 2), textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Data types are incorrect");
            }
            this.Close();
        }

        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemComboBox.SelectedIndex >= 0)
            {
                textBox2.Text = InventoryFunctions.getItemByName(itemComboBox.SelectedItem.ToString()).value.ToString();
            }
        }
    }
}
