# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6
{
    class Gamer
    {      
        public static int Total { get; set; }
        public static int total
        {
            get
            {
                return Total;
            }
            set
            {
                Total = 45;
            }
        }

        public Gamer()
        {

            Gamer.Total++;
            // Console.WriteLine("Static constructor..");
        }
        static Gamer()// Static yapıcı ilk nesne tanımlanırken bir kez cağrılır basta.
        {

            Gamer.Total++;
            // Console.WriteLine("non Static constructor...");
        }
        ~Gamer()
        {
            Console.WriteLine("Bir oyuncu gitti..");
            Total--;
        }
    }
}
