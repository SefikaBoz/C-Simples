# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStructorNumerEnumerations_3
{
    class Complex
    {
       
        public double Reel { get; set; }
        public double Virtual { get; set; }

        public Complex(double reel, double virt)
        {
            Reel = reel;
            Virtual = virt;
        }
        public Complex()
        {
            Reel = 0;
            Virtual = 0;
        }
        public Complex(Complex comp)
        {

        }

        public static Complex operator+ (Complex c1 , Complex c2)
        {
            double reelTotal = c1.Reel + c2.Reel;
            double virtualTotal = c1.Virtual + c2.Virtual;

           
            if (virtualTotal > 0)
                Console.WriteLine(reelTotal
                    +"+" + virtualTotal + "j");
            else
                Console.WriteLine(reelTotal + "-"+ (-virtualTotal) + "j");

            return new Complex(reelTotal, virtualTotal);
        }
        public static Complex operator+(Complex c , double i)
        {
            double reelTotal =   i + c.Reel;
            return new Complex(reelTotal, c.Virtual);
        } 
       

    
    }
}
