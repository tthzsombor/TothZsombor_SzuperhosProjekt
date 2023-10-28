using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    internal abstract class Bosszuallo : ISzuperhos
    {
        private double szuperero;
        private bool vanEGyengesege;

        public double Szuperero { get => szuperero; set => szuperero = value; }
        public bool VanEGyengesege { get => vanEGyengesege; set => vanEGyengesege = value; }

        protected Bosszuallo(double szuperero, bool vanEGyengesege)
        {
            this.Szuperero = szuperero;
            this.VanEGyengesege = vanEGyengesege;
        }

        public abstract bool MegmentiAVilagot();


        public bool LegyoziE(Bosszuallo other)
        {
            bool legyozi=false;

            if (other.VanEGyengesege == true && other.Szuperero < this.Szuperero)
            {
                legyozi = true;
            }

            return legyozi;
        }

    

        public double MekkoraAzEreje()
        {
            return Szuperero;
        }

        public override string ToString()
        {
            return $"Szupererő: {this.szuperero}; {this.vanEGyengesege}";
        }

       
    }
}
