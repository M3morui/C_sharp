using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace suli
{
    internal class Adatok
    {
        public int diak_id;
        public string dveznev;
        public string dkernev;
        public string osztaly;

        public Adatok(string diak_id, string dveznev, string dkernev, string osztaly)
        {
            this.diak_id = int.Parse(diak_id);
            this.dveznev = dveznev;
            this.dkernev = dkernev;
            this.osztaly = osztaly;
        }
    }
}
