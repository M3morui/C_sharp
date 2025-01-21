using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcase_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Válasszon egy terméket: ");
            Console.WriteLine("1 - Kávé");
            Console.WriteLine("2 - Tea");
            Console.WriteLine("3 - Víz");

            string adatbeker = Console.ReadLine();
            int valasz = int.Parse(adatbeker);

            switch (valasz)
            {
                case 1:
                    Console.WriteLine("Kávét választottad.");
                    break;

                case 2:
                    Console.WriteLine("Teát választottad.");
                    break;

                case 3:
                    Console.WriteLine("Vizet választottad.");
                    break;

                default:
                    Console.WriteLine("Nem a megfelelő számot adtad meg.");
                    break;
            }
            */

            /*
            Console.WriteLine("Adj meg egy számot 1-12");
            string bekertszam = Console.ReadLine();
            int szam = int.Parse(bekertszam);

            switch (szam)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Ez a hónap 31 napos.");
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Ez a hónap 30 napos.");
                    break;

                case 2:
                    Console.WriteLine("Ez a hónap általában 28 napos, de szökőévben 29.");
                    break;

                default:
                    Console.WriteLine("Érvénytelen hónap szám lett megadva.");
                    break;
            }
            */

            //számológép
            /*
            Console.WriteLine("Add meg az első számot");
            string szam1 = Console.ReadLine();
            int sz1 = int.Parse(szam1);

            Console.WriteLine("Add meg a másik számot");
            string szam2 = Console.ReadLine();
            int sz2 = int.Parse(szam2);

            Console.WriteLine("Add meg a műveletet (+, -, *, /)");
            string muvelet = Console.ReadLine();

            switch (muvelet)
            {
                case "+":
                    Console.WriteLine($"Az összeadás eredménye: {sz1 + sz2}");
                    break;

                case "-":
                    Console.WriteLine($"A kivonás eredménye: {sz1 - sz2}");
                    break;

                case "*":
                    Console.WriteLine($"Az szorzás eredménye: {sz1 * sz2}");
                    break;

                case "/":
                    Console.WriteLine($"Az osztás eredménye: {sz1 / sz2}");
                    break;

                default:
                    Console.WriteLine("Nincs ilyen művelet");
                    break;
            }
            */

            //napi program ajánló
            /*
            Console.WriteLine("Add meg a hét egyik napját:");
            string nap = Console.ReadLine();

            switch (nap)
            {
                case "hétfő":
                    Console.WriteLine("Kezdjük a hetet erősen. Edzsés ajánlott!");
                    break;
                case "kedd":
                    Console.WriteLine("Ideális nap egy baráti találkozóra.");
                    break;
                case "szerda":
                    Console.WriteLine("Olvasásra tökéletes nap");
                    break;
                case "csütörtök":
                    Console.WriteLine("Tervezz előre a hétvégére.");
                    break;
                case "péntek":
                case "szombat":
                    Console.WriteLine("Pihenj és élvezd a szabad időt!");
                    break;
                default:
                    Console.WriteLine("érvénytelen nap");
                    break;
            }
            */

            /*
            Console.WriteLine("Adj meg egy termék kategóriát (ruha, étel, elektronika)");
            string termek = Console.ReadLine();
            Console.WriteLine("Add meg a termék árát");
            string ara = Console.ReadLine();
            int ar = int.Parse(ara);

            switch (termek)
            {
                case "ruha":
                    if (ar <= 2000) 
                    {
                        Console.WriteLine("Ez egy olcsó ruha");
                    }
                    else if (ar <= 5000)
                    {
                        Console.WriteLine("Ez egy drága ruha");
                    }
                    break;

                case "étel":
                    if (ar <= 500)
                    {
                        Console.WriteLine("Ez egy olcsó étel");
                    }
                    else if(ar <= 1500)
                    {
                        Console.WriteLine("Ez egy közepesen drága étel");
                    }
                    else
                    {
                        Console.WriteLine("Ez egy drága étel");
                    }
                    break;

                case "elektronika":
                    if(ar <= 10000)
                    {
                        Console.WriteLine("Ez egy olcsó elektronikai eszköz");
                    }
                    else if(ar <= 30000)
                    {
                        Console.WriteLine("Ez egy közepesen drága elektronikai eszköz");
                    }
                    else
                    {
                        Console.WriteLine("Ez egy prémium elektronikai eszköz");
                    }
                    break;

                default:
                    Console.WriteLine("Érvénytelen kategória");
                    break;
            }
            */

            /*
            int i = 1;
            while(i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
            */

            /*
            int szam = 0;
            while (szam != 10)
            {
                Console.WriteLine("Adj meg egy számot 1-100 között:");
                string sz = Console.ReadLine();
                szam = int.Parse(sz);
            }
            Console.WriteLine($"Meg adtad a megfelelő számot: {szam}");
            */

            string jelszo = "jelszo123";
            int jelszohossza = jelszo.Length;
            string j = "";
            int bekertjelszohossza = 0;
            while ( jelszohossza != bekertjelszohossza)
            {
                Console.WriteLine("Adj meg egy jelszót:");
                j = Console.ReadLine();
                bekertjelszohossza = j.Length;
                if(bekertjelszohossza < jelszohossza)
                {
                    Console.WriteLine("Amit megadtál jelszót túl rövid");
                }
                else if(bekertjelszohossza > jelszohossza)
                {
                    Console.WriteLine("Túl hoszzú a jelszó amit megadtál");
                }
            }
            Console.WriteLine($"megfelelő hossza: {bekertjelszohossza}");

            Console.ReadKey();
        }
    }
}
