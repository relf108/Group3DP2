using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Text;
using PHPSales.SqliteAPI.Objects;

namespace PHPSales.SqliteAPI
{
    public class RecordFunctions
    {
        public static void InsertRecord(string name, double value, string date)
        {
            using var cmd = new SQLiteCommand(SqliteAPI.Con);
            cmd.CommandText = "INSERT INTO tblRecords(itemName, itemValue, saleDate) VALUES(@name,@value,@date)";
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@value", value);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.ExecuteNonQuery();
        }

        public static void DeleteRecord(int primaryKey)
        {
            using var cmd = new SQLiteCommand(SqliteAPI.Con);
            cmd.CommandText = "DELETE FROM tblRecords WHERE id = " + primaryKey;
            cmd.ExecuteNonQuery();
        }

        public static void EditRecord(int targetPrimaryKey, string newName, double newValue, string newDate)
        {
            using var cmd = new SQLiteCommand(SqliteAPI.Con);
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
            using var readercmd = new SQLiteCommand(stm, SqliteAPI.Con);
            using var rdr = readercmd.ExecuteReader();
            while (rdr.Read())
                Console.WriteLine($"{rdr.GetInt32(0)} {rdr.GetString(1)} {rdr.GetDouble(2)} {rdr.GetString(3)}");
        }

        public static List<SaleRecord> listRows()
        {
            var list = new List<SaleRecord>();
            var stm = "SELECT * FROM tblRecords";
            using var readercmd = new SQLiteCommand(stm, SqliteAPI.Con);
            using var rdr = readercmd.ExecuteReader();
            while (rdr.Read())
                list.Add(new SaleRecord(rdr.GetInt32(0), rdr.GetString(1),
                    rdr.GetDouble(2), rdr.GetString(3)));
            return list;
        }

        public static SaleRecord getRecordByID(int primaryKey)
        {
            var stm = "SELECT * FROM tblRecords WHERE id = " + primaryKey;
            using var readercmd = new SQLiteCommand(stm, SqliteAPI.Con);
            using var rdr = readercmd.ExecuteReader();
            return new SaleRecord(rdr.GetInt32(0), rdr.GetString(1), rdr.GetDouble(2), rdr.GetString(3));
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
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("An exception occured: The path specified could not be found. Make sure your capitalisation is correct.");
                Console.WriteLine(e.Source);
            }
            catch (UnauthorizedAccessException e)
            {
                
                Console.WriteLine("An exception occurredYou do not have sufficient permissions to write to the specified path. " +
                                  "Try using the path C:\\Users\\YourUsername\\Documents");
                Console.WriteLine(e.Source);
            }
        }

        public static void DropTable()
        {
            //would be used for db rollover if we get to that.
            using var cmd = new SQLiteCommand(SqliteAPI.Con);
            cmd.CommandText = "DROP TABLE IF EXISTS tblRecords";
            cmd.ExecuteNonQuery();
        }
    }
}