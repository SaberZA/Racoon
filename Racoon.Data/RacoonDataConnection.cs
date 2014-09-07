using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racoon.Data
{
    public class RacoonDataConnection
    {
        private static SqlConnection Instance { get; set; }

        private RacoonDataConnection(){}

        public static SqlConnection GetSqlConnection(string connectiongString)
        {
            Instance = new SqlConnection(connectiongString);
            return Instance;
        }

        public static void CloseSqlConnection()
        {
            Instance.Close();
            Instance = null;
        }

    }
}
