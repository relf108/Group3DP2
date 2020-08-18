using System;
using System.Windows.Forms;
using static PHPSales.SqliteAPI.SqliteAPI;

namespace PHPSales
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            //Example code
            InitDB();
            InsertRecord("record name", 4.7, "2343-33-55");
            PrintRows();
            exportTable("C:\\Users\\Tristan Sutton\\Documents","exporteddb" );
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}