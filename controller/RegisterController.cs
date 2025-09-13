using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Optimus_Travels.controller
{
    public class RegisterController
    {
        public bool Register(string name, string address, string contact, string email, string password)
        {
            SqlDbDataAccess sda = new SqlDbDataAccess();
            SqlCommand cmd = sda.GetQuery(
                "INSERT INTO Users (Name, Address, Contact, Email, Password) " +
                "VALUES (@name, @address, @contact, @email, @password)"
            );

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@contact", contact);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);

            try
            {
                cmd.Connection.Open();
                int rows = cmd.ExecuteNonQuery();  

                return rows > 0;  
            }
            catch
            {
                return false; 
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                    cmd.Connection.Close();
            }
        }

    }
}
