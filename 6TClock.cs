# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6
{
    class Zaman
    {
        public int saat;
        public int dakika;
        public int saniye;

        public Zaman(int h, int m, int s)
        {
            saat = h;
            dakika = m;
            saniye = s;
        }
        public Zaman(Zaman z)
        {
            saat = z.saat;
            dakika = z.dakika;
            saniye = z.saniye;
        }
        ~Zaman()
        {
            Console.WriteLine("ConstructorHourClass ının yıkıcı metodu çağrıldı..");
        }
        public void Yaz()
        {
            Console.WriteLine(saat + ":" + dakika + ":" + saniye );
        }
    }
}
