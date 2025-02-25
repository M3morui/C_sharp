using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nyaralas
{
    internal class Nyaralas
    {
        public int sorszam;
        public string nev;
        public string szallas;
        public int foglalas;
        public int napszam;
        public int ar;
        public string kedvezmeny;

        public Nyaralas(string sorszam, string nev, string szallas, string foglalas, string napszam, string ar, string kedvezmeny)
        {
            this.sorszam = int.Parse(sorszam);
            this.nev = nev;
            this.szallas = szallas;
            this.foglalas = int.Parse(foglalas);
            this.napszam = int.Parse(napszam);
            this.ar = int.Parse(ar);
            this.kedvezmeny = kedvezmeny;
        }
    }
}
