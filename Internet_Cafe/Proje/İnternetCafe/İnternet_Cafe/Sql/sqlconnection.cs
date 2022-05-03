using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace İnternet_Cafe.Sql
{
    public class sqlconnection
    {
        private static string connectionString = @"Data Source=DESKTOP-3ODUATA\SQLEXPRESS;Initial Catalog=InternetCafe;Integrated Security=True";
        public static SqlConnection con { get; set; } = new SqlConnection(connectionString);
        
    }
}
