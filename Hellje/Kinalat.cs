using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hellje
{
    internal class Kinalat
    {
        public int Kid;
        public int Bid;
        public int ml;
        public string tipus;
        public string iz;

        public Kinalat(string Kid, string Bid, string ml, string tipus, string iz)
        {
            this.Kid = int.Parse(Kid);
            this.Bid = int.Parse(Bid);
            this.ml = int.Parse(ml);
            this.tipus = tipus;
            this.iz = iz;
        }
    }
}
