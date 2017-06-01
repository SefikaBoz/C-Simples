# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics___3__25_05_2017
{
    class DelegateClass
    {
        public delegate T Delegate<T>(T s1, T s2 );
        public static int Add(int elem1, int elem2)
        {
            return elem1 + elem2;
        }
        public static float Add (float elem1, float elem2)
        {
            return elem1 + elem2;
        }
        public static string Add ( string elem1, string elem2)
        {
            return "" + elem1 + elem2;
        }

        public delegate T DelegateMethod<T>(T elem);

        public T Write<T>(T elem)
        {
            Console.WriteLine(elem);
            return elem;
        }
    }
    
}
