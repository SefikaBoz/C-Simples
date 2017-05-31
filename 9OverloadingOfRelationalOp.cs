# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStructorNumerEnumerations_3
{
    class OverloadingOfRelationalOp
    {
        // geriye true ya da false ifadeler döndürür( en mantıklı kullanım sekli bu)
        // geri dönus tipi void olmaz
        // != , == , < , > , <= ,  >= 

        // Zıt anlamlı operatorler aynı anda overload edilmek zorundadır.

        public double ReelVal { get; set; }
        public double VirtualVal { get; set; }

        public OverloadingOfRelationalOp()
        {
            ReelVal = 0;
            VirtualVal = 0;
        }
        public OverloadingOfRelationalOp(double r, double v)
        {
            ReelVal = r;
            VirtualVal = v;
        }

        public static bool operator==(OverloadingOfRelationalOp a, OverloadingOfRelationalOp b)
        {
            if (a.VirtualVal == b.VirtualVal && a.ReelVal == b.ReelVal)
                return true;
            else
                return false;
        }

        public static bool operator!=(OverloadingOfRelationalOp a, OverloadingOfRelationalOp b)
        {
            //if (a.VirtualVal != b.VirtualVal && a.ReelVal != b.ReelVal)
            //    return true;
            //else
            //    return false;
            return !(a == b); // kolay kullanım
        }

        public static bool operator>(OverloadingOfRelationalOp a , OverloadingOfRelationalOp b)
        {
            if (a.VirtualVal > b.VirtualVal && a.ReelVal > b.ReelVal)
                return true;
            else
                return false;
        }
        public static bool operator <(OverloadingOfRelationalOp a, OverloadingOfRelationalOp b)
        {         
                return !(a>b);
        }

        public static bool operator true (OverloadingOfRelationalOp a)
        {
            if (a.ReelVal != 0 || a.VirtualVal != 0)
                return true;
            else
                return false;
        }
        public static bool operator false (OverloadingOfRelationalOp a)
        {
            if (a.ReelVal != 0 && a.VirtualVal != 0)
                return true;
            else
                return false;
        }

    }
}
