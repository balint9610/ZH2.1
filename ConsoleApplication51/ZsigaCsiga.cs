using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication51
{
    public class ZsigaCsiga : Adatok
    {
        public ZsigaCsiga(int RajtSzam, int Sebesseg, int Helyzet, int Kör) : base(RajtSzam, Sebesseg, Helyzet, Kör)
        {
            RajtSzam = 5;
            Sebesseg = 1;
        }
    }
}