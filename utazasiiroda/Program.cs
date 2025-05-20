using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZstdSharp.Unsafe;

namespace utazasiiroda
{
    internal class Program
    {
        public static string connection = "server=localhost;database=iroda;user=root;password=;";
        static void Main(string[] args)
        {
            Console.WriteLine("Válasszon egy műveletet! \n 1.Foglalás \n 2.Foglalások \n 3.Bevétel \n 4.Csoportosítás \n 5.Kedvezmények \n 6.Törlés \n");
            int beker = Convert.ToInt32(Console.ReadLine());

            switch (beker)
            {
                case 1: AdatBeker();
                    break;

                case 2: Kiolvas();
                    break;

                case 3: Bevetel();
                    break;

                case 4: Csoport();
                    break;

                case 5: Kedvez();
                    break;

                case 6: Torles();
                    break;
            }
        }

        static void AdatBeker()
        {
            Console.WriteLine("Add meg a neved: ");
            string nev = Console.ReadLine();
            Console.WriteLine("Add meg a helyszínt: ");
            string helyszin = Console.ReadLine();
            Console.WriteLine("Add meg a születési dátumod: ");
            DateTime szuldatum = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Hány napot maradsz: ");
            int napoksz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add meg a dátumot: ");
            DateTime datum = Convert.ToDateTime(Console.ReadLine());

            try
            {
                using(MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    string query = "INSERT INTO vasarlok (nev,helyszin,szuldatum,napoksz,datum) VALUES(@nev,@helyszin,@szuldatum,@napoksz,@datum)";
                    using(MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nev", nev);
                        cmd.Parameters.AddWithValue("@helyszin", helyszin);
                        cmd.Parameters.AddWithValue("@szuldatum", szuldatum);
                        cmd.Parameters.AddWithValue("@napoksz", napoksz);
                        cmd.Parameters.AddWithValue("@datum", datum);
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Sikeres volt a foglalás!");
                    }
                }
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Kiolvas()
        {
            try
            {
                using(MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    string query = "SELECT * FROM vasarlok";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using(MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string nev = reader.GetString("nev");
                                string helyszin = reader.GetString("helyszin");
                                DateTime szuldatum = reader.GetDateTime("szuldatum");
                                int napoksz = reader.GetInt32("napoksz");
                                DateTime datum = reader.GetDateTime("datum");
                                Console.WriteLine($"Név: {reader["nev"]}, Helyszín: {reader["helyszin"]}, Születési dátum: {reader["szuldatum"]}, Napok száma: {reader["napoksz"]}, Dátum: {reader["datum"]}");
                            }
                        }
                    }
                }
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Bevetel()
        {
            try
            {
                using(MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    string query = "SELECT SUM(napoksz) AS osszes FROM vasarlok";
                    using(MySqlCommand cmd = new MySqlCommand( query, conn))
                    {
                        using(MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int napoksz = reader.GetInt32("osszes");
                                Console.WriteLine($"Az össz bevétel: {napoksz*12000} Ft");
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Csoport()
        {
            try
            {
                using(MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    string query = "SELECT helyszin, COUNT(nev) as fő FROM vasarlok GROUP BY helyszin";
                    using(MySqlCommand cmd =new MySqlCommand( query, conn))
                    {
                        using(MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string nev = reader.GetString("helyszin");
                                int a = reader.GetInt32("fő");
                                Console.WriteLine($"Helyszin: {reader["helyszin"]} Utazók: {reader["fő"]} db");
                            }
                        }
                    }
                }
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Kedvez()
        {
            try
            {
                using(MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    string query = "SELECT nev, helyszin, ((napoksz*12000)*0.2) AS fizet FROM vasarlok WHERE szuldatum BETWEEN '2001-01-01' and '2006-01-01' ORDER BY fizet ASC";
                    using (MySqlCommand cmd =new MySqlCommand(query, conn))
                    {
                        using(MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string nev = reader.GetString("nev");
                                string helyszin = reader.GetString("helyszin");
                                int napoksz = reader.GetInt32("fizet");
                                Console.WriteLine($"Név: {reader["nev"]}, Helyszín: {reader["helyszin"]}, Fizetendő összeg: {reader["fizet"]}");
                            }
                        }
                    }
                }
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Torles()
        {
            Kiolvas();
            Console.WriteLine("Add meg a törlendő személy nevét!");
            string nev = Console.ReadLine();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    string query = "DELETE FROM vasarlok WHERE nev=@nev";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nev", nev);
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Sikeres volt a törlés!");
                    }
                }
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
