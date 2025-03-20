using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class SzamlaMuveletek
    {
        public static string connect = "server=localhost;database = bank;user = root; password = ;";
        public static void EgyenlegLekeres()
        {
            string query = "SELECT szamlaszam,egyenleg FROM szamlak";
            using (MySqlConnection conn = new MySqlConnection(connect))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            string szamlaszam = reader.GetString("szamlaszam");
                            decimal egyenleg = reader.GetDecimal("egyenleg");
                        }

                        Console.WriteLine("-------Számla adatai-------");
                        Console.WriteLine($"Szamlaszam: {reader["szamlaszam"]}, Egyenleg:{reader["egyenleg"]}");
                    }
                }
            }
        }

        public static void Befizetes(string szamlaszam, decimal osszeg)
        {
            Console.WriteLine("Add meg a számlaszámodat:");
            szamlaszam = Console.ReadLine();
            Console.WriteLine("Add meg az összeget:");
            osszeg = decimal.Parse(Console.ReadLine());

            using (MySqlConnection conn = new MySqlConnection(connect))
            {
                conn.Open();
                string query = "UPDATE szamlak SET egyenleg = egyenleg + @osszeg WHERE szamlaszam = @szamlaszam";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@szamlaszam", szamlaszam);
                    cmd.Parameters.AddWithValue("@osszeg", osszeg);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Sikeresen módosítva lett az egyenleg.");
                }
            }
        }

        public static void Penzfelvetel(string szamlaszam, decimal osszeg)
        {
            Console.WriteLine("Add meg a számlaszámodat:");
            szamlaszam = Console.ReadLine();
            Console.WriteLine("Add meg az mekkora összeget szeretnél felvenni:");
            osszeg = decimal.Parse(Console.ReadLine());
            using (MySqlConnection conn = new MySqlConnection(connect))
            {
                conn.Open();
                string query = "UPDATE szamlak SET egyenleg = egyenleg - @osszeg WHERE szamlaszam = @szamlaszam";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@szamlaszam", szamlaszam);
                    cmd.Parameters.AddWithValue("@osszeg", osszeg);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Sikeresen felvetted a pénzt.");
                }
            }
        }
    }
}
