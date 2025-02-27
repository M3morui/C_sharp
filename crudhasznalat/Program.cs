using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudhasznalat
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
                    Console.WriteLine("Sikeres kapcsolat az adatbázishoz!");

                    //UjFelhasznalo("Kiss Péter", "peter@example.com");
                    UjFelhasznalo("Nagy Anna", "anna@example.com");


                    Console.WriteLine("\n--- Felhasználók listája ---");
                    FelhasznalokListazasa();

                    Console.WriteLine("\n--- Frissítés ---");
                    FelhasznaloFrissitese(1, "Kiss Péter Jr.", "peterjr@example.com");
                    FelhasznalokListazasa();

                    Console.WriteLine("\n--- Törlés ---");
                    FelhasznaloTorlese(2);
                    FelhasznalokListazasa();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hiba a kapcsolat során: " + ex.Message);
                }
                Console.ReadKey();
            }



        }

        static void UjFelhasznalo(string nev, string email)
        {
            string query = "INSERT INTO felhasznalok (nev, email) VALUES (@nev, @email)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nev", nev);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        static void FelhasznalokListazasa()
        {
            string query = "SELECT * FROM felhasznalok";
            string filePath = "felhasznalok.txt"; // A fájl neve

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {


                    // StreamWriter megnyitása fájlírásra (felülírja a fájlt, ha már létezik)
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine("Felhasználók listája:");
                        writer.WriteLine("=====================\n");

                        Console.WriteLine("\n--- Felhasználók listája ---");

                        while (reader.Read())
                        {
                            // Adatok beolvasása
                            int id = reader.GetInt32("id");
                            string nev = reader.GetString("nev");
                            string email = reader.GetString("email");

                            Console.WriteLine($"ID: {reader["id"]}, Név: {reader["nev"]}, Email: {reader["email"]}");

                            // Fájlba írás TXT formátumban
                            writer.WriteLine($"ID: {id}");
                            writer.WriteLine($"Név: {nev}");
                            writer.WriteLine($"Email: {email}");
                            writer.WriteLine("---------------------");
                        }
                    }
                }
            }
            Console.WriteLine($"\nAz adatok mentésre kerültek a(z) {filePath} fájlba.");

        }


        static void FelhasznaloFrissitese(int id, string ujNev, string ujEmail)
        {
            string query = "UPDATE felhasznalok SET nev = @nev, email = @email WHERE id = @id";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nev", ujNev);
                    cmd.Parameters.AddWithValue("@email", ujEmail);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        static void FelhasznaloTorlese(int id)
        {
            string query = "DELETE FROM felhasznalok WHERE id = @id";

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
