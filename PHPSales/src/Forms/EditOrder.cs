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
    public partial class EditOrder : Form
    {
        int id;
        public EditOrder(int editIndex)
        {
            InitializeComponent();
            id = editIndex;
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            try
            {
                RecordFunctions.EditRecord(id, textBox1.Text, Math.Round(float.Parse(textBox2.Text), 2), textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Data types are incorrect");
            }
            this.Close();
        }
    }
}
