using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bevezetés
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello world");
            /*
            string udvozles = "Hello ,Világ!";

            int szam = 10;
            Console.WriteLine($"A változóban eltárolt szám: {szam}");
            string szo = "alma";
            Console.WriteLine(szam + " " + szo);
            bool igaz = true;
            Console.WriteLine(igaz);
            double szam1 = 2.14;
            Console.WriteLine(szam1);

            int szohossza = szo.Length; //int kell mert szám értéket fogunk meg kapni
            Console.WriteLine($"A szó hossza {szohossza}");

            string fistName = "John";
            string lastName = "Watson";
            Console.WriteLine(fistName + " " + lastName);

            string formation = string.Format("Az ő neve {0} {1}", fistName, lastName);
            Console.WriteLine(formation);

            string substring = szo.Substring(2, 2);
            Console.WriteLine(substring);

            int indexeles = udvozles.IndexOf("World");
            Console.WriteLine(indexeles);

            char betu = 'A';
            Console.WriteLine(betu);

            int number1 = 10;
            int number2 = 20;
            int kivonas = number2 - number1;
            Console.WriteLine($"A kivonás: {kivonas}");
            int osszead = number1 + number2;
            Console.WriteLine($"Az osszeadás: {osszead}");
            int osztas = number2 / number1;
            Console.WriteLine($"Az osztás: {osztas}");
            int szorzas = number2 * number1;
            Console.WriteLine($"A szorzás: {szorzas}");
            int maradekos = number2 % number1;
            Console.WriteLine($"A maradékos osztás: {maradekos}");

            char elsokarakter = szo[0];
            Console.WriteLine(elsokarakter);
            char utolsokarakter = szo[szo.Length - 2];
            Console.WriteLine(utolsokarakter);

            string nagybetus = udvozles.ToUpper();
            Console.WriteLine(nagybetus);
            string nagy = "HELLO"; 
            string kisbetus = nagy.ToLower();
            Console.WriteLine(kisbetus);

            string csere = udvozles.Replace("Világ", "C#");
            Console.WriteLine(csere);

            float lebegopontos = 2.5F;
            Console.WriteLine(lebegopontos);
            */

            /*
            Console.WriteLine("Add meg a neved: ");
            string nev = Console.ReadLine();
            Console.WriteLine($"Szia {nev}.");
            Console.WriteLine("Add meg a korodat: ");
            string kor = Console.ReadLine();
            int kora = int.Parse(kor);
            Console.WriteLine(kora + 32);
            */

            //Felhasználó nevének bekérése + születési év, kiszámolni héány éves
            /*
            Console.WriteLine("Add meg a neved: ");
            string nev = Console.ReadLine();
            Console.WriteLine("Add meg a születési éved: ");
            string ev = Console.ReadLine();
            int szulev = int.Parse(ev);
            Console.WriteLine($"{nev} {2025-szulev} éves vagy.");
            */

            /*
            int szam1 = 5;
            int szam2 = 15;

            if (szam1 > szam2)
            {
                Console.WriteLine($"A {szam1} nagyobb mint {szam2}");
            }

            else if (szam2 > szam1)
            {
                Console.WriteLine($"{szam2} nagyobb mint {szam1}");
            }

            else
            {
                Console.WriteLine("Valami hiba történt");
            }

            Console.WriteLine("Add meg a korod:");
            string kora = Console.ReadLine();
            int kor = int.Parse(kora);

            if (kor >= 18)
            {
                Console.WriteLine("Felülhetsz a hullámvasútra!");
            }

            else if (kor >= 7)
            {
                Console.WriteLine("Felnőtt személlyel felülhetsz!");
            }


            else if (kor <= 6)
            {
                Console.WriteLine("Nem ülhetsz fel a hullámvasútra!");
            }

            else
            {
                Console.WriteLine("Nem számot adtál meg!");
            }
            */

            /*
            for(int i=1; i<101; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} Páros szám.");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            */

            /*
            Console.WriteLine("Adj meg egy szót");
            string szo = Console.ReadLine();
            int szohossza = szo.Length;

            if (szohossza > 1 && szohossza < 5)
            {
                Console.WriteLine("Ez egy rövid szó");
            }

            else if (szohossza > 6)
            {
                Console.WriteLine("Ez egy hosszú szó");
            }

            else
            {
                Console.WriteLine("Nemjó adatot atdál meg");
            }

            Console.WriteLine("Adj meg egy szót");
            string word = Console.ReadLine();

            if (word.Contains("alma"))
            {
                Console.WriteLine("Benne van az alma kifejezés.");
            }

            string mondat = "Ez egy virágos kert";
            if (mondat.Contains("kert"))
            {
                string ujszo = mondat.Replace("kert", "rét");
                Console.WriteLine($"Az új mondat {ujszo}.");
            }
            */

            //kérj be egy mondatot, van benne reggel szó, ird ki h benne van, miylen hosszu a mondat 
            /*
            Console.WriteLine("Adj meg egy mondatot");
            string m = Console.ReadLine();
            if (m.Contains("reggel"))
            {
                Console.WriteLine($"A mondatban benne van a reggel szó, a szó hossza: {m.Length}");
            }
            */

            /*
            Console.WriteLine("Adj meg egy számot 10-100-ig:");
            string megadottszam = Console.ReadLine();
            int mszam = int.Parse(megadottszam);
            for(int i = 1; i < mszam +1; i++) 
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine("Páratlan szám");
                }

                else
                {
                    Console.WriteLine(i);
                }
            }
            */

            /*
            //ha 3 megvan benne akkor irja ki Fizz ha nincs Buzz, ha 3 és 5 akkor FizzBuzz
            Console.WriteLine("Adj meg egy számt 10-100-ig:");
            string szam = Console.ReadLine();
            int sz = int.Parse(szam);
            for(int i = 1; i<sz +1; i++) 
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            */

            //1km - 120Ft
            /*
            Console.WriteLine("Melyen vonatjegyet szeretnél:");
            string vonatjegy = Console.ReadLine().ToLower();
            Console.WriteLine("Hány km-ert fogsz utazni?");
            string utazik = Console.ReadLine();
            int km = int.Parse(utazik);
            if (vonatjegy == "diak")
            {
                int osszeg = 60 * km;
                Console.WriteLine($"A jegy típusa: {vonatjegy}, a fizetendő összeg: {osszeg} Ft");
            }

            else if(vonatjegy == "felnott")
            {
                int osszeg = 120 * km;
                Console.WriteLine($"A jegy típusa: {vonatjegy}, a fizetendő összeg: {osszeg} Ft");
            }

            else if(vonatjegy == "nyugdíjas")
            {
                int osszeg = 50 * km;
                Console.WriteLine($"A jegy típusa: {vonatjegy}, a fizetendő összeg: {osszeg} Ft");
            }
            */

            //S -2000ft, M-2500ft, L-3000ft pizza
            //kérd be a felhasználótól h melyik méretű pizzat kéri és mennyit
            //mennyibe kerül
            Console.WriteLine("Milyen méretű pizzát szeretnél:");
            string meret = Console.ReadLine().ToLower();
            Console.WriteLine("Mennyit szeretnél belőle?");
            string mennyiseg = Console.ReadLine();
            int db = int.Parse(mennyiseg);
            if (meret == "s")
            {
                int osszeg = db*2000;
                Console.WriteLine($"A pizza mérete: {meret}, a fizetendő összeg: {osszeg} Ft");
            }

            else if (meret == "m")
            {
                int osszeg = db * 2500;
                Console.WriteLine($"A pizza mérete: {meret}, a fizetendő összeg: {osszeg} Ft");
            }

            else if (meret == "l")
            {
                int osszeg = db * 3000;
                Console.WriteLine($"A pizza mérete: {meret}, a fizetendő összeg: {osszeg} Ft");
            }






            Console.ReadKey();
        }
    }
}
