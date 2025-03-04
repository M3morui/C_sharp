using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Pqc.Crypto.Lms;

namespace lol2
{
    internal class Program
    {

        public static string connectionString = "server=localhost;database=lol;user=root;password=;";
        static void Main(string[] args)
        {
            List<Lol> asd = new List<Lol>();
            string[] lines = File.ReadAllLines("lol.txt");
            foreach (string line in lines)
            {
                string[] adatok = line.Split(',');
                Lol ujasd = new Lol(adatok[0], adatok[1], adatok[2], adatok[3], adatok[4], adatok[5], adatok[6]);
                asd.Add(ujasd);
            }

            foreach (var item in asd)
            {
                Console.WriteLine($"{item.id}, {item.szint}, {item.meccsek}, {item.vereseg}, {item.hos}, {item.osveny}, {item.nev}");
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Sikerült.");
                    foreach (var item in asd)
                    {

                        //Ujlol(item.id, item.szint, item.meccsek, item.vereseg, item.hos, item.osveny, item.nev);
                        

                    }

                    int felszam = Lol.Megszamol(asd);
                    Console.WriteLine($"Összesen {felszam} játékos van.");

                    List<string> nevek = Lol.NevekMegszamol(asd);
                    Console.WriteLine(string.Join(",", nevek));
                    Console.WriteLine($"S-betűvel kezdődő nevek db száma: {nevek.Count}");
                    /*
                    Console.WriteLine("Adj meg egy id-t:");
                    int id = int.Parse(Console.ReadLine());

                    Console.WriteLine("Add meg a szintet: ");
                    string szint = Console.ReadLine();

                    Console.WriteLine("Add meg a meccsek számát:");
                    string meccsek = Console.ReadLine();

                    Console.WriteLine("Add meg a veresegek számát:");
                    int vereseg = int.Parse(Console.ReadLine());

                    Console.WriteLine("Add meg a hőst:");
                    string hos = Console.ReadLine();

                    Console.WriteLine("Add meg melyik ösvényen játszik:");
                    string osveny = Console.ReadLine();

                    Console.WriteLine("Add meg a felhasználónevet:");
                    string nev = Console.ReadLine();

                    List<string> kari = Lol.LolMegad(asd);
                    foreach (var item in kari)
                    {
                        Console.WriteLine(item);
                    }
                    */

                }

                catch (Exception ex)
                {
                    Console.WriteLine("Hiba a kapcsolat során: " + ex.Message);
                }
            }
            Console.WriteLine(asd[0]);
            Console.ReadKey();
        }

            static void Ujlol(int id, string szint, int meccsek, int vereseg, string hos, string osveny, string nev)
            {
                string query = "INSERT INTO gyaklol (id, szint, meccsek, vereseg, hos, osveny, nev) VALUES(@id, @szint, @meccsek, @vereseg, @hos, @osveny, @nev)";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using(MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@szint", szint);
                        cmd.Parameters.AddWithValue("@meccsek", meccsek);
                        cmd.Parameters.AddWithValue("@vereseg", vereseg);
                        cmd.Parameters.AddWithValue("@hos", hos);
                        cmd.Parameters.AddWithValue("@osveny", osveny);
                        cmd.Parameters.AddWithValue("@nev", nev);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
    }
}
