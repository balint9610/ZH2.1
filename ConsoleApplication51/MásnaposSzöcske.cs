using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication51
{
    public class MásnaposSzöcske : Adatok
    {
        public MásnaposSzöcske(int RajtSzam, int Sebesseg, int Helyzet, int Kör) : base(RajtSzam, Sebesseg, Helyzet, Kör)
        {
            RajtSzam = 8;
            Sebesseg = 10;
        }
    }
}