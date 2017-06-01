# C-Simples


#define DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Attribute
{
    class Class1
    {
        [Conditional ("DEBUG")]
        public void M()
        {
            Console.WriteLine("Execute Class1.M");
        }
    }
   
}
