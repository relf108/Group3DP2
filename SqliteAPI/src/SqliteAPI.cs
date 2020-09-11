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
            //RecordFunctions.DropTable();
            using var cmd = new SQLiteCommand(Con);
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS tblRecords(id INTEGER PRIMARY KEY,
                    itemName TEXT, itemValue DOUBLE , saleDate DATE )";
            cmd.ExecuteNonQuery();
            //userRole is true for admin false for staff.
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS tblUser(id INTERGER PRIMARY KEY,
                    userName TEXT, userPassword TEXT, userRole BOOLEAN)";
        }
    }
}
