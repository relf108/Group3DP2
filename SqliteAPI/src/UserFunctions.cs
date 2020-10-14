using System;
using System.Collections.Generic;
using System.Data.SQLite;
using SqliteAPI.Objects;

namespace SqliteAPI
{
    public class UserFunctions
    {
        public static void InsertUser(string name, string password,bool role)
        {
            if (getUserByUsername(name) == null)
            {
                using var cmd = new SQLiteCommand(SqliteAPI.Con);
                cmd.CommandText = "INSERT INTO tblUser(userName, userPassword ,userRole) VALUES(@name,@password,@role)";
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.ExecuteNonQuery();
            }
            else
            {
                throw new Exception("An exception occured: That username is already taken");
            }
            
        }

        public static void DeleteUser(string userName)
        {
            if (getUserByUsername(userName) != null)
            {
                using var cmd = new SQLiteCommand(SqliteAPI.Con);
                cmd.CommandText = $"DELETE FROM tblUser WHERE userName = \"{userName}\"";
                cmd.ExecuteNonQuery();
            }
            throw new Exception("An exception occured: The user you're trying to delete does not exist");
        }

        public static void DeleteUser(int id)
        {
            if (getUserByID(id) != null)
            {
                using var cmd = new SQLiteCommand(SqliteAPI.Con);
                cmd.CommandText = "DELETE FROM tblUser WHERE id = " + id.ToString();
                cmd.ExecuteNonQuery();
            }
            else
                throw new Exception("An exception occured: The user you're trying to delete does not exist");
        }

        public static void EditUser(int targetPrimaryKey, string newName,string newPass, bool newRole)
        {
            using var cmd = new SQLiteCommand(SqliteAPI.Con);
            cmd.CommandText = "UPDATE tblUser SET " +
                              "userName= '" + newName + "'" +
                              ", userPassword= '" + newPass + "'" +
                              ", userRole= '" + newRole + "'" +
                              " WHERE id=" + targetPrimaryKey;
            cmd.ExecuteNonQuery();
        }
        
        public static List<User> listRows()
        {
            var list = new List<User>();
            var stm = "SELECT * FROM tblUser";
            using var readercmd = new SQLiteCommand(stm, SqliteAPI.Con);
            using var rdr = readercmd.ExecuteReader();
            while (rdr.Read())
                list.Add(new User(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2),
                    rdr.GetBoolean(3)));
            return list;
        }

        public static User getUserByID(int primaryKey)
        {
            var stm = "SELECT * FROM tblUser WHERE id = " + primaryKey.ToString();
            using var readercmd = new SQLiteCommand(stm, SqliteAPI.Con);
            using var rdr = readercmd.ExecuteReader();
            if (rdr.HasRows)
            {
                if (rdr.Read())
                return new User(rdr.GetInt32(0), rdr.GetString(1),rdr.GetString(2), rdr.GetBoolean(3));
            }

            return null;
        }
        
        public static User getUserByUsername(string userName)
        {
            var stm = $"SELECT * FROM tblUser WHERE userName = \'{userName}\'";
            using var readercmd = new SQLiteCommand(stm, SqliteAPI.Con);
            using var rdr = readercmd.ExecuteReader();
            
            if (rdr.HasRows)
            {
                if (rdr.Read())
                    return new User(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetBoolean(3));
                else return null;
            }
            else
                return null;
        }

        public static bool authUser(string userName, string userPassword)
        {
            var temp = getUserByUsername(userName);
            if (temp != null)
            {
                if (temp.userPassword.Equals(userPassword))
                {
                    return temp.userRole;
                }
                throw new Exception("An exception occured: The user does not exist or the username and password do not match");
            }
            else
            {
                throw new Exception("An exception occured: The user does not exist or the username and password do not match");
            }
        }
    }
}