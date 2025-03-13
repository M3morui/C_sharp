using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace fajlgyak1
{
    internal class Program
    {
        public struct jatekosok
        {
            public string nev;
            public int pont;
            public string jateknev;
            public int meccsek;
        }

        public static List<jatekosok> jatekos_eredmenyek = new List<jatekosok>();
        static void Main(string[] args)
        {
            FileStream f = new FileStream("jatek.txt", FileMode.Open);
            StreamReader sr = new StreamReader(f, Encoding.UTF8);
            jatekosok aktualis = new jatekosok();
            
            while(!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split(' ');
                aktualis.nev = sor[0];
                aktualis.pont = Convert.ToInt32(sor[1]);
                aktualis.jateknev = sor[2];
                aktualis.meccsek = Convert.ToInt32(sor[3]);
                jatekos_eredmenyek.Add( aktualis );
            }

            foreach(var item in jatekos_eredmenyek)
            {
                Console.WriteLine($"A játékos neve: {item.nev}, pontszám: {item.pont}, játéknév: {item.jateknev}, meccsek: {item.meccsek}");
            }
            f.Close();

            sr.Close();

            //fájlba kiír

            while(true)
            {
                
                Console.WriteLine("Add meg a neved: ");
                string n = Console.ReadLine();
                Console.WriteLine("Add meg a pontszámod: ");
                int p = int.Parse(Console.ReadLine());
                Console.WriteLine("Add meg a játék nevét: ");
                string jn = Console.ReadLine();
                Console.WriteLine("Add meg a meccsek számát: ");
                int m = int.Parse(Console.ReadLine());

                jatekos_eredmenyek.Add(new jatekosok { nev = n, pont = p, jateknev = jn,  meccsek = m}) ;
                FileStream f2 = new FileStream("eredmenyek.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(f2);

                for (int e = 0; e < jatekos_eredmenyek.Count; e++)
                {
                    sw.WriteLine($"{jatekos_eredmenyek[e].nev} {jatekos_eredmenyek[e].pont} {jatekos_eredmenyek[e].jateknev} {jatekos_eredmenyek[e].meccsek}");
                }

                sw.Close();
                f2.Close();

                Console.WriteLine("Szeretnéd folytatni?(i/n)");
                string folytat = Console.ReadLine();
                if(folytat == "n")
                {
                    break;
                }         

                
            }

            
            
            Console.WriteLine($"Az adatok a listához adva");
            



            Console.ReadKey();
        }
    }
}
