using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uj
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*
            int[] szamok = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine(szamok[0]);

            szamok[0] = 22;
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine(szamok[i]);
            }

            string[] nevek = { "John", "Sherlock", "Hudson" };
            foreach (string n in nevek)
            {
                Console.WriteLine(n);
            }
            */

            /*
            int osszeg = 0;
            int[] jegyek = { 1, 1, 3, 3, 5, 4, 3, 4, 3, 5, 2, 2, 4 };
            for (int n= 0; n < jegyek.Length; n++)
            {
                osszeg += jegyek[n];   
            }
            int atlag = osszeg / jegyek.Length;
            Console.WriteLine($"A jegyek átlaga: {atlag}");


            int[] szamok = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int legkisebb = int.MaxValue;
            int legnagyobb = int.MinValue;

            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] < legkisebb)
                {
                    legkisebb = szamok[1];
                }

                else if (szamok[i] > legnagyobb)
                {
                    legnagyobb = szamok[i];
                }
            }

            Console.WriteLine($"A legkisebb szám: {legkisebb}");
            Console.WriteLine($"A legnagyobb szám: {legnagyobb}");
            */

            /*
            Console.WriteLine("Adj meg az elvetett búza mennyiségét tonnában:");
            int mennyiseg = int.Parse(Console.ReadLine());
            var rand = new Random();
            int hozam = rand.Next(5, 15);

            if (hozam >= 5 && hozam <= 8)
            {
                Console.WriteLine($"A mennyiség: {mennyiseg*hozam}");
                Console.WriteLine($"Átlag alatti év, a hozam: {hozam}.");
            }
            else if (hozam >= 9 && hozam >= 12) 
            {
                Console.WriteLine($"A mennyiség: {mennyiseg * hozam}");
                Console.WriteLine($"Átlagos év, a hozam: {hozam}");
            }
            else if (hozam >= 13 && hozam >= 15)
            {
                Console.WriteLine($"A mennyiség: {mennyiseg * hozam}");
                Console.WriteLine($"Átlag feletti év,a hozam: {hozam}");
            }
            */

            /*
            int[] tomb = { 10, 2, 3, 4, 5, 6, 7};
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }

            foreach (int item in tomb)
            {
                Console.WriteLine(item);
            }

            int[] atlag = { 3, 5, 8, 10 };
            int osszeg = 0;
            for (int n = 0; n < atlag.Length; n++)
            {
                osszeg += atlag[n];
            }
            int atlagos = osszeg / atlag.Length;
            Console.WriteLine($"A jegyek átlaga: {atlagos}, Összeg: {osszeg}");
            */

            /*
            int[] lnlk = { 12, 5, 8, 20, 3 };
            int legkisebb = int.MaxValue;
            int legnagyobb = int.MinValue;

            for (int i = 0; i < lnlk.Length; i++)
            {
                if (lnlk[i] < legkisebb)
                {
                    legkisebb = lnlk[i];
                }

                else if (lnlk[i] > legnagyobb)
                {
                    legnagyobb = lnlk[i];
                }
            }
            Console.WriteLine($"A legkisebb szám: {legkisebb}");
            Console.WriteLine($"A legnagyobb szám: {legnagyobb}");
            */

            int db = 0;
            int[] paroszsamok = { 1, 2, 3, 4, 5, 6, 7, 8};
            for(int i = 0; i < paroszsamok.Length; i++)
            {
                if (paroszsamok[i] % 2 == 0)
                {
                    db += 1;
                }
            }
            Console.WriteLine($"Páros számok: {db}");
            Array.Reverse(paroszsamok);
            for(int i = 0;i < paroszsamok.Length;i++)
            {
                Console.WriteLine(paroszsamok[i]);
            }

            int indexsz = 0;
            Console.WriteLine("Adj meg egy négyest: ");
            int bekertnegy = int.Parse(Console.ReadLine());
            for(int f = 0; f < paroszsamok.Length; f++)
            {
                if(bekertnegy == paroszsamok[f])
                {
                    indexsz = Array.IndexOf(paroszsamok, bekertnegy);                   
                }
            }
            Console.WriteLine($"A megadott szám indexe: {indexsz}, a megadott szám: {bekertnegy}");

            Console.ReadKey();
        }
    }
}
