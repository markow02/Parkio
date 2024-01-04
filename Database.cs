using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SystemParkingowy
{
    internal class Database
    {
        /*        static readonly string server = "127.0.0.1";
                static readonly int port = 3306;
                static readonly string user = "root";
                static readonly string password = "";
                static readonly string database = "financial";*/


        static readonly string server = "mysql-parking-systemparkingowy.a.aivencloud.com";
        static readonly int port = 13149;
        static readonly string user = "avnadmin";
        static readonly string password = "AVNS_HnZmeXPxo5C2Vx86N2i";
        static readonly string database = "parking";


        public static string connection_string = "server='" + server + "'; port= '" + port + "'; user= '" + user + "'; database= '" + database + "'; password='" + password + "'";
        public MySqlConnection mySqlConection = new MySqlConnection(connection_string);


        public bool connect_db()
        {
            try
            {
                mySqlConection.Open();
                return true;
            }   
            catch(Exception ex)
            {
                return false; 
            }
        }
        public bool close_db()
        {
            try
            {
                mySqlConection.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
