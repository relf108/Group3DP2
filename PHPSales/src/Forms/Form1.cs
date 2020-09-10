using System;
using System.Windows.Forms;
using SqliteAPI;

namespace PHPSales {

	public partial class Form1 : Form {

		public Form1() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {

			MessageBox.Show("Inserted record");
			RecordFunctions.InsertRecord(name: "testItem", value: 4, "2001-02-12");

		}

	}
}
