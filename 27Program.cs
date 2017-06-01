# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 1, 2, 3, 8, 6, 9, 7 };
            Collection collection = new Collection(Array);

            foreach (var i in collection)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
