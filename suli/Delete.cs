using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suli
{
    internal class Delete
    {
        public static string connection = "server=localhost;database=iskola;user=root;password=;";

        public static void AdatTorles(int diak_id)
        {
            string query = "DELETE FROM diak WHERE diak_id = @diak_id";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                try
                {                   
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@diak_id", diak_id);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Hiba történt" + ex.Message);
                }
            }
        }      
    }
}
