using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suli
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            /*
            int diak_id = 16;
            string dveznev = "Fehér";
            string dkernev = "László";
            string osztaly = "11C";
            */

            //Create.UjDiak(diak_id, dveznev, dkernev, osztaly);
            //Console.WriteLine("Sikeresen hozzáadtad.");
            //Update.AdatModosit("Lukács", "Kolompár", "Edit", "11C");
            //Console.WriteLine("Az adatok sikeresen módosítva.");
            Read.AdatKiolvas();
            Delete.AdatTorles(13);
            Console.ReadKey();
        }
    }
}
