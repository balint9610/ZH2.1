using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication51
{
    public class Hóvirág : Adatok
    {
        

        public void StartPisztoly()
        {
            Sebesseg = 0;
        }
        public Hóvirág(int RajtSzam, int Sebesseg, int Helyzet, int Kör) : base(RajtSzam, Sebesseg, Helyzet, Kör)
        {

        }
    }
}