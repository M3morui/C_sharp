using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kérjetek be nevet, azonositot(8) és pinkodot(4)
            SzamlaTulajdonos tulajdonos = new SzamlaTulajdonos("", 0, 0);
            var (tulajdonos_nev, azonosito, pinkod) = tulajdonos.TulajdonosAdatai();
            Create.TulajdonosAdatFeltolt(tulajdonos_nev, azonosito, pinkod);
            Console.WriteLine("Sikeres volt az adatfeltöltés.");
            Console.ReadKey();
        }
    }
}
