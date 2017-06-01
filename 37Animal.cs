# C-Simples


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatesAndInterface
{
    class Animal { }
    class Cat : Animal { }
    class Dog : Animal { }
    class Pets : IEnumerable<Cat>, IEnumerable<Dog>
    {
        IEnumerator<Cat> IEnumerable<Cat>.GetEnumerator()
        {
            Console.WriteLine("Cat chosen");
            return null;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            // Some code.
            return null;
        }
        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            Console.WriteLine("Dog chosen");
            // Some code.
            return null;
        }
    }
   
}
