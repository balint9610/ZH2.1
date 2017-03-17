using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication51
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BarnaAMedve bm = new BarnaAMedve(10, 35,0, 0);
            ParaARóka pr = new ParaARóka(9,30,0,0);
            TréMedve tr = new TréMedve(6, 30, 0, 0);
            MásnaposSzöcske msz = new MásnaposSzöcske(8,10,0,0);
            for (int i =0; i < 10; i++)
            {
                for (int x = 0; x < 10; x++)
                {
                    bm.Helyzet = bm.Sebesseg * bm.Kör;
                    bm.Kör++;
                    pr.Helyzet = pr.Sebesseg * pr.Kör;
                    pr.Kör++;
                    tr.Helyzet = tr.Sebesseg * tr.Kör;
                    tr.Kör++;
                    msz.Helyzet = msz.Sebesseg * msz.Kör;
                    msz.Kör++;
                }

                Console.WriteLine("BarnaAMedve: Rajt Szám:{0}, Sebesség{1},Megtett Táv:{2}, Kör:{3} ", bm.RajtSzam, bm.Sebesseg, bm.Helyzet, bm.Kör);
                Console.WriteLine("ParaARóka: Rajt Szám:{0}, Sebesség{1},Megtett Táv:{2}, Kör:{3} ", pr.RajtSzam, pr.Sebesseg, pr.Helyzet, pr.Kör);
                Console.WriteLine("TréMedve: Rajt Szám:{0}, Sebesség{1},Megtett Táv:{2}, Kör:{3} ", tr.RajtSzam, tr.Sebesseg, tr.Helyzet, tr.Kör);

                Console.ReadKey();
            }



            Console.ReadKey();
        }
    }
}
