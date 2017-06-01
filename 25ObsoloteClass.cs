# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute
{
   
        [System.Obsolete("use class B")]
        class A
        {
            public void Method() { Console.WriteLine("Warning"); }
        }
        class B
        {
            [System.Obsolete("use NewMethod", true)]
            public void OldMethod() { Console.WriteLine("Warning"); }
            public void NewMethod() { }
        }

 
}
