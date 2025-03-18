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

            while (azonosito == 0 && pinkod == 0)
            {
                Console.WriteLine("Adja meg a nevét: ");
                tulajdonos_nev = Console.ReadLine();
                Console.WriteLine("Adja meg az azonositó számát: ");
                string bekertazonosito = Console.ReadLine();
                Console.WriteLine("Adja meg a pinkodot:");
                string bekertpinkod = Console.ReadLine();
                if (bekertazonosito.Length != 8)
                {
                    Console.WriteLine(" 8 karaktert adjon meg");
                }
                else
                {
                    azonosito = Convert.ToInt32(bekertazonosito);
                }
                if (bekertpinkod.Length != 4)
                {
                    Console.WriteLine("4 karaktert adjon meg");
                }
                else
                {
                    pinkod = Convert.ToInt32(bekertpinkod);

                }


            }



            return (tulajdonos_nev, azonosito, pinkod);
        }
    }
}
