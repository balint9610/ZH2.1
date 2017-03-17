using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication51
{
    class Program
    {
        public
        static void Main(string[] args)
        {

            BarnaAMedve bm = new BarnaAMedve(10, 35, 0, 0);
            ParaARóka pr = new ParaARóka(9, 30, 0, 0);
            TréMedve tr = new TréMedve(6, 30, 0, 0);
            MásnaposSzöcske msz = new MásnaposSzöcske(8, 10, 0, 0);
            Hóvirág hv = new Hóvirág(3, 0, 0, 0);
            ZsigaCsiga ZsCs = new ZsigaCsiga(5, 1, 0, 0);
            Csacskanyúl CsNy = new Csacskanyúl(7, 33,0,0);
            Bolha b = new Bolha(4,tr.Sebesseg,0,0);
            Random rnd = new Random();        
            int ORDIT = rnd.Next(1, 10);
            for (int i = 0; i < 10; i++)
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
                    hv.Helyzet = hv.Sebesseg * hv.Kör;
                    hv.Kör++;

                    if (ORDIT == 15)
                    {
                        
                    }
                    else
                    {
                        ZsCs.Helyzet = ZsCs.Sebesseg * ZsCs.Kör;
                        ZsCs.Kör++;
                    }
                    if (ORDIT == 15)
                    {
                        CsNy.Helyzet = CsNy.Sebesseg * 2 * ZsCs.Kör;
                        ZsCs.Kör++;
                    }
                    else
                    {
                        CsNy.Helyzet = CsNy.Sebesseg * CsNy.Kör;
                    CsNy.Kör++;
                    }
                    b.Helyzet = b.Sebesseg * b.Kör;
                    b.Kör++;

                }
                Console.WriteLine("BarnaAMedve: Rajt Szám:{0}, Sebesség{1},Megtett Táv:{2}, Kör:{3} ", bm.RajtSzam, bm.Sebesseg, bm.Helyzet, bm.Kör);
                Console.WriteLine("ParaARóka: Rajt Szám:{0}, Sebesség{1},Megtett Táv:{2}, Kör:{3} ", pr.RajtSzam, pr.Sebesseg, pr.Helyzet, pr.Kör);
                Console.WriteLine("TréMedve: Rajt Szám:{0}, Sebesség{1},Megtett Táv:{2}, Kör:{3} ", tr.RajtSzam, tr.Sebesseg, tr.Helyzet, tr.Kör);
                Console.WriteLine("MásnaposSzöcske: Rajt Szám:{0}, Sebesség{1},Megtett Táv:{2}, Kör:{3} ", msz.RajtSzam, msz.Sebesseg, msz.Helyzet, msz.Kör);
                Console.WriteLine("Hóvirág: Rajt Szám:{0}, Sebesség{1},Megtett Táv:{2}, Kör:{3} ", hv.RajtSzam, hv.Sebesseg, hv.Helyzet, hv.Kör);
                Console.WriteLine("ZsigaCsiga: Rajt Szám:{0}, Sebesség{1},Megtett Táv:{2}, Kör:{3} ", ZsCs.RajtSzam, ZsCs.Sebesseg, ZsCs.Helyzet, ZsCs.Kör);
                Console.WriteLine("CsacskaNyúl: Rajt Szám:{0}, Sebesség{1},Megtett Táv:{2}, Kör:{3} ", CsNy.RajtSzam, CsNy.Sebesseg, CsNy.Helyzet, CsNy.Kör);
                Console.WriteLine("Bolha: Rajt Szám:{0}, Sebesség{1},Megtett Táv:{2}, Kör:{3} ", b.RajtSzam, b.Sebesseg, b.Helyzet, b.Kör);
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
