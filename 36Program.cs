# C-Simples


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace RepeatGenericsIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = new string[] { "December", "November", "July" };

           
            ArrayList strAr = new ArrayList();

           // Console.WriteLine(stopwatch.ElapsedMilliseconds);
            strAr.Add("john");
            strAr.Add("william");
            strAr.Add("jack");
            strAr.Add("mary");
            strAr.Add(123);
            int a = (int)strAr[4];
            Console.WriteLine(a);

            List<int> intList = new List<int>();
         //   Console.WriteLine(stopwatch.ElapsedMilliseconds);

            string strA = "aaa";
            string strB = "bbb";

            Swap<string>(ref strA, ref strB);

            Console.WriteLine("A : " + strA);
            Console.WriteLine("B : " + strB);

            int a = 10;
            int b = 787;
            Swap<int>(ref a, ref b);
            Console.WriteLine("A : " + a);
            Console.WriteLine("B : " + b);

            Point<int> point = new Point<int>(10, 10);
            Console.WriteLine("{0}, {1}" , point.X , point.Y);
          

            Console.ReadLine();
        }
        // static void Swap(ref int a , ref int b)
        //{
        //    int temp;
        //    temp = a;
        //    a = b;
        //    b = temp;
        //}
        //static void Swap(string a,string b)
        //{
        //    string temp;
        //    temp = a;
        //    a = b;
        //    b = temp;
        //}
        static void Swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;

        }
    }
}
