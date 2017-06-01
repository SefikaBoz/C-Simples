# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypesAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Options<int> optionsObj = new Options<int>();
            Console.WriteLine(optionsObj.Addition(45, 6));

            Console.ReadLine();
        }
    }
    public class Options<T>
    {
        public int Addition(T a, T b)
        {
            return 0;
        }
        public int Addition(int a, int b)
        {
            return a + b;
        }
    }
}
