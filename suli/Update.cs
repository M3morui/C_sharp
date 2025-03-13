using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suli
{
    internal class Update
    {
        public static string connection = "server=localhost;database=iskola;user=root;password=;";

        public static void AdatModosit(string regidveznev, string ujdveznev, string dkernev, string osztaly)
        {
            string query = "UPDATE diak  SET dveznev = @ujdveznev, dkernev = @dkernev, osztaly = @osztaly WHERE dveznev = @regidveznev";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@regidveznev",regidveznev);
                        cmd.Parameters.AddWithValue("@ujdveznev",ujdveznev);
                        cmd.Parameters.AddWithValue("@dkernev",dkernev);
                        cmd.Parameters.AddWithValue("@osztaly",osztaly);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hiba történt" + ex.Message);
                }
            }
        }
    }
}
