# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableExpClass
{
    class Program
    {
        static void Main(string[] args)
        {
            NullAbleExp nullableExp = new NullAbleExp();
            nullableExp.NullableMethod();

            Console.ReadLine();
        }
    }
    class NullAbleExp
    {
        public void NullableMethod()
        {
            Nullable<int> abc = new Nullable<int>(4554);
            abc = 546;
            Nullable<double> doub = null;
            Console.WriteLine("abc : {0} , doub : {1}" , abc, doub);
            Console.WriteLine("doub' s default or current value : {0}", doub.GetValueOrDefault());

            int number = 10;
            //number = null; error
            Nullable<int> nullableNumber = new Nullable<int>(456);
            nullableNumber = null;
            //int tempElem = nullableNumber.Value; 

            Nullable<double> doubleNum = new Nullable<double>(456.852);
            Console.WriteLine("doubleNum : " + doubleNum);

            double? doubleNum2 = null;

            Console.WriteLine("doubleNum2' s getvalue or default : " + doubleNum2.GetValueOrDefault());

            bool boolValue = false;
            // boolValue = null;   error..


            bool? boolValue2 = true;
            Console.WriteLine("boolValue2.GetValueOrDefault :  " + boolValue2.GetValueOrDefault());
            boolValue2 = null;

            

            //Convert options :

            int? element = 45;
            int element2 = (int)element;
            double element3 = (double)element;

            Console.WriteLine(element2);

            //int? a = null;
            //int b = (int)a; 
            //Console.WriteLine("b : " ,b);

            int value = 12;
            int? refValue = value;
            Console.WriteLine(refValue);

            int x = 45;
            int y = 11;
            int? c = (x + y);
            Console.WriteLine("c : " + c);

            double? k = 45.34;
            double? l = 23.43;
            double m = (double)(k + l);
            Console.WriteLine("m : " + m);

            
        }
        

    }
}
