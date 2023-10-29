using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace SzuperhosProjekt
{
    internal static class Kepregeny
    {

        public enum SZEREPLO
        {
            VASEMBER,
            BATMAN
        }

        public static List<string> szuperhosok = new List<string>();

       


        public static void Szereplok(string fájl)
        {
            using (StreamReader sr = new StreamReader(fájl))
            {
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    string[] darabok = sor.Split(';');

                    if (darabok[0].Equals(SZEREPLO.VASEMBER))
                    {
                       Vasember v=new Vasember(Convert.ToDouble(darabok[1]), Convert.ToBoolean(darabok[2]));
                        szuperhosok.Add(v.ToString());
                    }
                    else
                    {
                        Batman b = new Batman();
                        szuperhosok.Add(b.ToString());
                    }
                }
            }

        }

        public static void Szuperhosok()
        {
            for (int i = 0; i < szuperhosok.Count; i++)
            {
                Console.WriteLine(szuperhosok[i]);
            }
        }

    }
}
