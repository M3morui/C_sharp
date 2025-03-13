using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;

namespace suli
{
    internal class Read
    {
        public static string connection = "server=localhost; database = iskola; user=root; password=;";

        public static void AdatKiolvas()
        {
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM diak";
                    string file = "diakok.txt";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader read = cmd.ExecuteReader())
                        {
                            using(StreamWriter sr = new StreamWriter(file))
                            {
                                while (read.Read())
                                {
                                    int diak_id = read.GetInt32("diak_id");
                                    string dveznev = read.GetString("dveznev");
                                    string dkernev = read.GetString("dkernev");
                                    string osztaly = read.GetString("osztaly");

                                    sr.Write($"ID: {diak_id}");
                                    sr.Write($"Vezetéknév: {dveznev}");
                                    sr.Write($"Keresztnév: {dkernev}");
                                    sr.Write($"Osztály: {osztaly}");


                                    Console.WriteLine($"ID: {read["diak_id"]}, Vezetéknév: {read["dveznev"]}, Keresztnév: {read["dkernev"]}, Osztály: {read["osztaly"]}");
                                }
                            }                           
                        }
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Hiba" + ex.Message);
                }
            }
        }
    }
}
