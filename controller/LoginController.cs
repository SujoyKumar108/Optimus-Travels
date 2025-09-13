using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Optimus_Travels.controller
{
    public class LoginController
    {
        public static bool login(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                return false; // Return false if fields are empty
            }

            SqlDbDataAccess sda = new SqlDbDataAccess();
            SqlCommand cmd = sda.GetQuery("SELECT Id, email, Role FROM Users WHERE Email = @email AND Password = @password");
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int id = reader.GetInt32(reader.GetOrdinal("Id"));
                        string role = reader.GetString(reader.GetOrdinal("Role")).ToLower();

                        // Only allow valid roles
                        if (role == "user" || role == "admin" || role == "employee" )
                        {
                            Cookie.UserId = id;
                            Cookie.Role = role;
                            return true;
                        }
                    }
                }
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                    cmd.Connection.Close();
            }

            return false;
        }
    }
}
