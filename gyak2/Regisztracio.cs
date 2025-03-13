using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace gyak2
{
    internal class Regisztracio
    {
        public string nev;
        public string felnev;
        public string email;
        public string jelszo;
        public DateTime szuldatum;

        public Regisztracio(string nev, string felnev, string email, string jelszo, string szuldatum)
        {
            this.nev = nev;
            this.felnev = felnev;
            this.email = email;
            this.jelszo = jelszo;
            this.szuldatum = Convert.ToDateTime(szuldatum);
        }
    }
}
