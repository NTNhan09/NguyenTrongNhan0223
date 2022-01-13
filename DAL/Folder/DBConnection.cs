using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL.Folder
{
        public class DBConnection
        {
            public DBConnection()
            {

            }
            public SqlConnection CreateConnection()
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=DESKTOP-FQ6H4V9\NICHO;Initial Catalog=HR;User Id=sa; Password=sa";
                return conn;
            }
        }
}
