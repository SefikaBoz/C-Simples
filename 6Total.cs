# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6
{
    class Total
    {
        int num1;
        int num2;
        int num3;
        int num4;
        int total;
  
        public Total(int num1, int num2, int num3, int num4)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
            this.num4 = num4;
        }
        public Total(int num1, int num2, int num4) : this(num1, num2, 0, num4)
        {

        }

        public Total(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;

        }
        public Total(int num2) : this(0, num2)
        {

        }
        public void ToTotal()
        {
            total = num1 + num2;
            Console.WriteLine(total);
   
        }
   
     
    }
}
