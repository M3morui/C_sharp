using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Szamla
    {
        public (string, decimal) SzamlaLetrehozas()
        {
            Console.WriteLine("Add meg a számla számodat:");
            string szamlaszam = Console.ReadLine();

            Console.WriteLine("Mekkora összeget tennél be:");
            decimal egyenleg = decimal.Parse(Console.ReadLine());

            return (szamlaszam, egyenleg);
        }
    }
}
