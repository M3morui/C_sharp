using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace nyaralas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Nyaralas> nyaralasok = new List<Nyaralas>();
            string[] sorok = File.ReadAllLines("nyaralas.txt");
            foreach (var sor in sorok)
            {
                string[] adatok = sor.Split(',');
                Nyaralas uj = new Nyaralas (adatok[0], adatok[1], adatok[2], adatok[3], adatok[4], adatok[5], adatok[6]);
                nyaralasok.Add (uj);
            }
            foreach (var item in nyaralasok)
            {
                Console.WriteLine($"{item.sorszam}, {item.nev}, {item.szallas}, {item.foglalas}, {item.napszam}, {item.ar}, {item.kedvezmeny}");
            }




            Console.ReadKey();
        }
    }
}
