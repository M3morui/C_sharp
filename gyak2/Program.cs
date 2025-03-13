using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak2
{
    internal class Program
    {
        public static string connection = "server=localhost;database=regisztracio;user=root;password=;";
        static void Main(string[] args)
        {
            List<Regisztracio> felhasznalo = new List<Regisztracio>();
            string[] sorok = File.ReadAllLines("register.txt");
            foreach(string sor in sorok)
            {
                string[] adatok = sor.Split(';');
                Regisztracio ujfelhasznalo = new Regisztracio(adatok[0], adatok[1], adatok[2], adatok[3], adatok[4]);
                felhasznalo.Add(ujfelhasznalo);
            }

            foreach(var felh in felhasznalo)
            {
                Console.WriteLine($"{felh.nev}, {felh.felnev}, {felh.email}, {felh.jelszo}, {felh.szuldatum}");
            }

            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Sikerült.");
                    /*
                    foreach (var felh in felhasznalo)
                    {
                        FelhHozzaad(felh.nev, felh.felnev, felh.email, felh.jelszo, felh.szuldatum);
                    }
                    Console.WriteLine("Sikeresen feltöltötted..");
                    */
                    //FelhHozzaad("Grósz Paatrik", "TRH147", "trh114477@gmail.com", "Aatrox12345", new DateTime(2004,08,04));
                    FelhListazasa();
                    UserTorles(5);
                    //UserModosit(1, "Tőkés Martin", "Tks824", "martinkezi00@icloud.com", "tiszapart123", new DateTime(2000,08,24));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Nem sikerült" + ex.Message);
                }
                    
            }



            Console.ReadKey();
        }

        static void FelhHozzaad(string nev, string felnev, string email, string jelszo, DateTime szuldatum)
        {
            string query = "INSERT INTO userek (nev,felnev,email,jelszo,szuldatum) VALUES (@nev,@felnev,@email,@jelszo,@szuldatum)";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                using(MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nev", nev);
                    cmd.Parameters.AddWithValue("@felnev", felnev);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@jelszo", jelszo);
                    cmd.Parameters.AddWithValue("@szuldatum", szuldatum);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        static void FelhListazasa()
        {
            string query = "SELECT * FROM userek";
            string filepath = "ujuserek.txt";

            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                using(MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using(MySqlDataReader reader = cmd.ExecuteReader())
                    using (StreamWriter sw = new StreamWriter(filepath))
                    {
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32("id");
                                string nev = reader.GetString("nev");
                                string felnev = reader.GetString("felnev");
                                string email = reader.GetString("email");
                                string jelszo = reader.GetString("jelszo");
                                DateTime szuldatum = reader.GetDateTime("szuldatum");


                                Console.WriteLine($"ID: {reader["id"]}, Nev: {reader["nev"]}, Felhasználónév: {reader["felnev"]}, Email: {reader["email"]}, Jelszó: {reader["jelszo"]}, Szuldatum: {reader["szuldatum"]}");
                                sw.WriteLine($"ID: {reader["id"]}, Nev: {reader["nev"]}, Felhasználónév: {reader["felnev"]}, Email: {reader["email"]}, Jelszó: {reader["jelszo"]}, Szuldatum: {reader["szuldatum"]}");
                            }
                        }
                    }                    
                }
            }
        }

        static void UserModosit(int id, string nev, string felnev, string email, string jelszo, DateTime szuldatum)
        {
            string query = "UPDATE userek SET nev = @nev, felnev = @felnev, email = @email, jelszo = @jelszo, szuldatum = @szuldatum WHERE id = @id";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nev", nev);
                    cmd.Parameters.AddWithValue("@felnev", felnev);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@jelszo", jelszo);
                    cmd.Parameters.AddWithValue("@szuldatum", szuldatum);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        static void UserTorles(int id)
        {
            string query = "DELETE * FROM userek WHERE id = @id";
            using(MySqlConnection con = new MySqlConnection(connection))
            {
                con.Open();
                using(MySqlCommand cmd = new MySqlCommand( query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }




    }
}
