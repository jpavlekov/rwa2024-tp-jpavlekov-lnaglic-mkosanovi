using DBLayer;
using Microsoft.Win32;
using SCVZ.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCVZ.Repositories
{
    public class UsersRepository
    {
        public static Users GetUser(string username)
        {
            string sql = $"SELECT * FROM Users WHERE username = '{username}'";
            return FetchUser(sql);
        }

        private static Users FetchUser(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Users user = null;
            if (reader.HasRows)
            {
                reader.Read();
                user = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return user;
        }

        private static Users CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id_user"].ToString());
            int id_role = int.Parse(reader["Id_role"].ToString());
            string name = reader["name"].ToString();
            string surname = reader["surname"].ToString();
            int x = int.Parse(reader["Id_city"].ToString());
            string username = reader["username"].ToString();
            string password = reader["password"].ToString();

            var user = new Users
            {
                ID_User = id,
                ID_Role = id_role,
                Name = name,
                LastName = surname,
                X = x,
                Username = username,
                Password = password
            };

            return user;
        }
    }
}
