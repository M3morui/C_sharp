using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Milyen ahngot ad ki a kutyád?");
            string hang = Console.ReadLine();
            kutya k1 = new kutya("John", 3, "fekete", hang);
            Console.WriteLine(k1.KutyaKiir());
            Console.WriteLine(k1.KutyaHang());
            Console.WriteLine(k1.Kutyaszul());
            kutya k2 = new kutya("Blöki", 5, "fehér", hang);
            Console.WriteLine(k2.KutyaKiir());
            Console.WriteLine(k2.KutyaHang());
            Console.WriteLine(k2.Kutyaszul());
            */

            /*
            farkas f1 = new farkas("Warwick", "jungel", 54, "Zaun");
            Console.WriteLine(f1.FarkasKiir());
            List<farkas> farkasok = new List<farkas>();
            while (farkasok.Count != 3) 
            {
                Console.WriteLine("Mi a farkas neve?");
                string nev = Console.ReadLine();
                Console.WriteLine("Mi a típusa?");
                string tipus = Console.ReadLine();
                Console.WriteLine("Hány éves?");
                int kor = int.Parse(Console.ReadLine());
                Console.WriteLine("Hol jelent meg a farkas?");
                string mitosz = Console.ReadLine();

                farkas ujFarkas = new farkas(nev, tipus, kor, mitosz);
                farkasok.Add(ujFarkas);
            }

            foreach (var item in farkasok) 
            {
                Console.WriteLine($"{item.nev}, {item.tipus}, {item.kor}, {item.mitosz}");
            }
            */

            List<Dolgozok> dolgozok_adatai = new List<Dolgozok>();

            while (dolgozok_adatai.Count != 4) 
            {
                Console.WriteLine("A dolgozó vezetékneve: ");
                string veznev = Console.ReadLine();
                Console.WriteLine("A dolgozü keresztneve: ");
                string keznev = Console.ReadLine();
                Console.WriteLine("Születesi dátuma:");
                string szuldatum = Console.ReadLine();
                var szulev = DateTime.Parse(szuldatum);
                Console.WriteLine("A dolgozó beosztása:");
                string beosztas = Console.ReadLine();
                Console.WriteLine("Belépés éve:");
                int csatlakoz = int.Parse(Console.ReadLine());
                Console.WriteLine("Havi óraszáma:");
                int oraszam = int.Parse(Console.ReadLine());

                Dolgozok ujdolg = new Dolgozok(veznev, keznev, szulev, beosztas, csatlakoz, oraszam);
                dolgozok_adatai.Add(ujdolg);
            }

            List<int> csatlakozas = new List<int>();
            foreach (var item in dolgozok_adatai) 
            {
                Console.WriteLine($"{item.veznev} {item.keznev}, {item.szulev}, {item.beosztas}, {item.csatlakoz}, {item.oraszam}");
                csatlakozas.Add(item.csatlakoz);
                
            }
            Console.WriteLine($"A legrébben belépett dolgozó: {csatlakozas.Min()}");


            Console.ReadKey();
        }
    }
}
