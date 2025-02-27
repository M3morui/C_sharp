using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace cars
{
    internal class Program
    {
        public static string connectionString = "server=localhost;database=nyilvantartas;user=root;password=;";
        static void Main(string[] args)
        {
            List<string> autok = new List<string>();
            string[] lines = File.ReadAllLines("nyilvantartas.txt");
            foreach (string line in lines)
            {
                string[] adatok = line.Split(',');
                autok.Add(adatok[0]);
                autok.Add(adatok[1]);
                autok.Add(adatok[2]);
                autok.Add(adatok[3]);
                autok.Add(adatok[4]);
            }


            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Sikeres kapcsolat az adatbázishoz!");

                    for (int i = 0; i < autok.Count; i++)
                    {
                        UjAuto(int.Parse(autok[0]), autok[1], autok[2], int.Parse(autok[3]), int.Parse(autok[4]));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hiba a kapcsolat során: " + ex.Message);
                }
            }
            Console.WriteLine(autok[0]);
            Console.ReadKey();
        }
            static void UjAuto(int id, string marka, string rendszam, int ar, int db)
            {
                string query = "INSERT INTO cars (id, marka, rendszam, ar, db) VALUES (@id, @marka, @rendszam, @ar, @db)";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@marka", marka);
                        cmd.Parameters.AddWithValue("@rendszam", rendszam);
                        cmd.Parameters.AddWithValue("@ar", ar);
                        cmd.Parameters.AddWithValue("@db", db);
                        cmd.ExecuteNonQuery();
                    }
                }
            }




            
        
    }
}
