# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AttributeExample2
{
    class Program
    {
        static void Main(string[] args)
        {

            Car.Scroll();
            Car.FlySpeed();
            
            Console.ReadLine();
        }
    }
    [AttributeUsage(AttributeTargets.Method)]
    class Fly : Attribute
    {     
        public Fly()
        {
            Console.WriteLine("Normal uc");
        }
       
    }
   [Fly]
    class Car
    {   
        public static void Scroll()
        {
            Console.WriteLine("Hızlı ilerle.");
        }
        [Fly]
        public static void FlySpeed()
        {
            Console.WriteLine("Hızlı uc");
        }
    }
 
}
