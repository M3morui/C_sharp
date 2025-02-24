using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace termekek
{
    internal class Program
    {

        public struct kisbolt
        {
            public int het;
            public string termeknev;
            public int db;
            public int egysegar;
            public int eladas;
        }

        public static List <kisbolt> aruk = new List<kisbolt>();
        static void Main(string[] args)
        {
            FileStream f = new FileStream("eladasok.txt", FileMode.Open);
            StreamReader sr = new StreamReader(f, Encoding.UTF8);
            kisbolt aktualis = new kisbolt();
            while (!sr.EndOfStream) 
            {
                string[] sor = sr.ReadLine().Split(';');
                aktualis.het = Convert.ToInt32(sor[0]);
                aktualis.termeknev = sor[1];
                aktualis.db = Convert.ToInt32(sor[2]);
                aktualis.egysegar = Convert.ToInt32(sor[3]);
                aktualis.eladas = Convert.ToInt32(sor[4]);
                aruk.Add( aktualis );
            }

            for (int i = 0; i < aruk.Count; i++) 
            {
                Console.WriteLine($"{aruk[i].het}; {aruk[i].termeknev}; {aruk[i].db}; {aruk[i].egysegar}; {aruk[i].eladas}");
            }



            Console.ReadKey();
        }
    }
}
