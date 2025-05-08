using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fajlgyak2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Loverseny> loversenyek = new List<Loverseny>();
            string[] sorok = File.ReadAllLines("lverseny.txt");
            foreach(string s in sorok)
            {
                string[] adat = s.Split(';');
                Loverseny lverseny = new Loverseny(adat[0], adat[1], adat[2], adat[3], adat[4]);
                loversenyek.Add(lverseny);
            }
            int ossz = 0;
            foreach(var verseny in loversenyek)
            {
                Console.WriteLine($"{verseny.zsoke}, {verseny.lonev}, {verseny.nyert}, {verseny.nyeremeny}, {verseny.helyezes}");
                ossz += verseny.nyeremeny;
            }
            Console.WriteLine($"A nyeremények összege: {ossz}");


            Console.ReadKey();
        }
    }
}
