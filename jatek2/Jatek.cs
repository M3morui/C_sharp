using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jatek2
{
    internal class Jatek
    {
        public int sorszam;
        public string tipus;
        public string cim;
        public int ar;
        public int db;

        public Jatek(string sorszam, string tipus, string cim, string ar, string db)
        {
            this.sorszam = int.Parse(sorszam);
            this.tipus = tipus;
            this.cim = cim;
            this.ar = int.Parse(ar);
            this.db = int.Parse(db);
        }
    }
}
