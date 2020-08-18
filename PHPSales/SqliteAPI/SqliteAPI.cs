using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Text;

namespace PHPSales.SqliteAPI
{
    public class SqliteAPI
    {        private static readonly string cs = @"URI=file:./sales.db";
        private static readonly SQLiteConnection con = new SQLiteConnection(cs);

        public static void InitDB()
        {
            con.Open();
            using var cmd = new SQLiteCommand(con);
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS tblRecords(id INTEGER PRIMARY KEY,
                    itemName TEXT, itemValue DOUBLE , saleDate DATE )";
            cmd.ExecuteNonQuery();
        }

        public static void InsertRecord(string name, double value, string date)
        {
            using var cmd = new SQLiteCommand(con);
            cmd.CommandText = "INSERT INTO tblRecords(itemName, itemValue, saleDate) VALUES(@name,@value,@date)";
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@value", value);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.ExecuteNonQuery();
        }

        public static void DeleteRecord(int primaryKey)
        {
            using var cmd = new SQLiteCommand(con);
            cmd.CommandText = "DELETE FROM tblRecords WHERE id = " + primaryKey;
            cmd.ExecuteNonQuery();
        }

        public static void EditRecord(int targetPrimaryKey, string newName, double newValue, string newDate)
        {
            using var cmd = new SQLiteCommand(con);
            cmd.CommandText = "UPDATE tblRecords SET " +
                              "itemName= '" + newName + "'" +
                              ", itemValue= '" + newValue + "'" +
                              ", saleDate= '" + newDate + "'" +
                              " WHERE id=" + targetPrimaryKey;
            cmd.ExecuteNonQuery();
        }

        public static void PrintRows()
        {
            var stm = "SELECT * FROM tblRecords";
            using var readercmd = new SQLiteCommand(stm, con);
            using var rdr = readercmd.ExecuteReader();
            while (rdr.Read())
                Console.WriteLine($"{rdr.GetInt32(0)} {rdr.GetString(1)} {rdr.GetDouble(2)} {rdr.GetString(3)}");
        }

        public static List<SaleRecord> listRows()
        {
            var list = new List<SaleRecord>();
            var stm = "SELECT * FROM tblRecords";
            using var readercmd = new SQLiteCommand(stm, con);
            using var rdr = readercmd.ExecuteReader();
            while (rdr.Read())
                list.Add(new SaleRecord(rdr.GetInt32(0), rdr.GetString(1),
                    rdr.GetDouble(2), rdr.GetString(3)));
            return list;
        }

        public static void exportTable(string path, string filename)
        {
            var csv = new StringBuilder();
            var records = listRows();
            csv.AppendLine("id, item name, item value, sale date");
            foreach (var record in records)
                csv.AppendLine($"{record.id}, {record.itemName}, {record.itemValue}, {record.saleDate}");
            try
            {
                File.WriteAllText($"{path}\\{filename}.csv", csv.ToString());
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The path specified could not be found. Make sure your capitalisation is correct.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("You do not have sufficient permissions to write to the specified path. " +
                                  "Try using the path C:\\Users\\YourUsername\\Documents");
            }
        }

        public static void DropTable()
        {
            //would be used for db rollover if we get to that.
            using var cmd = new SQLiteCommand(con);
            cmd.CommandText = "DROP TABLE IF EXISTS tblRecords";
            cmd.ExecuteNonQuery();
        }
    }
}
