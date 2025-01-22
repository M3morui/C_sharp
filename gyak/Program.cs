using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string kerdes1 = "Mi Magyarország fővárosa?";
            string valasz1 = "Budapest";

            string kerdes2 = "Hány napból áll egy év, ha nem szökőév";
            int valasz2 = 365;

            int talalat = 0;

            do
            {
                Console.WriteLine(kerdes1);
                string felhasznaloValasz = Console.ReadLine();
                talalat++;

                if(felhasznaloValasz == valasz1)
                {
                    Console.WriteLine($"Eltaláltad a helyes választ: {valasz1}");
                    
                    break;
                }
                else
                {
                    Console.WriteLine("Nem helyes válasz");
                }
                
            } while (true);

            do
            {
                Console.WriteLine(kerdes2);
                int userValasz = int.Parse( Console.ReadLine() );
                talalat++;
                if(userValasz == valasz2)
                {
                    Console.WriteLine($"Helyes válasz: {valasz2} volt.");
                    Console.WriteLine($"Találgatások száma: {talalat}");
                    break;
                }
                else
                {
                    Console.WriteLine("Nem ez volt a helyes válasz.");
                }
            } while(true);
            */

            /*
            Random random = new Random();
            int randomszam = random.Next(1,20);

            do
            {
                Console.WriteLine("Gondoltam egy számra 1-20 között: ");
                int bekertSzam = int.Parse(Console.ReadLine());
                if (bekertSzam == randomszam)
                {
                    Console.WriteLine($"Eltaláltad a {randomszam}-ra gondoltam.");
                    break;
                }
                else
                {
                    Console.WriteLine("Nem találtad el, próbáld újra.");
                }
            } while (true);
            */

            Random random = new Random();
            do
            {
                int randomjatek = random.Next(1, 4);
                Console.WriteLine("Játsszunk kő papír ollót!");
                Console.WriteLine("1-kő, 2-papír, 3-olló");
                int bekertjel = int.Parse(Console.ReadLine());
                if (bekertjel == randomjatek)
                {
                    Console.WriteLine($"Döntet len az állás!");
                }

                else if (bekertjel == 1 && randomjatek == 2)
                {
                    Console.WriteLine("Vesztettél!");
                }

                else if (bekertjel == 2 && randomjatek == 3)
                {
                    Console.WriteLine("Vesztettél!");
                }

                else if (bekertjel == 3 && randomjatek == 1)
                {
                    Console.WriteLine("Vesztettél!");
                }

                else if (bekertjel == 1 && randomjatek == 3)
                {
                    Console.WriteLine("Nyertél!");
                    break;
                }

                else if (bekertjel == 2 && randomjatek == 1)
                {
                    Console.WriteLine("Nyertél!");
                    break;
                }

                else if (bekertjel == 3 && randomjatek == 2)
                {
                    Console.WriteLine("Nyertél!");
                    break;
                }

            } while (true);

            Console.ReadKey();
        }
    }
}
