# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateTypeMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Maximum<int>(45, 65));
            Console.WriteLine(Maximum<string>("jany", "chan"));

            string maxString = Maximum("mary", "janet");
            Console.WriteLine("Max string : " + maxString);

            int maxInt = Maximum(546, 711);
            Console.WriteLine("Max number : " + maxInt);

            Console.ReadLine();
        }
        public static T Maximum<T>(T parameter1, T parameter2) where T : IComparable
        {
            T retvalue = parameter2;
            if (parameter2.CompareTo(parameter1)<0)
                retvalue = parameter1;
            return retvalue;
        }
    }
}
