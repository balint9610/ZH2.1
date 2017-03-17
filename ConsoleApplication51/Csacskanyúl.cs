using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication51
{
    public class Csacskanyúl : Adatok
    {
        public Csacskanyúl(int RajtSzam, int Sebesseg, int Helyzet, int Kör) : base(RajtSzam, Sebesseg, Helyzet, Kör)
        {
            RajtSzam = 7;
            Sebesseg = 33;
        }
    }
}