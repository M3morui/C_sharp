using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class SzamlaTulajdonos
    {
        public string tulajdonos_nev;
        public int azonosito;
        public int pinkod;

        public SzamlaTulajdonos(string tulajdonos_nev, int azonosito, int pinkod)
        {
            this.tulajdonos_nev = tulajdonos_nev;
            this.azonosito = azonosito;
            this.pinkod = pinkod;
        }


        public (string, int, int) TulajdonosAdatai()
        {
            string tulajdonos_nev = "";
            int azonosito = 0;
            int pinkod = 0;
            bool sikeres = false;

            while (!sikeres)
            {
                Console.WriteLine("Adja meg a nevét: ");
                tulajdonos_nev = Console.ReadLine();
                if (string.IsNullOrEmpty(tulajdonos_nev))
                {
                    Console.WriteLine("Nem adott meg nevet");
                    continue;
                }
                Console.WriteLine("Adja meg az azonositó számát: ");
                string bekertazonosito = Console.ReadLine();
                if (bekertazonosito.Length != 8 || !int.TryParse(bekertazonosito, out azonosito))

                {
                    Console.WriteLine("8 karaktert adjon meg");
                    continue;
                }

                Console.WriteLine("Adja meg a pinkodot:");
                string bekertpinkod = Console.ReadLine();
                if (bekertpinkod.Length != 4 || !int.TryParse(bekertpinkod, out pinkod))

                {
                    Console.WriteLine("4 karaktert adjon meg");
                    continue;
                }


                sikeres = true;


            }


            return (tulajdonos_nev, azonosito, pinkod);
        }
    }
}
