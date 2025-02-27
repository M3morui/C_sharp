using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.IsisMtt;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto
{
    internal class Program
    {
        public static string connectionString = "server=localhost;database=nyilvantartas;user=root;password=;";
        static void Main(string[] args)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Sikerült!");
                    //UjAuto("Ford", "AA56L", 230000);
                    //UjAuto("Toyota", "AA69L", 260000);
                    //UjAuto("Toyota", "AA70L", 260000);
                    AutokListazasa();
                    AutokFrissitese(3, "Volvo", "AA10K", 3000000);
                    AutoTorlese(1);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Nem sikerült: " + ex.Message);
                }

            }
                Console.ReadKey();
        }

        static void UjAuto(string marka, string renszam, int ar)
        {
            string query = "INSERT INTO autok (marka, renszam, ar) VALUES (@marka, @renszam, @ar)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@marka", marka);
                    cmd.Parameters.AddWithValue("@renszam", renszam);
                    cmd.Parameters.AddWithValue("@ar", ar);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        static void AutokListazasa()
        {
            string query = "SELECT * FROM autok";
            string filePath = "autonyilvantartas.txt"; // A fájl neve

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {


                    // StreamWriter megnyitása fájlírásra (felülírja a fájlt, ha már létezik)
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine("Autók listája:");
                        writer.WriteLine("=====================\n");

                        Console.WriteLine("\n--- Autók listája ---");

                        while (reader.Read())
                        {
                            // Adatok beolvasása
                            int id = reader.GetInt32("id");
                            string marka = reader.GetString("marka");
                            string renszam = reader.GetString("renszam");
                            int ar = reader.GetInt32("ar");

                            Console.WriteLine($"ID: {reader["id"]}, Márka: {reader["marka"]}, Rendszam: {reader["renszam"]}, Ár: {reader["ar"]}");

                            // Fájlba írás TXT formátumban
                            writer.WriteLine($"ID: {id}");
                            writer.WriteLine($"Márka: {marka}");
                            writer.WriteLine($"Rendszam: {renszam}");
                            writer.WriteLine($"Ár: {ar}");
                            writer.WriteLine("---------------------");
                        }
                    }
                }
            }
            Console.WriteLine($"\nAz adatok mentésre kerültek a(z) {filePath} fájlba.");

        }

        static void AutokFrissitese(int id, string ujMarka, string ujRenszam, int ujAr)
        {
            string query = "UPDATE autok SET marka = @marka, renszam = @renszam, ar = @ar WHERE id = @id";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@marka", ujMarka);
                    cmd.Parameters.AddWithValue("@renszam", ujRenszam);
                    cmd.Parameters.AddWithValue("@ar", ujAr);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        static void AutoTorlese(int id)
        {
            string query = "DELETE FROM autok WHERE id = @id";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }






    }
}
