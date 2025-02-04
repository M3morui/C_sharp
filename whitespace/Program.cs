using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whitespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string szoveg = "Hello\tVilág";
            Console.WriteLine(szoveg);
            */

            /*
            var rand = new Random();
            string szoveg2 = "Hello\nVilág\nC#";
            Console.WriteLine(szoveg2);

            string szoveg3 = "Ez egy \"idézet\" és ez egy \"másik\" idézet";
            Console.WriteLine(szoveg3);

            string szoveg4 = "Hello\b World";
            Console.WriteLine(szoveg4);

            int[] pontok = new int[10];
            int[] eredmeny = { 10, 34, 54, 23 };

            for(int i = 0; i < pontok.Length; i++) 
            {
                pontok[i] = rand.Next(100, 200);
            }
            foreach(var item in pontok)
            {
                Console.WriteLine(item);
            }
            */

            /*
            List<string> orszagok = new List<string>();
            while(true) 
            {
                Console.WriteLine("Adj meg egy országot: ");
                string orszag = Console.ReadLine();
                orszagok.Add(orszag);

                Console.WriteLine("Szeretnél-e még országot megadni?(i/n)");
                string valasz = Console.ReadLine();
                if (valasz.Equals("n"))
                {
                    break;
                }

            }
            foreach (string o in orszagok)
            {
                Console.WriteLine(o);
            };
            */

            var rnd = new Random();
            int db = 0;
            List<int> szamok = new List<int>();
            while (szamok.Count < 12)
            {
                int szam = rnd.Next(1, 100);
                szamok.Add(szam);
            }

            for (int i = 0; i < szamok.Count; i++)
            {
                if (szamok[i] % 2 == 0)
                {
                    szamok.Remove(szamok[i]);
                }
            }
            for(int sz = 0; sz < szamok.Count; sz++)
            {
                if (szamok[sz] > 20)
                {
                    db++;
                }
            }

            Console.WriteLine($"Ennyi 20-nál nagyobb szám van a listában: {db}");
            foreach(var item in szamok)
            {
                Console.WriteLine(item);
            }





            Console.ReadKey();
        }
    }
}
