# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStructorNumerEnumerations_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex a = new Complex(-5, -9);
            Complex b = new Complex(2, 4);
            Complex c = a + b;

            Complex d = a + 5;
            Complex e = a + 5.9f;
            Complex f = a + 4.7d;
            // Complex g = 4 + a; error Due to parameter order

            SubractionComplex s1 = new SubractionComplex(1, 2);
            SubractionComplex s2 = new SubractionComplex(2, 7);

            SubractionComplex subResult = s1 - s2;
            subResult.WriteScreen();


            Clock c1 = new Clock(30, 30, 30);
            Clock c2 = new Clock(30, 30, 30);
            Clock cTop = c1 + c2;
            cTop.WriteClock();

            Clock c3 = new Clock(78, 5, 65);
            int i = 25;

            Clock cInt = c3 + i;
            cInt.WriteClock();

            OverloadingoOfArithmeticOperators o1 = new OverloadingoOfArithmeticOperators(4, 2);
            OverloadingoOfArithmeticOperators o2 = new OverloadingoOfArithmeticOperators(2, 2);
            OverloadingoOfArithmeticOperators o3 = o1 / o2;
            OverloadingoOfArithmeticOperators o6 = o1 * o2;

            o3.WriteScreen(o3);


            double number = 9;
            OverloadingoOfArithmeticOperators o4 = o1 * number;
            o4.WriteScreen(o4);

            o6.WriteScreen(o6);


            //OverloadingoOfArithmeticOperators o5 = number * o1; // number * o1 işleminin overload u tanımlı olmadıgından hata verir. yani islemlerde parametre sırası onemli
            //o5.WriteScreen(o5);


            //Overloading of relational operators test  /////////////////////////////////////////////////////////////////////////////////////////////////////////////

            OverloadingOfRelationalOp ovR1 = new OverloadingOfRelationalOp(10, 8);
            OverloadingOfRelationalOp ovR2 = new OverloadingOfRelationalOp(4, 5);

            bool tempBool = (ovR1 != ovR2);

            Console.WriteLine("Tempbool : " + tempBool);

            bool tempBool2 = (ovR1 > ovR2);

            Console.WriteLine("Tempbool2 : " + tempBool2);


            // true and false operators overloading test

            OverloadingOfRelationalOp tObj = new OverloadingOfRelationalOp(5, 10);
            OverloadingOfRelationalOp tObj2 = new OverloadingOfRelationalOp(0, 0);

            if (tObj)
            {
                Console.WriteLine("TObj nesneesi sifir değil");
            }
            else
                Console.WriteLine("TObj sıfır..");

            if (tObj2)
            {
                Console.WriteLine("TObj2 sıfır değil");
            }
            else
                Console.WriteLine("TObj sıfır..");

            //Overloading of the conversion operator

            OverloadingOf_Conversion_Operator o = new OverloadingOf_Conversion_Operator(4,8);

          
            double dNum = o;
            Console.WriteLine(dNum);

            int value = o;
            Console.WriteLine(value);


            OverloadingoOfArithmeticOperators fgfg = 8;

            Console.ReadKey();
        }
    }
}
