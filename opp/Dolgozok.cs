using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp
{
    internal class Dolgozok
    {
        public string veznev;
        public string keznev;
        public DateTime szulev;
        public string beosztas;
        public int csatlakoz;
        public int oraszam;

        public Dolgozok(string veznev, string keznev, DateTime szulev, string beosztas, int csatlakoz, int oraszam)
        {
            this.veznev = veznev;
            this.keznev = keznev;
            this.szulev = szulev;
            this.beosztas = beosztas;
            this.csatlakoz = csatlakoz;
            this.oraszam = oraszam;
        }

    }
}
