using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace doga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 feladat
            /*
            string[] tomb = {"pizza","lasagne","palacsinta","gyros","paradicsomleves"};
            if (tomb.Contains("pizza"))
            {
                Console.WriteLine("A tömben van pizza");
            }
            else
            {
                Console.WriteLine("Nincs");
            }
            Console.WriteLine(string.Join(",",tomb));
            */

            //2 feladat
            /*
            string[] nevek = { "The Witcher 3: Wild Hunt", "Minecraft", "Cyberpunk 2077", "Among Us", "The Elder Scrolls V: Skyrim", "Valorant" };
            for(int i = 0; i < nevek.Length; i++)
            {
                if (nevek[i] == "Valorant")
                {
                    nevek[i] = "Fortnite";
                }
            }
            Console.WriteLine(string.Join(";",nevek));
            */

            //3 feladat
            /*
            List<int> szamok = new List<int>();
            while (true) 
            {
                Console.WriteLine("Adj meg számot:");
                int szam = int.Parse(Console.ReadLine());
                szamok.Add(szam);

                if(szam == 0)
                {
                    break;
                }
            }

            szamok.Sort();
            szamok.Reverse();
            Console.WriteLine(string.Join(",",szamok));
            Console.WriteLine($"A legnagyobb szám: {szamok.Max()}");
            */

            //4 feladat
            List<int> paros = new List<int>();
            while (paros.Count < 5) 
            {
                Console.WriteLine("Adj meg egy számot:");
                int szam = int.Parse(Console.ReadLine());
                Console.WriteLine(szam);

                if(szam % 2 == 0)
                {
                    paros.Add(szam);
                    Console.WriteLine($"A szám páros {szam}.");
                    Console.WriteLine($"Listához adva: {paros.Count} lett.");
                    
                }
                else
                {
                    Console.WriteLine($"A szám páratlan {szam}.");
                }
            }

            Console.WriteLine($"A lista hossza: {paros.Count}");


        Console.ReadKey();
        }
    }
}
