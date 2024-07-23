using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace KKSys
{
    internal class Connection
    {

        private MySqlConnection connectionString()
        {
            string conString = "server=localhost; user name=root; password=; database=kks_database;";
            MySqlConnection con = new MySqlConnection(conString);

            return con;
        }

    }
}
