# C-Simples


#define TURKCE
#define ENGLISH
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Attribute
{
    class Attribute
    {
        [Conditional("TURKCE")]
        public void Turkce()
        {
            Console.WriteLine("Merhaba Dünya");
        }
        [Conditional("ENGLISH")]
        public void English()
        {
            Console.WriteLine("Hello World");
        }
       

    }
}
