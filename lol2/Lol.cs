using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol2
{
    internal class Lol
    {
        public int id;
        public string szint;
        public int meccsek;
        public int vereseg;
        public string hos;
        public string osveny;
        public string nev;

        public Lol(string id, string szint, string meccsek, string vereseg, string hos, string osveny, string nev)
        {
            this.id = int.Parse(id);
            this.szint = szint;
            this.meccsek = int.Parse(meccsek);
            this.vereseg = int.Parse(vereseg);
            this.hos = hos;
            this.osveny = osveny;
            this.nev = nev;
        }

        public static int Megszamol(List<Lol> jatekosok)
        {
            return jatekosok.Count();
        }
        /*
        public static List<string> LolMegad(List<Lol> ujak)
        {
            List<string> kari = new List<string>();
            foreach (var item in ujak)
            {
                if (!kari.Contains(item.hos))
                {
                    kari.Add(item.hos);
                }
            }
            return (kari);
        }
        */

        public static List<string> NevekMegszamol(List<Lol> jatekosok)
        {
            List<string> s_nevek = new List<string>();
            foreach(var item in jatekosok)
            {
                if (item.nev.StartsWith("S"))
                {
                    s_nevek.Add(item.nev);
                }
            }
            return (s_nevek);
        }
        
            
        
    }
}
