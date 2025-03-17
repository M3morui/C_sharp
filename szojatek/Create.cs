using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szojatek
{
    internal class Create
    {
        public static string connection = "server=localhost;database=szojatek;user=root;password=;";
        public static void JatekAdatFeltolt(string nev, int meccsek, int pontok)
        {
            string query = "INSERT INTO jatekos (nev, meccsek, pontok) VALUES (@nev, @meccsek, @pontok)";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nev", nev);
                    cmd.Parameters.AddWithValue("@meccsek", meccsek);
                    cmd.Parameters.AddWithValue("@pontok", pontok);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
