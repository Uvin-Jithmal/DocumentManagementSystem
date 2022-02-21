using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Connection
{
    class SqlConn
    {
        public static MySqlConnection OpenConnectiion()
        {
            MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            else
                con.Close();
            return con;
        }

        public static MySqlConnection GetConnection()
        {

            MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString);
            return con;

        }

        public static bool CheckConnectionIsAvialable()
        {
            bool IsAvialable = false;
            try
            {

                MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString);
                if (con.State == ConnectionState.Open)
                {
                    IsAvialable = true;
                }
                else
                {
                    con.Open();
                    IsAvialable = true;
                }

                return IsAvialable;
            }
            catch (Exception ex)
            {
                IsAvialable = false;
                return IsAvialable;
            }
        }
    }
}
