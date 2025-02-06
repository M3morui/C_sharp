using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace uj2
{
    internal class Program
    {
        public struct ember
        {
            public string keresztnev;
            public string vezeteknev;
            public int eletkor;
        }

        public static List<ember> adatok = new List<ember>();

        static void Main(string[] args)
        {
            //fájl beolvasas

            FileStream f = new FileStream("adatok.txt", FileMode.Open);
            StreamReader sr = new StreamReader(f, Encoding.UTF8);
            ember aktualis = new ember();
            while (!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split(' ');
                aktualis.vezeteknev = sor[0];
                aktualis.keresztnev = sor[1];
                aktualis.eletkor = Convert.ToInt32(sor[2]);
                adatok.Add(aktualis);
            }

            sr.Close();
            f.Close();

            for (int i = 0; i < adatok.Count; i++)
            {
                Console.WriteLine($"{adatok[i].vezeteknev} {adatok[i].keresztnev} {adatok[i].eletkor}");
            }

            int listahossz = adatok.Count();
            Console.WriteLine($"A lista hossza: {listahossz}");



            /*
            //fájl kiírás
            FileStream f2 = new FileStream("adatok_2.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(f2, Encoding.UTF8);

            Console.WriteLine("Adj meg egy vezeték nevet");
            string veznev = Console.ReadLine();
            Console.WriteLine("Adj meg egy kereszt nevet");
            string kernev = Console.ReadLine();
            Console.WriteLine("Adj meg egy életkort");
            int kor = Convert.ToInt32(Console.ReadLine());
            adatok.Add(new ember { vezeteknev = veznev, keresztnev = kernev, eletkor = kor });

            for(int w = 0; w < adatok.Count; w++)
            {
                sw.WriteLine($"{adatok[w].vezeteknev} {adatok[w].keresztnev} {adatok[w].eletkor}");
            }

            for(int k = 0; k < adatok.Count; k++)
            {
                Console.WriteLine($"{adatok[k].vezeteknev} {adatok[k].keresztnev} {adatok[k].eletkor}");
            }

            Console.WriteLine($"{veznev} {kernev} {kor}");

            sw.Close();
            f2.Close();
            */

            Console.ReadKey();
        }
    }

}