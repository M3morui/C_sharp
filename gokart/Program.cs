using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gokart
{
    internal class Program
    {
        public static string connection = "server=localhost;database=gokart;user=root;password=;";
        static void Main(string[] args)
        {
            Console.WriteLine("Üdv a gokart oldalán!");
            Console.WriteLine("Válasszon egy műveletet! \n 1.Foglalás \n 2.Foglalások \n 3.Bevétel \n 4.Csoportosítás \n 5.Módosítás \n 6.Törlés \n");
            int beker = Convert.ToInt32(Console.ReadLine());

            switch(beker)
            {
                case 1: AdatBeker();
                    break;

                case 2: Kiolvas();
                    break;

                case 3: Bevetel();
                    break;

                case 4: Csoport();
                    break;

                case 5: Modositas();
                    break;

                case 6: Torles();
                    break;
            }
        }

        static void AdatBeker()
        {
            Console.WriteLine("Add meg a neved: ");
            string nev = Console.ReadLine();
            Console.WriteLine("Hány főre foglal?");
            int jegyek = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adj meg a dátumot.");
            DateTime datum = Convert.ToDateTime(Console.ReadLine());

            try
            {
                using(MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    string query = "INSERT INTO  vasarlok (nev,jegyek,datum) VALUES(@nev,@jegyek,@datum)";
                    using(MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nev",nev);
                        cmd.Parameters.AddWithValue("@jegyek",jegyek);
                        cmd.Parameters.AddWithValue("@datum",datum);
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
                    using(MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using(MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string nev = reader.GetString("nev");
                                int jegyek = reader.GetInt32("jegyek");
                                DateTime datum = reader.GetDateTime("datum");
                                Console.WriteLine($"Név: {reader["nev"]}, Jegyek: {reader["jegyek"]}, Dátum: {reader["datum"]}");
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
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    string query = "SELECT SUM(jegyek) AS osszes FROM vasarlok";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int jegyek = reader.GetInt32("osszes");
                                Console.WriteLine($"Az össz bevétel: {jegyek*5600} Ft");
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
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    string query = "SELECT nev, (jegyek*5600) AS fizet FROM vasarlok GROUP BY nev ORDER BY fizet ASC";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string nev = reader.GetString("nev");
                                int jegyek = reader.GetInt32("fizet");
                                Console.WriteLine($"Név: {reader["nev"]}, Jegyek: {reader["fizet"]}");
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

        static void Modositas()
        {
            Kiolvas();
            Console.WriteLine("Melyiket akarod módosítani?");
            string reginev = Console.ReadLine();
            Console.WriteLine("Add meg a nevet: ");
            string ujnev = Console.ReadLine();
            Console.WriteLine("Add a jegyek száma: ");
            int jegyek = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add meg a dátumot: ");
            DateTime datum = Convert.ToDateTime(Console.ReadLine());
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    string query = "UPDATE vasarlok SET nev=@ujnev,jegyek=@jegyek,datum=@datum WHERE nev=@reginev";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@reginev", reginev);
                        cmd.Parameters.AddWithValue("@ujnev", ujnev);
                        cmd.Parameters.AddWithValue("@jegyek", jegyek);
                        cmd.Parameters.AddWithValue("@datum", datum);
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Sikeres volt a módosítás.");
                    }
                }
            }

            catch (Exception ex)
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
                    using(MySqlCommand cmd = new MySqlCommand( query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nev", nev);
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Sikeres volt a törlés!");
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
