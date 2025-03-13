using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace suli
{  
    internal class Create
    {
        public static string connection = "server=localhost; database = iskola; user=root; password=;";
        public static void UjDiak(int diak_id, string dveznev, string dkernev, string osztaly)
        {
            using (MySqlConnection conn = new MySqlConnection(connection))
            {               
                try
                {
                    string query = "INSERT INTO diak (diak_id,dveznev,dkernev,osztaly) VALUES (@diak_id,@dveznev,@dkernev,@osztaly)";
                    conn.Open();
                    using(MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@diak_id", diak_id);
                        cmd.Parameters.AddWithValue("@dveznev", dveznev);
                        cmd.Parameters.AddWithValue("@dkernev", dkernev);
                        cmd.Parameters.AddWithValue("@osztaly", osztaly);
                        cmd.ExecuteNonQuery();
                    }
                    Console.WriteLine("Sikeres csatlakozás.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hiba történt." + ex.Message);
                }

            }
        }
        

    }
}
