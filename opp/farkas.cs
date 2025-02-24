using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp
{
    internal class farkas
    {
        public string nev;
        public string tipus;
        public int kor;
        public string mitosz;

        public farkas(string nev, string tipus, int kor, string mitosz)
        {
            this.nev = nev;
            this.tipus = tipus;
            this.kor = kor;
            this.mitosz = mitosz;
        }


        public string FarkasKiir()
        {
            return $"A kutya neve: {nev}, a típusa: {tipus}, kora: {kor}, mitológia: {mitosz}";
        }
    }

    
}
