# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Attribute
{
   
    class Program
    {
        //[DllImport("User32.dll")]
        //public static extern int MessageBox(int family, string message, string title, int type);
  

        static void Main(string[] args)
        {
            //    Attribute attribute = new Attribute();
            //    attribute.English();
            //    attribute.Turkce();

            //    Class1 c1 = new Class1();
            //    c1.M();

            //    MessageBox(0, "This is a message", "C#", 1);

          
            A a = new A();
            a.Method();
           
            B b = new B();
            b.NewMethod();

            //  b.OldMethod();   // Generates an error



            Console.ReadKey();
        }
    }
}
