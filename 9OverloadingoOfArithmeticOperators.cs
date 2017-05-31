# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStructorNumerEnumerations_3
{
    class OverloadingoOfArithmeticOperators
    {
        public double ReelVal { get; set; }
        public double VirtualVal { get; set; }

        public OverloadingoOfArithmeticOperators()
        {
            ReelVal = 0;
            VirtualVal = 0;
        }
        public OverloadingoOfArithmeticOperators(double r, double v)
        {
            ReelVal = r;
            VirtualVal = v;
        }

        public static OverloadingoOfArithmeticOperators operator +(OverloadingoOfArithmeticOperators a, OverloadingoOfArithmeticOperators b)
        {
            double ReelValTotal = a.ReelVal + b.ReelVal;
            double VirtualVal = a.VirtualVal + b.VirtualVal;
            return new OverloadingoOfArithmeticOperators(ReelValTotal, VirtualVal);
        }
        public static OverloadingoOfArithmeticOperators operator -(OverloadingoOfArithmeticOperators a, OverloadingoOfArithmeticOperators b)
        {
            double ReelValTotal = a.ReelVal - b.ReelVal;
            double VirtualVal = a.VirtualVal - b.VirtualVal;
            return new OverloadingoOfArithmeticOperators(ReelValTotal, VirtualVal);
        }
        public static OverloadingoOfArithmeticOperators operator -(OverloadingoOfArithmeticOperators a, int b)
        {
            double ReelValTotal = a.ReelVal - b;

            return new OverloadingoOfArithmeticOperators(ReelValTotal, a.VirtualVal);
        }
        public static OverloadingoOfArithmeticOperators operator -(int b, OverloadingoOfArithmeticOperators a)
        {
            double ReelValTotal = b - a.ReelVal;

            return new OverloadingoOfArithmeticOperators(ReelValTotal, a.VirtualVal);
        }
        public static OverloadingoOfArithmeticOperators operator /(OverloadingoOfArithmeticOperators a, OverloadingoOfArithmeticOperators b)
        {
            double devideReelVal = a.ReelVal / b.ReelVal;
            double devideVirtualVal = a.VirtualVal / b.VirtualVal;
            return new OverloadingoOfArithmeticOperators(devideReelVal, devideVirtualVal);
        }
        public static OverloadingoOfArithmeticOperators operator *(OverloadingoOfArithmeticOperators a, OverloadingoOfArithmeticOperators b)
        {
            double multipleReel1 = a.ReelVal * b.ReelVal;
            double multipleReel2 = a.VirtualVal * b.VirtualVal;
            double multipleReel = multipleReel1 - multipleReel2;

            double multipleVirtual1 = a.ReelVal * b.VirtualVal;
            double multipleVirtual2 = a.VirtualVal * b.ReelVal;
            double multipleVirtual = multipleVirtual1 + multipleVirtual2;

            return new OverloadingoOfArithmeticOperators(multipleReel, multipleVirtual);
        }
        public static OverloadingoOfArithmeticOperators operator *(OverloadingoOfArithmeticOperators a, double b)
        {
            double reelResult = a.ReelVal * b;
            return new OverloadingoOfArithmeticOperators(reelResult, a.VirtualVal);
        }


        public void WriteScreen(OverloadingoOfArithmeticOperators obj)
        {
            if (obj.VirtualVal > 0)
                Console.WriteLine(obj.ReelVal + "+" + obj.VirtualVal + "j");
            else
                Console.WriteLine(obj.ReelVal + "-" + -obj.VirtualVal + "j");

        }
        public static implicit operator double (OverloadingoOfArithmeticOperators a) //Overload of double operator
        {
            return a.ReelVal;
        }

        public static implicit operator OverloadingoOfArithmeticOperators(double a)
        {
            return new OverloadingoOfArithmeticOperators(a, 0);
        }

    }
}
