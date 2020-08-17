namespace PHPSales.SqliteAPI
{
    public class SqliteAPI
    {
        private static readonly string cs = @"URI=file:./test.db";
        private static readonly SQLiteConnection con = new SQLiteConnection(cs);

        public static void InitDB()
        {
            con.Open();

            using var cmd = new SQLiteCommand(con);

            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS tblRecords(id INTEGER PRIMARY KEY,
                    itemName TEXT, itemValue DOUBLE , saleDate DATE )";
            cmd.ExecuteNonQuery();
        }

        public static void InsertRecord(string name, int value, string date)
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
            var stm = "SELECT * FROM tblRecords LIMIT 5";

            using var readercmd = new SQLiteCommand(stm, con);
            using var rdr = readercmd.ExecuteReader();

            while (rdr.Read())
                Console.WriteLine($"{rdr.GetInt32(0)} {rdr.GetString(1)} {rdr.GetDouble(2)} {rdr.GetString(3)}");
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