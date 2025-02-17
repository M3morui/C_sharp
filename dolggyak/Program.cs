using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace dolggyak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1 feladat
             32db véletlen szám 1-50 között, páros vagy páratlan,
             listához csak páratlan számok kerüljenek
             írjuk ki a tartalmát vesszővel elválasztva
             írjuk ki a lista hosszát is
            */
            /*
            var rnd = new Random();
            List<int> paratlan = new List<int>();
            while(paratlan.Count < 32)
            {
                int szam = rnd.Next(1, 50);
                if(szam % 2 == 0)
                {
                    Console.WriteLine($"A szám páros {szam}.");
                }
                else
                {
                    Console.WriteLine($"A szám páratlan {szam}.");
                    paratlan.Add(szam);
                }
            }
            Console.WriteLine(string.Join(",", paratlan));
            Console.WriteLine($"A lista hossza: {paratlan.Count}");
            */

            /*2 feladat
             szamok nevű lista, kérj be 7db számot
             növeljük meg a bekért számok kettővel
             ha nagfyobb mint 20 és kisebb mint 100 akkor adjuk hozzá a listához
             számoljuk ki hanyadik szám lett a listához adva
             írjuk ki a lista hosszát*/

            /*
            List<int> szamok = new List<int>(); 
            int db = 0;
            for(int i = 0; i < 7; i++)
            {
                Console.WriteLine("Adj meg egy számot:");
                int szam = int.Parse(Console.ReadLine());
                int megnovelt = szam + 2;
                if(megnovelt > 20 && megnovelt < 100)
                {
                    szamok.Add(megnovelt);
                    db++;
                    Console.WriteLine($"{db} szám lett a listához adva.");
                }
                else
                {
                    Console.WriteLine("A szám nem lett a listához adva.");
                }
            }
            Console.WriteLine($"A lista hossza: {szamok.Count}");
            */

            /*3 feladat
             5 elemű tömb, adunk hozzá 5 tantárgyat
             írjuk ki h van e benne informatoka
             ha nincs írjuk ki h nincs
             ha van írjuk ki h va
             írjuk ki h milyen tantárgyak vannak a tömbben*/

            /*
            string[] tantargyak = { "Ének", "Matek", "Angol", "Német", "Történelem" };
            if (tantargyak.Contains("Informatika"))
            {
                Console.WriteLine("Benne van a tömbben az informatika tantárgy.");
            }
            else
            {
                Console.WriteLine("Nincs benne a tömbben az informatika tantárgy.");
            }
            Console.WriteLine(string.Join(",", tantargyak));
            */

            /*
            string[] tantargyak = new string[5];
            for(int i = 0; i< tantargyak.Length; i++)
            {
                Console.WriteLine("Adj meg egy tantárgyat");
                string targy = Console.ReadLine();
                tantargyak[i] = targy;
            }
            if (tantargyak.Contains("Informatika"))
            {
                Console.WriteLine("Benne van a tömbben az informatika tantárgy.");
            }
            else
            {
                Console.WriteLine("Nincs benne a tömbben az informatika tantárgy.");
            }
            Console.WriteLine(string.Join(",", tantargyak));
            */

            /*4 feladat
             benne van e az Anna név
             ha van cseréljük le Katára
             írjuk ki a tömb tartalmát vesszővel elválasztva*/
            /*
            string[] nevek = { "Anna", "Elemér", "Béla", "John", "Jenna", "Kinga" };
            for (int i = 0; i < nevek.Length; i++)
            {
                if (nevek.Contains("Anna"))
                {
                    nevek[i] = "Kata";
                }
            }
            
            Console.WriteLine(string.Join(", ",nevek));
            */


            /*5 feladat
             rendezd sorba
             legkisebb és legnagyobb szám*/

            /*
            List<int> rendezett = new List<int>();
            while (true) 
            {
                Console.WriteLine("Adj meg számokat: ");
                int szam = int.Parse(Console.ReadLine());
                rendezett.Add(szam);

                if(szam == 0)
                {
                    break;
                }
                
            }
            rendezett.Sort();
            Console.WriteLine(string.Join(";",rendezett));
            Console.WriteLine($"A legkisebb szám: {rendezett.Min()}");
            Console.WriteLine($"A legnagyobb szám: {rendezett.Max()}");
            */

            /*6 feladat
             lista kérj be számokat
             legalább 8 szám kell
             felhasználó bármikor kiléphet
             legnagyobb elem
             legnagyobb + 2 és cseréld le erre a számra
             rendezd csökkenő sorrendbe a listat és írd ki*/

            /*
            List<int> szamok = new List<int>();
            while(true)
            {
                Console.WriteLine("Adj meg számokat: ");
                int szam = int.Parse(Console.ReadLine());
                szamok.Add(szam);

                if(szamok.Count > 8)
                {
                    Console.WriteLine("Szeretnéd még folytatni(i/n):");
                    string folytat = Console.ReadLine();
                    if(folytat == "n")
                    {
                        break;
                    }
                }
            }

            int legnagyobb = szamok.Max();
            Console.WriteLine($"A legnagyobb szám : {legnagyobb}");
            for(int i = 0; i < szamok.Count; i++)
            {
                if (szamok[i] == legnagyobb) 
                {
                    legnagyobb += 2;
                    szamok[i] = legnagyobb;
                }
            }


            szamok.Sort();
            szamok.Reverse();
            Console.WriteLine(string.Join("; ",szamok));
            */

            /*7 feladat
             ird ki a cortado kávé hanyas indexen van*/

            /*
            string[] kave = {"Espresso", "Americano", "Latte", "Cappucino",
                "Macchiato", "Flat White", "Mocha", "Affogato", "Cortado", "Ristretto"};

            int index = Array.IndexOf(kave, "Cortado");
            Console.WriteLine($"A Cortado kávé a {index}. indexen van.");
            */

            /*8 feladat
             kérj be egy számot
             benne van e a tömbben ha igen írd ki és h melyik indexen van
             ha nincs ird ki h nincs bene*/

            /*
            int[] szamok = { 5, 10, 15, 20, 25, 30 };
            Console.WriteLine("Adj meg egy számot:");
            int szam = int.Parse(Console.ReadLine());
            if (szamok.Contains(szam))
            {
                int index = Array.IndexOf(szamok, szam);
                Console.WriteLine($"A szám a {index}. indexen van.");
            }
            else
            {
                Console.WriteLine("Nincs ilyen szám a tömbben.");
            }
            */

            /*9 feladat
             lista
             kérj be számot és számold meg melyik indexen vannak
             ha egy szám többször is szerepel ird ki az indexeket*/

            List<int> indexek = new List<int>();
            List<int> szamok = new List<int> { 5, 12, 7, 20, 12, 30, 12, 40, 70, 45, 12, 21, 34, 78};
            Console.WriteLine("Adj meg egy számot");
            int bekertszam = int.Parse(Console.ReadLine());
            for (int i = 0; i < szamok.Count; i++)
            {
                if(szamok[i] == bekertszam)
                {
                    indexek.Add(i);
                }
            }
            Console.WriteLine($"A megadott szám indexei: {string.Join(";",indexek)}");

            Console.ReadKey();
        }
    }
}
