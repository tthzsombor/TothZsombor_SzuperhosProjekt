using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    internal class Batman : ISzuperhos, Milliardos
    {
        private double lelemenyesseg;

        public Batman()
        {
            this.lelemenyesseg = 100;
        }

        public void KutyutKeszit()
        {
            lelemenyesseg += 50;
        }

        public bool LegyoziE(Bosszuallo other)
        {
            bool legyozie=false;
            if (other.MekkoraAzEreje()<this.lelemenyesseg)
            {
                legyozie = true;
            }
            return legyozie;
        }

        public double MekkoraAzEreje()
        {
            return this.lelemenyesseg * 2;
        }

        public override string ToString()
        {
            return $"Batman: Leleményessége: {this.lelemenyesseg}";
        }
    }
}
