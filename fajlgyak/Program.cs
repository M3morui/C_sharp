using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace uj
{
    internal class Program
    {

        public struct tanulok
        {
            public int id;
            public string nev;
            public string osztaly;
            public int kor;
            public string tantargy;
        }

        public static List<tanulok> adatok = new List <tanulok> ();

        static void Main(string[] args)
        {
            FileStream f = new FileStream("diakok.txt", FileMode.Open);
            StreamReader sr = new StreamReader(f, Encoding.UTF8);
            tanulok aktualis = new tanulok();
            while (!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split(',');
                aktualis.id = Convert.ToInt32(sor[0]);
                aktualis.nev = sor[1];
                aktualis.osztaly = sor[2];
                aktualis.kor = Convert.ToInt32(sor[3]);
                aktualis.tantargy = sor[4];
                adatok.Add(aktualis);
            }

            sr.Close();
            f.Close();

            for (int i = 0; i < adatok.Count; i++)
            {
                Console.WriteLine($"{adatok[i].id} {adatok[i].nev} {adatok[i].osztaly} {adatok[i].kor} {adatok[i].tantargy}");
            }

            FileStream f2 = new FileStream("adatok_2.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(f2, Encoding.UTF8);

            Console.WriteLine("Adj meg egy id-t");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adj meg egy nevet");
            string nev = Console.ReadLine();
            Console.WriteLine("Adj meg egy osztályt");
            string osztaly = Console.ReadLine();
            Console.WriteLine("Adj meg az életkort");
            int kor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adj meg az életkort");
            string tantargy = Console.ReadLine();

            adatok.Add(new tanulok { azonosito = id, fullnev = nev, eletkor = kor, targy = tantargy });

            for (int w = 0; w < adatok.Count; w++)
            {
                sw.WriteLine($"{adatok[w].id} {adatok[w].nev} {adatok[w].osztaly} {adatok[w].kor} {adatok[w].tantargy}");
            }

            for (int k = 0; k < adatok.Count; k++)
            {
                Console.WriteLine($"{adatok[k].id} {adatok[k].nev} {adatok[k].osztaly} {adatok[k].kor} {adatok[k].tantargy}");
            }

            sw.Close();
            f2.Close();


            Console.ReadKey(); 
        }
    }
}
