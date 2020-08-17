using System;
using System.Data.SQLite;

namespace PHPSales.SqliteAPI
{
    public class SqliteAPI
    {
        private static readonly string cs = "Data Source=:memory:";
        private static SQLiteConnection con = new SQLiteConnection(cs);
        private static SQLiteCommand cmd = new SQLiteCommand(con);

        public static void InitDB()
        {
            con.Open();


            cmd.CommandText = "DROP TABLE IF EXISTS tblRecords";
            cmd.ExecuteNonQuery();

            cmd.CommandText = @"CREATE TABLE tblRecords(id INTEGER PRIMARY KEY,
                    itemName TEXT, itemValue INT, saleDate DATE )";
            cmd.ExecuteNonQuery();
            
            cmd.CommandText = "INSERT INTO tblRecords(itemName, itemValue, saleDate) VALUES('name',52642, '2001-02-12')";
            cmd.ExecuteNonQuery();
            
            
        }

        public static void InsertRecord(string name, int value, string date)
        {
            cmd.CommandText = "INSERT INTO tblRecords(itemName, itemValue, saleDate) VALUES(@name,@value,@date)";
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@value", value);
            cmd.Parameters.AddWithValue("@date", date);

            cmd.ExecuteNonQuery();
        }
    }
}