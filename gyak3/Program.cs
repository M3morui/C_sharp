using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace gyak3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank tulajdonos = new Bank("", 0, 0);
            var(tulajdonos_nev, azonosito, pinkod) = tulajdonos.TulajdonosAdatai();
            Console.WriteLine($"Név: {tulajdonos_nev}, Azonosító: {azonosito}, Pinkód: {pinkod}");



            Console.ReadKey();
        }
    }
}
