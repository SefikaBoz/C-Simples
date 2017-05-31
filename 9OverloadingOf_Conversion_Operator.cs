# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStructorNumerEnumerations_3
{
    class OverloadingOf_Conversion_Operator
    {
        public double Reel { get; set; }

        public double Virtual { get; set; }

        public OverloadingOf_Conversion_Operator()
        {
            Reel = 0;
            Virtual = 0;
        }
        public OverloadingOf_Conversion_Operator(double r , double v)
        {
            Reel = r;
            Virtual = v;
        }
        public static implicit operator double (OverloadingOf_Conversion_Operator a)
        {
            return a.Reel;
        }
        public static implicit operator int (OverloadingOf_Conversion_Operator a)
        {

            return (int)a.Reel;
        }

    }
}
