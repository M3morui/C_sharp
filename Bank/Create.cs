using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Create
    {
        public static string connect = "server=localhost;database = bank;user = root; password = ;";


        public static void TulajdonosAdatFeltolt(string tulajdonos_nev, int azonosito, int pinkod)
        {
            string query = "INSERT INTO szamla_tulajdonosok (tulajdonos_nev,azonosito,pinkod) VALUES (@tulajdonos_nev,@azonosito,@pinkod)";
            using (MySqlConnection conn = new MySqlConnection(connect))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tulajdonos_nev", tulajdonos_nev);
                    cmd.Parameters.AddWithValue("@azonosito", azonosito);
                    cmd.Parameters.AddWithValue("@pinkod", pinkod);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
