# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_24_05_2017
{
    class DefaultClass<T>
    {
        public T Options(T elem, int param)
        {
            if (param >= 0)
                return elem;
            else
                return default(T);
        }
    }
    class Options<T>
    {
        public T Option(T elem , string param)
        {
            if (param == "get")
                return elem;
            else
                return default(T);
        }
    }
    class Option<T>
    {
        public T OptionMethod(T temp)
        {
           temp = default(T);
                
            Console.WriteLine(temp);
            return temp;           
        }
    }
    class Person
    {
        public string Name { get; set; }
    }
}
