using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Optimus_Travels
{
    public class SqlDbDataAccess
    {
        //server 2022
        private const string connectionString = @"Data Source=DESKTOP-9D6P8DL\SQLEXPRESS; Initial Catalog=optimus; Trusted_Connection=True";

        //server 2014 and server 2018
        //private const string connectionString = @"Data Source= DESKTOP-5IIMGTU\SQLEXPRESS; Initial Catalog=Product Management System; Integrated Security=True";

        public SqlCommand GetQuery(string query)
        {
            var connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = connection;
            return cmd;
        }
    }
}
