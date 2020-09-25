using System;
using System.Windows.Forms;
using PHPSales.Forms;
using SqliteAPI;
using static SqliteAPI.SqliteAPI;
using View = PHPSales.Forms.View;

namespace PHPSales {

	static class Program {

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {

			//Example code
			InitDB();
			RecordFunctions.InsertRecord("record name", 4.7, "2343-33-55");
			RecordFunctions.PrintRows();
			RecordFunctions.exportTable(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "exporteddb");

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new AddOrder());

		}

	}

}
