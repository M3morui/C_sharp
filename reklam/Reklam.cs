using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reklam
{
    internal class Reklam
    {
        public int rendelesnap;
        public string varos;
        public int rendeltdb;

        public Reklam(string rendelesnap, string varos, string rendeltdb)
        {
            this.rendelesnap = int.Parse(rendelesnap);
            this.varos = varos;
            this.rendeltdb = int.Parse(rendeltdb);
        }
    }
}
