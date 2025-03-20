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


        public static int TulajdonosAdatFeltolt(string tulajdonos_nev, int azonosito, int pinkod)
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
                    string tulajdonosid = "SELECT LAST_INSERT_ID()";

                    using (MySqlCommand idcmd = new MySqlCommand(tulajdonosid, conn))
                    {
                        int tulajdonos_id = Convert.ToInt32(idcmd.ExecuteScalar());
                        return tulajdonos_id;
                    }
                }
            }
        }

        public static void SzamlaFeltolt(int tulajdonos_id, string szamlaszam, decimal egyenleg)
        {
            string query = "INSERT INTO szamlak (tulajdonos_id,szamlaszam,egyenleg) VALUES (@tulajdonos_id,@szamlaszam,@egyenleg)";
            using (MySqlConnection conn = new MySqlConnection(connect))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tulajdonos_id", tulajdonos_id);
                    cmd.Parameters.AddWithValue("@szamlaszam", szamlaszam);
                    cmd.Parameters.AddWithValue("@egyenleg", egyenleg);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
