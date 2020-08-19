namespace PHPSales.SqliteAPI.Objects
{
    public class User
    {
        public int id { get; }
        public string userName { get; }
        public string userPassword { get; }
        public bool userRole { get; }
        public User(int id, string userName, string userPassword, bool userRole)
        {
            this.id = id;
            this.userName = userName;
            this.userPassword = userPassword;
            this.userRole = userRole;
        }
    }
}