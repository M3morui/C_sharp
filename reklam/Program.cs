using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace reklam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Reklam> reklamok = new List<Reklam>();
            string[] sorok = File.ReadAllLines("rendel.txt");
            foreach(var item in sorok)
            {
                string[] adatok = item.Split(' ');
                Reklam uj = new Reklam(adatok[0], adatok[1], adatok[2]);
                reklamok.Add(uj);
            }

            /*
            foreach(var item in reklamok)
            {
                Console.WriteLine($"{item.rendelesnap}, {item.varos}, {item.rendeltdb}");
            }
            */

            Console.WriteLine("Kérem adjon meg egy napot: ");
            int megadottnap = int.Parse(Console.ReadLine());
            int rendeles = 0;
            int legnagyobbdb = 0;
            int legnagyobbrendeles = 0;
            foreach(var item in reklamok)
            {
                if(item.rendelesnap == megadottnap)
                {
                    rendeles++;
                }
                if(item.rendeltdb > legnagyobbdb)
                {
                    legnagyobbdb = item.rendeltdb;
                    legnagyobbrendeles = item.rendelesnap;
                }
            }

            int megszamol = 30;
            List<int> keresNR = new List<int>();
            foreach(var item in reklamok)
            {
                if(item.varos == "NR" && !keresNR.Contains(item.rendelesnap))
                {
                    keresNR.Add(item.rendelesnap);
                }
            }

            for(int i = 1; i< 30; i++)
            {
                foreach(var keres in keresNR)
                {
                    if(i== keres)
                    {
                        megszamol--;
                    }
                }
            }





            Console.WriteLine("2.feladat");
            Console.WriteLine($"A rendelések száma: {reklamok.Count}");
            Console.WriteLine("3.feladat");
            Console.WriteLine($"A rendelések száma egy adott napok: {rendeles}");
            Console.WriteLine("4.feladat");
            if (megszamol != 0)
            {
                Console.WriteLine($"{megszamol} nap nem volt a reklámban nem érintett városból rendelés");
            }
            else
            {
                Console.WriteLine("Minden nap volt rendelés");
            }
            Console.WriteLine("5.feladat");
            Console.WriteLine($"{legnagyobbdb} {legnagyobbrendeles}");




            Console.ReadKey();
        }
    }
}
