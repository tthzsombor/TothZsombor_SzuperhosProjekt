using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SzuperhosProjekt
{
    internal static class Kepregeny
    {

        public enum SZEREPLO
        {
            VASEMBER,
            BATMAN
        }

        public static List<string> szuperhosok;



        public static void Szereplok(string fájl)
        {
            using (StreamReader sr = new StreamReader(fájl))
            {
                while (!sr.EndOfStream)
                {
                    string sor=sr.ReadLine();
                    string[] darabok = sor.Split(';');

                    if (darabok[0].Equals(SZEREPLO.VASEMBER))
                    {
                       
                    }
                }
            }

        }

    }
}
