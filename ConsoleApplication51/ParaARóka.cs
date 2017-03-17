using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication51
{
    public class ParaARóka : Adatok
    {
        public ParaARóka(int RajtSzam, int Sebesseg, int Helyzet, int Kör) : base(RajtSzam, Sebesseg, Helyzet, Kör)
        {
            RajtSzam = 9;
            Sebesseg = 30;
        }
    }
}