# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseObj = new BaseClass();
            baseObj.Apply();

            Point p = new Point(4,8);
            Console.WriteLine("My Point : " );
            PrintPoint(p);           
          

            Console.ReadLine();
        }
        static void PrintPoint(IPoint p)
        {
            Console.WriteLine("X = {0} , Y = {1}" , p.X, p.Y);
        }
        static void Test(IPoint pp)
        {
          
            Console.WriteLine("" ,pp.X);
        }
    }
}
