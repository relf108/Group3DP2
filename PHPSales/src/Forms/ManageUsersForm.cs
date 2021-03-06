﻿using System;
using System.ComponentModel;
using System.Windows.Forms;
using SqliteAPI.Objects;
using SqliteAPI;

namespace PHPSales.Forms
{

    public partial class ManageUsersForm : Form
    {

        public ManageUsersForm()
        {
            InitializeComponent();
            PopulateItems();
        }

        public void PopulateItems()
        {
            //Populate the orderlist with sales records in the db
            BindingList<User> userList = new BindingList<User>(UserFunctions.listRows());

            // Clear OrdersListBox ready for new data
            UserListBox.Items.Clear();

            //iterate through orderList to format and add items to list box 
            for (int i = 0; i < userList.Count; i++)
            {
                string tempRole = userList[i].userRole ? "Yes" : "No";
                ListViewItem tmp = new ListViewItem("Username: " + userList[i].userName + " | Admin: " + tempRole);
                //item tagged with its pk in db so that we are not releying on order box index as this will always be wrong after a remove
                tmp.Tag = userList[i].id;
                UserListBox.Items.Add(tmp);
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
                UserFunctions.InsertUser(textBox1.Text, textBox2.Text, AdminCheck.Checked);
            }
            catch
            {
                MessageBox.Show("Username taken");
            }
            PopulateItems();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            //prevent user press remove while selecting nothing or trying to remove admin account
            if (UserListBox.SelectedIndex > 0) { 
                string temp = (UserListBox.SelectedItem as ListViewItem).Tag.ToString();
                try
                {
                    UserFunctions.DeleteUser(Int32.Parse(temp));
                }
                catch
                {
                    MessageBox.Show("Can't remove the user");
                }
                PopulateItems();
            }
        }

    }

}
