using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uj
{
    internal class Program
    {

        public struct ember
        {
            public string keresztnev;
            public string vezeteknev;
            public int kor;
        }
        static void Main(string[] args)
        {
            ember Adat = new ember();
            ember[] Adatok = new ember[3];

            for(int i = 0; i<Adatok.Length; i++)
            {
                Adatok[0].vezeteknev = "Próba";
                Adatok[0].keresztnev = "Elek";
                Adatok[0].kor = 34;
                Adatok[1].vezeteknev = "Kis";
                Adatok[1].keresztnev = "János";
                Adatok[1].kor = 50;
                Adatok[2].vezeteknev = "Jane";
                Adatok[2].keresztnev = "Asd";
                Adatok[2].kor = 23;
            }

            int legidosebb = int.MinValue;
            string legidosebbszemely = "";
            for(int i = 0; i < Adatok.Length; i++)
            {
                Console.WriteLine($"{Adatok[i].vezeteknev} {Adatok[i].keresztnev} {Adatok[i].kor} éves.");
                if (Adatok[i].kor > legidosebb)
                {
                    legidosebb = Adatok[i].kor;
                    legidosebbszemely = Adatok[i].keresztnev;
                }
            }
            Console.WriteLine($"Legidősebb személy: {legidosebbszemely} {legidosebb}");

            /*
            Adat.keresztnev = "John";
            Adat.vezeteknev = "Watson";
            Adat.kor = 40;
            Console.WriteLine($"A személy: {Adat.keresztnev} {Adat.vezeteknev} {Adat.kor}");
            */

            /*
            try
            {
                Console.WriteLine("Adj meg egy számot: ");
                int szam = int.Parse(Console.ReadLine());
                Console.WriteLine($"Ez a számot adtad meg: {szam}");
            }

            catch (Exception e)
            {
                Console.WriteLine("Nem számot adtál meg.");
            }
            */


            Console.ReadKey();
        }
        
    }
}
