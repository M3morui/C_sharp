using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak3
{
    internal class Bank
    {
        public string tulajdonos_nev;
        public int azonosito;
        public int pinkod;
        public Bank(string tulajdonos_nev, int azonosito, int pinkod)
        {
            this.tulajdonos_nev = tulajdonos_nev;
            this.azonosito = azonosito;
            this.pinkod = pinkod;
        }

        public (string, int, int) TulajdonosAdatai()
        {
            Console.WriteLine("Adja meg a nevét");
            string tulajdonos_nev = Console.ReadLine();
            Console.WriteLine("Adja meg az azonosító számát");
            int azonosito = int.Parse(Console.ReadLine());
            Console.WriteLine("Adja meg a pinkódját");
            int pinkod = int.Parse(Console.ReadLine());

            return (tulajdonos_nev, azonosito, pinkod);
        }
    }
}
