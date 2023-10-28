using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    internal class Vasember : Bosszuallo, Milliardos
    {
        Random rnd = new Random();
        
        public Vasember(double szuperero, bool vanEGyengesege) : base(szuperero, vanEGyengesege)
        {
            szuperero = 150;
            vanEGyengesege = true;
        }

        public void KutyutKeszit()
        {
            Szuperero += rnd.NextDouble()+rnd.Next(0,9);
        }

        public override bool MegmentiAVilagot()
        {
            return (Szuperero>1000)? true:false;
        }

        public override string ToString()
        {
            string gyengeseg = "";
            if (VanEGyengesege==true)
            {
                gyengeseg = "van gyengesege";
            }
            else
            {
                gyengeseg = "nincs gyengesége";
            }
            return $"Vasember: Szupererő: {this.Szuperero}; {gyengeseg}";
        }
    }
}
