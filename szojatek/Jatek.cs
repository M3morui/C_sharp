using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szojatek
{
    internal class Jatek
    {
        public string jatek_nev;
        public int pont;
        public int jatek;

        public Jatek(string jatek_nev, int pont, int jatek)
        {
            this.jatek_nev = jatek_nev;
            this.pont = pont;
            this.jatek = jatek;
        }

        static Random rnd = new Random();

        public static string connection = "server=localhost;database=szojatek;user=root;password=;";
        public static string Ujszo()
        {

            List<string> szavak = new List<string>
            {
                "kard", "pajzs", "varázslat", "ellenség", "páncél",
                "sárkány", "térkép", "labirintus", "arany", "kristály",
                "küldetés", "fegyver", "varázsital", "hős", "szörny",
                "pontszám", "élet", "futás", "ugrás", "boss",
                "multiplayer", "singleplayer", "co-op", "kihívás", "XP",
                "szintlépés", "loot", "kaszt", "NPC", "főellenség"
            };

            int index = rnd.Next(szavak.Count);
            string kivalasztott_szo = szavak[index];
            return kivalasztott_szo;
        }

        public static bool JatekFolytat(out string kivalasztott)
        {
            Console.WriteLine("Szeretnéd folytatni a játékot (igen/nem)?");
            string valasz = Console.ReadLine();

            if(valasz == "igen")
            {
                kivalasztott = Ujszo();
                return true;
            }
            else
            {
                kivalasztott = "";
                Console.WriteLine("Játék vége!");
                return false;
            }
        }
        public static (string, int, int) UjJatek()
        {
            string kivalasztott_szo = Ujszo();
            Console.WriteLine($"Kiválasztott szó: {kivalasztott_szo}");
            Console.WriteLine("Üdvözöllek a szójátékban, add meg a neved:");
            string jatek_nev = Console.ReadLine();
            Console.WriteLine($"Jó játékot {jatek_nev}");       

            int elet = 5;
            int pont = 0;
            int jatek = 1;

            while(elet > 0)
            {
                Console.WriteLine("Adj meg egy szót:");
                string bekert_szo = Console.ReadLine();

                if (kivalasztott_szo == bekert_szo)
                {
                    Console.WriteLine("Nyertél!");
                    pont += 1;
                    string kivalasztott;

                    if(JatekFolytat(out kivalasztott))
                    {
                        elet = 5;
                        kivalasztott_szo = kivalasztott;
                        Console.WriteLine($"Kiválasztott szó: {kivalasztott_szo}");
                        jatek += 1;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Nem találtad el, próbáld újra!");
                    elet -= 1;
                    if(elet == 0)
                    {
                        string kivalasztott;
                        if(JatekFolytat(out kivalasztott))
                        {
                            kivalasztott_szo = kivalasztott;
                            elet = 5;
                            Console.WriteLine($"Kiválasztott szó: {kivalasztott_szo}");
                            jatek += 1;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            Console.WriteLine($"A játékos neve: {jatek_nev}");
            Console.WriteLine($"Az elért pontszámod: {pont}");
            Console.WriteLine($"{jatek} kört játszottál.");

            return (jatek_nev, pont, jatek);
        }
        
        

    }
}
