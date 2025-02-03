using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> szamok = new List<int>();
            szamok.Add(1);
            szamok.Add(3);
            szamok.Add(4);
            szamok.Add(2);
            szamok.Add(5);

            szamok.Remove(1);
            //lista elemeinek kiírása
            
            foreach (int item in szamok)
            {
                Console.WriteLine(item);
            }
           
            Console.WriteLine(szamok.Count);

            bool bennevan2 = szamok.Contains(2);
            Console.WriteLine(bennevan2);

            int index3 = szamok.IndexOf(3);
            Console.WriteLine($"A 3-as szám index: {index3}");
            Console.WriteLine(szamok[2]);

            szamok.Sort();
            //szamok.Clear();
            foreach (int item in szamok)
            {
                Console.WriteLine(item);
            }
            */

            /*
            List<string> nevek = new List<string>();
            nevek.Add("Anna");
            nevek.Add("Béla");
            nevek.Add("Cili");

            foreach(string nev in nevek)
            {
                Console.WriteLine(nev);
            }

            
            while(true)
            {
                Console.WriteLine("Adj meg a nevedet: ");
                string nev = Console.ReadLine();
                nevek.Add(nev);

                Console.WriteLine("Szeretnél-e még nevet megadni?(i/n)");
                string valasz = Console.ReadLine();
                if (valasz.Equals("n"))
                {
                    break;
                }
            }

            foreach (string nev in nevek)
            {
                Console.WriteLine(nev);
            }


            Console.WriteLine($"Nevek száma a listában: {nevek.Count}");
            */

            /*
            List<string> termekek = new List<string>();
            while (true)
            {
                Console.WriteLine("Milyen műveletet szeretnél?(Hozzaad, Kosar megtekintese, Torles, Kilepes)");
                string valasztottmuvelet = Console.ReadLine();
                if (valasztottmuvelet.Equals("Hozzaad"))
                {
                    Console.WriteLine("Add meg a terméket: ");
                    string termek = Console.ReadLine();
                    termekek.Add(termek);
                }
                else if (valasztottmuvelet.Equals("Kosar megtekintese"))
                {
                    foreach (string kosar in termekek)
                    {
                        Console.WriteLine(kosar);
                    }
                }
                else if (valasztottmuvelet.Equals("Torles"))
                {
                    Console.WriteLine("Add meg melyik terméket szeretnéd törölni: ");
                    string torles = Console.ReadLine();
                    for (int i = 0; i < termekek.Count; i++)
                    {
                        if (termekek[i] == torles)
                        {
                            termekek.Remove(torles);
                        }
                    }
                }
                else if (valasztottmuvelet.Equals("Kilepes"))
                {
                    Console.WriteLine("Köszönjük a vásárlást.");
                    break;
                }
            }
            */

            /*
            List<int> jegyek = new List<int>();
            int osszeg = 0;
            while(true)
            {
                Console.WriteLine("Megadni, Törölni vagy Átlagot számolni szeretnél(M, T, A)");
                string muvelet = Console.ReadLine();
                if(muvelet == "M")
                {
                    Console.WriteLine("Add meg az érdem jegyeket: ");
                    int jegy = int.Parse(Console.ReadLine());
                    jegyek.Add(jegy);
                }
                else if(muvelet == "T") 
                {
                    Console.WriteLine("Melyik jegyet szeretnéd törölni");
                    int jegytorles = int.Parse(Console.ReadLine());
                    jegyek.Remove(jegytorles);
                }
                else if(muvelet == "A")
                {
                    foreach(int atlag in jegyek)
                    {
                        osszeg += atlag;                    
                    }
                    Console.WriteLine($"A jegyek átlaga: {osszeg / jegyek.Count}");
                }
                else
                {
                    Console.WriteLine("A mművelet bejeződött.");
                    break;
                }
            }
            */

            List<int> arak = new List<int>();
            int osszeg = 0;
            while(true)
            {
                Console.WriteLine("Hozzáad, Törölni, Összegezni, Lista kiírása vagy Befejezni(H, T, Ö, L, B)");
                string muvelet = Console.ReadLine();
                if(muvelet == "H")
                {
                    Console.WriteLine("Adj meg árakat: ");
                    int ar = int.Parse(Console.ReadLine());
                    arak.Add(ar);
                }
                else if(muvelet == "T")
                {
                    Console.WriteLine("Melyik árat szeretnéd törölni: ");
                    int artorles = int.Parse(Console.ReadLine());
                    arak.Remove(artorles);                
                }
                else if(muvelet == "Ö")
                {
                    foreach(int osszegzes in arak)
                    {
                        osszeg += osszegzes;
                    }
                    Console.WriteLine($"Az árak összege: {osszeg}");

                }
                else if(muvelet == "L")
                {
                    foreach(int kosar in arak)
                    {
                        Console.WriteLine($"A lista tartalma: {kosar}");
                    }
                }
                else if(muvelet == "B")
                {
                    Console.WriteLine("A művelet véget ért.");
                    break;
                }
            }
            


            Console.ReadKey();
        }
    }
}
