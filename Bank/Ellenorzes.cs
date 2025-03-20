using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Ellenorzes
    {
        public static string connect = "server=localhost;database = bank;user = root; password = ;";


        public static bool AdatEllenorzes(string tulajdonos_nev, int azonosito, int pinkod)
        {

            Console.WriteLine("Adja meg a nevét: ");
            tulajdonos_nev = Console.ReadLine();
            Console.WriteLine("Adja meg az azonositoját: ");
            azonosito = int.Parse(Console.ReadLine());
            Console.WriteLine("Adja meg a pinkodót:");
            pinkod = int.Parse(Console.ReadLine());

            bool sikeres = false;

            using (MySqlConnection conn = new MySqlConnection(connect))
            {
                conn.Open();
                string query = "SELECT tulajdonos_nev,azonosito,pinkod FROM szamla_tulajdonosok WHERE tulajdonos_nev = @tulajdonos_nev AND azonosito = @azonosito AND pinkod = @pinkod";


                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tulajdonos_nev", tulajdonos_nev);
                    cmd.Parameters.AddWithValue("@azonosito", azonosito);
                    cmd.Parameters.AddWithValue("@pinkod", pinkod);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            sikeres = true;
                        }

                    }


                }


            }
            return sikeres;
        }
    }
}
