using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;

namespace Hellje
{
    internal class Program
    {
        public static string connectionString = "server=localhost;database=hellje;user=root;password=;";
        static void Main(string[] args)
        {
            List<Boltok> bolt = new List<Boltok>();
            List<Kinalat> hell = new List<Kinalat>();
            string[] lines = File.ReadAllLines("hellje.txt");
            string[] lines2 = File.ReadAllLines("hellje2.txt");
            
            foreach (string linee in lines)
            {
                string[] adatok = linee.Split(',');
                Boltok ujbolt = new Boltok(adatok[0], adatok[1], adatok[2], adatok[3], adatok[4]);
                bolt.Add(ujbolt);
            }
            

            foreach (string line in lines2)
            {
                string[] adatok = line.Split(',');
                Kinalat ujhell = new Kinalat(adatok[0], adatok[1], adatok[2], adatok[3], adatok[4]);
                hell.Add(ujhell);
            }

            
            foreach (var itemm in bolt)
            {
                Console.WriteLine($"{itemm.Bid}, {itemm.boltnev}, {itemm.ar}, {itemm.db}, {itemm.varos}");
            }
            

            foreach (var item in hell)
            {
                Console.WriteLine($"{item.Kid}, {item.Bid}, {item.ml}, {item.tipus}, {item.iz}");
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                
                try
                {
                    conn.Open();
                    Console.WriteLine("Sikerült.");
                    foreach (var iteem in bolt)
                    {
                        //Ujbolt(iteem.Bid, iteem.boltnev, iteem.ar, iteem.db, iteem.varos);
                    }

                    UjHell(6, 2, 250, "normál", "szőlő");

                    BoltListazasa();
                    HellListazasa();
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Hiba a kapcsolat során: " + ex.Message);
                }
                
                /*
                try
                {
                    conn.Open();
                    Console.WriteLine("Sikerült.");
                    foreach (var item in hell)
                    {
                        //Ujhell(item.Kid, item.Bid, item.ml, item.tipus, item.iz);
                    }

                }
                */
            }
            Console.WriteLine(bolt[0]);
            Console.WriteLine(hell[0]);
            Console.ReadKey();
        }

        
        static void Ujbolt(int Bid, string boltnev, int ar, int db, string varos)
        {
            string query = "INSERT INTO boltok(Bid, boltnev, ar, db, varos) VALUES (@Bid, @boltnev, @ar, @db, @varos)";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using(MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Bid", Bid);
                    cmd.Parameters.AddWithValue("@boltnev", boltnev);
                    cmd.Parameters.AddWithValue("@ar", ar);
                    cmd.Parameters.AddWithValue("@db", db);
                    cmd.Parameters.AddWithValue("@varos", varos);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        

        static void Ujhell(int Kid, int Bid, int ml, string tipus, string iz)
        {
            string query = "INSERT INTO kinalat(Kid, Bid, ml, tipus, iz) VALUES (@Kid, @Bid, @ml, @tipus, @iz)";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Kid", Kid);
                    cmd.Parameters.AddWithValue("@Bid", Bid);
                    cmd.Parameters.AddWithValue("@ml", ml);
                    cmd.Parameters.AddWithValue("@tipus", tipus);
                    cmd.Parameters.AddWithValue("@iz", iz);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        
        static void HellListazasa()
        {
            string query = "SELECT * FROM kinalat";
            string filePath = "hellek.txt"; // A fájl neve

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {


                    // StreamWriter megnyitása fájlírásra (felülírja a fájlt, ha már létezik)
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine("Hellek listája:");
                        writer.WriteLine("=====================\n");

                        Console.WriteLine("\n--- Hellek listája ---");

                        while (reader.Read())
                        {
                            // Adatok beolvasása
                            int Kid = reader.GetInt32("Kid");
                            int Bid = reader.GetInt32("Bid");
                            int ml = reader.GetInt32("ml");
                            string tipus = reader.GetString("tipus");
                            string iz = reader.GetString("iz");

                            Console.WriteLine($"Id: {reader["Kid"]}, Boltid: {reader["Bid"]}, mililiter: {reader["ml"]}, típus: {reader["tipus"]}, Íz: {reader["iz"]}");

                            // Fájlba írás TXT formátumban
                            writer.WriteLine($"Id: {Kid}");
                            writer.WriteLine($"Boltid: {Bid}");
                            writer.WriteLine($"Mililiter: {ml}");
                            writer.WriteLine($"Típus: {tipus}");
                            writer.WriteLine($"Íz: {iz}");
                            writer.WriteLine("---------------------");
                        }
                    }
                }
            }
            Console.WriteLine($"\nAz adatok mentésre kerültek a(z) {filePath} fájlba.");

        }
        

        static void BoltListazasa()
        {
            string query = "SELECT * FROM boltok";
            string filePath = "hellek2.txt"; // A fájl neve

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {


                    // StreamWriter megnyitása fájlírásra (felülírja a fájlt, ha már létezik)
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine("Boltok listája:");
                        writer.WriteLine("=====================\n");

                        Console.WriteLine("\n--- Boltok listája ---");

                        while (reader.Read())
                        {
                            // Adatok beolvasása
                            int Bid = reader.GetInt32("Bid");
                            string boltnev = reader.GetString("boltnev");
                            int ar = reader.GetInt32("ar");
                            int db = reader.GetInt32("db");
                            string varos = reader.GetString("varos");

                            Console.WriteLine($"Id: {reader["Bid"]}, Név: {reader["boltnev"]}, ár: {reader["ar"]}, db: {reader["db"]}, Város: {reader["varos"]}");

                            // Fájlba írás TXT formátumban
                            writer.WriteLine($"Id: {Bid}");
                            writer.WriteLine($"Név: {boltnev}");
                            writer.WriteLine($"ár: {ar}");
                            writer.WriteLine($"db: {db}");
                            writer.WriteLine($"Város: {varos}");
                            writer.WriteLine("---------------------");
                        }
                    }
                }
            }
            Console.WriteLine($"\nAz adatok mentésre kerültek a(z) {filePath} fájlba.");

        }

        static void UjHell(int Kid, int Bid, int ml, string tipus, string iz)
        {
            string query = "INSERT INTO kinalat (Kid, Bid, ml, tipus, iz) VALUES (@Kid, @Bid, @ml, @tipus, @iz)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Kid", Kid);
                    cmd.Parameters.AddWithValue("@Bid", Bid);
                    cmd.Parameters.AddWithValue("@ml", ml);
                    cmd.Parameters.AddWithValue("@tipus", tipus);
                    cmd.Parameters.AddWithValue("@iz", iz);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
