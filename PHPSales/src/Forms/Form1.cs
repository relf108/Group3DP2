using System;
using System.Drawing;
using System.Windows.Forms;
using SqliteAPI;

namespace PHPSales {
    public partial class Form1 : Form {
        public Button button1;

        public Form1() {
            button1 = new Button();
            button1.Size = new Size(100, 40);
            button1.Location = new Point(30, 30);
            button1.Text = "Click me";
            Controls.Add(button1);
            button1.Click += button1_click;
            InitializeComponent();
        }

        private void button1_click(object sender, EventArgs e) {
            MessageBox.Show("Inserted record");
            RecordFunctions.InsertRecord(name: "testItem", value: 4, "2001-02-12");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
    }
}
