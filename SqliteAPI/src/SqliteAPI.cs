using System.Data.SQLite;

namespace SqliteAPI
{
    public class SqliteAPI
    {
        private static readonly string cs = @"URI=file:./sales.db";
        public static readonly SQLiteConnection Con = new SQLiteConnection(cs);

        public static void InitDB()
        {
            Con.Open();
            using var cmd = new SQLiteCommand(Con);
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS tblRecords(id INTEGER PRIMARY KEY AUTOINCREMENT,
                    itemName TEXT, itemValue DOUBLE , saleDate DATE );";
            cmd.ExecuteNonQuery();
            //userRole is true for admin false for staff.
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS tblUser(id INTEGER PRIMARY KEY AUTOINCREMENT,
                    userName TEXT, userPassword TEXT, userRole BOOLEAN);";
            cmd.ExecuteNonQuery();
            //inventoryTable
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS tblInventory(id INTEGER PRIMARY KEY AUTOINCREMENT,
                    itemName TEXT, itemValue DOUBLE );";
            cmd.ExecuteNonQuery();

        }
    }
}
