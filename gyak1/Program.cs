using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("1.Feladat");
            Console.WriteLine("Adj meg egy időpontot 1-24 óra között:");
            int ora = int.Parse(Console.ReadLine());

            if (ora >= 1 && ora <= 8)
            {
                Console.WriteLine("Jó Reggelt!");
            }
            else if(ora >= 9 && ora <= 18)
            {
                Console.WriteLine("Jó Napot!");
            }
            else if(ora >= 19 && ora <= 24)
            {
                Console.WriteLine("Jó Estét!");
            }
            else
            {
                Console.WriteLine("Nem megfelelő adat.");
            }
            */

            /*
            Console.WriteLine("2.Feladat");
            int osszeg = 0;
            int[] tomb = { 1, 2, 3, 4, 5, 6 };
            for (int i=0; i<tomb.Length; i++)
            {
                tomb[i] += 2;
                Console.WriteLine(tomb[i]);
                // Console.WriteLine($"indexek: {i}");
            }
            foreach (var item in tomb)
            {
                osszeg += item;
                
            }
            Console.WriteLine($"foreach-al {osszeg}");
            */

            /*
            Console.WriteLine("3.Feladat");
            Random rnd = new Random();
            int[] idojaraselorejelzes = new int[30];
            for(int i=0; i< idojaraselorejelzes.Length; i++)
            {
                idojaraselorejelzes[i] = rnd.Next(-5, 36);
            }
            foreach (var item in idojaraselorejelzes)
            {
                Console.WriteLine(item);
            }

            int hideg = int.MaxValue;
            int meleg = int.MinValue;
            int harmincfelett = 0;
            int osszeg = 0;
            for(int i = 0; i < idojaraselorejelzes.Length; i++)
            {
                osszeg += idojaraselorejelzes[i];
                if (idojaraselorejelzes[i] < hideg)
                {
                    hideg = idojaraselorejelzes[i];

                }
                else if (idojaraselorejelzes[i] > meleg)
                {
                    meleg = idojaraselorejelzes[i];
                }
                if (idojaraselorejelzes[i] > 30)
                {
                    harmincfelett++;
                }
            }
            int leghidegebb = idojaraselorejelzes.Min();
            int legmelegebb = idojaraselorejelzes.Max();
            Console.WriteLine($"A leghidegebb hőmérséklet: {hideg}, A legmelegebb hőmérséklet: {meleg}");
            Console.WriteLine($"A leghidegebb: {leghidegebb}, A legmelegebb: {legmelegebb}");
            Console.WriteLine($"Ennyiszer volt 30 C felett a hőmérséklet: {harmincfelett}");
            Console.WriteLine($"Az átlag hőmérséklet: {osszeg/idojaraselorejelzes.Length}");
            */

            int[] arak = { 2500, 4990, 1500, 8990, 3490 };
            int osszeg = 0;
            for (int i = 0; i < arak.Length; i++)
            {
                osszeg += arak[i];
                
            }
            int legolcso = arak.Min();
            int legdraga = arak.Max();
            Console.WriteLine($"A teljes összeg: {osszeg}");
            Console.WriteLine($"A legolcsóbb ár: {legolcso}");
            Console.WriteLine($"A legdrágább ár: {legdraga}");

            Console.ReadKey();
        }
    }
}
