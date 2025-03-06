using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hellje
{
    internal class Boltok
    {
        public int Bid;
        public string boltnev;
        public int ar;
        public int db;
        public string varos;

        public Boltok(string Bid, string boltnev, string ar, string db, string varos)
        {
            this.Bid = int.Parse(Bid);
            this.boltnev = boltnev;
            this.ar = int.Parse(ar);
            this.db = int.Parse(db);
            this.varos = varos;
        }
    }
}
