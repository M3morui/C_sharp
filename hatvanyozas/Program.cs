using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hatvanyozas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int szam = 1;

            for (int i = 1; i < 32; i++) 
            {
                szam = szam * 2;
                Console.WriteLine(szam);
            }
            */

            /*
            Console.WriteLine("Adj meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            int oszto = 2;
            while (szam > 1) 
            {
                if (szam % oszto == 0) 
                {
                    Console.WriteLine($"{szam} | {oszto}");
                    szam /= oszto;
                }
                else
                {
                    oszto++;
                }
            }
            */

            /*
            List<string> kosar = new List<string>();
            while (true) 
            {
                Console.WriteLine("Milyen gyümölcsöt szeretnél a kosárba tenni?");
                string gyumolcs = Console.ReadLine();
                kosar.Add(gyumolcs);
                if (kosar.Count >= 10)
                {
                    Console.WriteLine("Már 10 db gyümölcs van a kosárban, ha hozzá szeretnéd adni, cseréld le valamelyik gyümölcsöt.");
                    break;
                }           
            }


            Console.WriteLine(string.Join(", ", kosar));
            Console.WriteLine("Melyiket szeretnéd eltávolítani?");
            string ujgyumolcs = Console.ReadLine();
            for (int i = 0; i < kosar.Count; i++)
            {
                if (kosar[i] == ujgyumolcs)
                {
                    Console.WriteLine("Mire cserélnéd le?");
                    string csere = Console.ReadLine();
                    kosar[i] = csere;
                }
            }
            Console.WriteLine(string.Join(", ", kosar));
            */

            string[] kosar = new string[10];
            for (int i = 0; i < kosar.Length; i++)
            {
                Console.WriteLine("Adj meg egy gyümölcsöt");
                string gyumolcs = Console.ReadLine();
                kosar[i] = gyumolcs;
            }
            Console.WriteLine(string.Join(", ",kosar));

            Console.WriteLine("Betelt a kosár, ha újat adnál hozzá, cserélj ki egyet.");
            for (int cs = 0; cs < kosar.Length; cs++) 
            {
                Console.WriteLine("Szeretnél módosítani?");
                string valasz = Console.ReadLine();
                if(valasz == "i")
                {
                    Console.WriteLine("Melyiket cserélnéd le?");
                    string modosit = Console.ReadLine();
                    if (kosar[cs] == modosit)
                    {
                        Console.WriteLine("Mire cserélnéd le?");
                        string csere = Console.ReadLine();
                        kosar[cs] = csere;
                    }
                }
                
            }
            Console.WriteLine(string.Join(", ", kosar));

            Console.ReadKey();

        }
    }
}
