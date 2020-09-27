using System;
using System.Collections.Generic;
using System.Data.SQLite;
using SqliteAPI.Objects;

namespace SqliteAPI
{
    public class InventoryFunctions
    {
        public static void InsertItem(string name, double value)
        {
            if (getItemByName(name) == null)
            {
                using var cmd = new SQLiteCommand(SqliteAPI.Con);
                cmd.CommandText = "INSERT INTO tblInventory(itemName, itemValue) VALUES(@name,@value)";
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@value", value);
                cmd.ExecuteNonQuery();
            }
            else
            {
                throw new Exception("An exception occured: That username is already taken");
            }
            
        }

        public static void DeleteUser(string itemName)
        {
            if (getItemByName(itemName) != null)
            {
                using var cmd = new SQLiteCommand(SqliteAPI.Con);
                cmd.CommandText = "DELETE FROM tblItem WHERE itemName = " + itemName;
                cmd.ExecuteNonQuery();
            }
            throw new Exception("An exception occured: The user you're trying to delete does not exist");
        }
        
        public static void EditItem(int targetPrimaryKey, string newName, double newValue)
        {
            using var cmd = new SQLiteCommand(SqliteAPI.Con);
            cmd.CommandText = "UPDATE tblInventory SET " +
                              "itemName= '" + newName + "'" +
                              ", itemValue= '" + newValue + "'" +
                              " WHERE id=" + targetPrimaryKey;
            cmd.ExecuteNonQuery();
        }
        
        public static List<Item> listRows()
        {
            var list = new List<Item>();
            var stm = "SELECT * FROM tblInventory";
            using var readercmd = new SQLiteCommand(stm, SqliteAPI.Con);
            using var rdr = readercmd.ExecuteReader();
            while (rdr.Read())
                list.Add(new Item(rdr.GetInt32(0), rdr.GetString(1), rdr.GetDouble(2)));
            return list;
        }

        public static Item getItemByID(int primaryKey)
        {
            var stm = "SELECT * FROM tblInventory WHERE id = " + primaryKey;
            using var readercmd = new SQLiteCommand(stm, SqliteAPI.Con);
            using var rdr = readercmd.ExecuteReader();
            if (rdr.HasRows)
            {
                return new Item(rdr.GetInt32(0), rdr.GetString(1),rdr.GetDouble(2));
            }

            return null;
        }
        
        public static Item getItemByName(string itemName)
        {
            var stm = "SELECT * FROM tblInventory WHERE itemName = " + itemName;
            using var readercmd = new SQLiteCommand(stm, SqliteAPI.Con);
            using var rdr = readercmd.ExecuteReader();
            if (rdr.HasRows)
            {
                return new Item(rdr.GetInt32(0), rdr.GetString(1),rdr.GetDouble(2));
            }
            return null;
            }
        
    }
}