using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Borrowing_System.Data
{
    public static class DatabaseConfig
    {
        public static string ServerName = "localhost";
        public static string UserId = "root";
        public static string Password = "Admin1234-";
        public static string DatabaseName = "borrowingsystem";
    }
}
