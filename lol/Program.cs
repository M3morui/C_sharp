using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol
{
    internal class Program
    {
        public static string connectionString = "server=localhost;database=lol;user=root;password=;";
        static void Main(string[] args)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Sikerült!");
                    //UjLol("Viktor", "Zaun", "Mid");
                    //UjLol("Viktor", "Zaun", "Mid");
                    //UjLol("Jinx", "Zaun", "Adc");
                    //UjLol("Ekko", "Zaun", "Mid");
                    //UjLol("Jayce", "Piltover", "Top");
                    //UjLol("Mel", "Noxus", "Supp");
                    IzeListazasa();
                    LolFrissitese(6, "Mel", "Noxus", "Mid");
                    LolTorlese(2);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Nem sikerült: " + ex.Message);
                }

            }
            Console.ReadKey();
        }
        static void UjLol(string nev, string szarmazas, string szerep)
        {
            string query = "INSERT INTO ize (nev, szarmazas, szerep) VALUES (@nev, @szarmazas, @szerep)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nev", nev);
                    cmd.Parameters.AddWithValue("@szarmazas", szarmazas);
                    cmd.Parameters.AddWithValue("@szerep", szerep);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        static void IzeListazasa()
        {
            string query = "SELECT * FROM ize";
            string filePath = "arcanelol.txt"; // A fájl neve

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {


                    // StreamWriter megnyitása fájlírásra (felülírja a fájlt, ha már létezik)
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine("Lol listája:");
                        writer.WriteLine("=====================\n");

                        Console.WriteLine("\n--- Lol listája ---");

                        while (reader.Read())
                        {
                            // Adatok beolvasása
                            int id = reader.GetInt32("id");
                            string nev = reader.GetString("nev");
                            string szarmazas = reader.GetString("szarmazas");
                            string szerep = reader.GetString("szerep");

                            Console.WriteLine($"ID: {reader["id"]}, Név: {reader["nev"]}, Származás: {reader["szarmazas"]}, Szerep: {reader["szerep"]}");

                            // Fájlba írás TXT formátumban
                            writer.WriteLine($"ID: {id}");
                            writer.WriteLine($"Név: {nev}");
                            writer.WriteLine($"Származás: {szarmazas}");
                            writer.WriteLine($"Szerep: {szerep}");
                            writer.WriteLine("---------------------");
                        }
                    }
                }
            }
            Console.WriteLine($"\nAz adatok mentésre kerültek a(z) {filePath} fájlba.");

        }

        static void LolFrissitese(int id, string ujNev, string ujSzarmazas, string ujSzerep)
        {
            string query = "UPDATE ize SET nev = @nev, szarmazas = @szarmazas, szerep = @szerep WHERE id = @id";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nev", ujNev);
                    cmd.Parameters.AddWithValue("@szarmazas", ujSzarmazas);
                    cmd.Parameters.AddWithValue("@szerep", ujSzerep);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        static void LolTorlese(int id)
        {
            string query = "DELETE FROM ize WHERE id = @id";

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
