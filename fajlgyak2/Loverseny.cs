using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fajlgyak2
{
    internal class Loverseny
    {
        public string zsoke;
        public string lonev;
        public bool nyert;
        public int nyeremeny;
        public int helyezes;

        public Loverseny(string zsoke, string lonev, string nyert, string nyeremeny, string helyezes)
        {
            this.zsoke = zsoke;
            this.lonev = lonev;
            this.nyert = bool.Parse(nyert);
            this.nyeremeny = int.Parse(nyeremeny);
            this.helyezes = int.Parse(helyezes);
        }
    }
}
