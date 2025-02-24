using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp
{
    internal class kutya
    {
        public string nev;
        public int kor;
        public string szin;
        public string hang;

        public kutya(string nev, int kor, string szin, string hang)
        {
            this.nev = nev;
            this.kor = kor;
            this.szin = szin;
            this.hang = hang;
        }

        public string KutyaKiir()
        {
            return $"A kutya neve: {nev}, a kora: {kor}, színe: {szin}";
        }
        public string KutyaHang()
        {
            return $"A kutyád ilyen hangot ad ki: {hang}";
        }

        public string Kutyaszul()
        {
            return $"A kutyád ekkor született: {2025 - kor}";
        }


    }
}
