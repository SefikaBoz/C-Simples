# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpaces2
{
    //Nested namespaces example
    class NestedNamesoacesExamp
    {
        public int number1 { get; set; }
        public int number2 { get; set; }
        public NestedNamesoacesExamp()
        {
            number1 = 12;
            number2 = 13;
        }
    }
    namespace Namespace3
    {
        class InnerClass
        {
            public int total { get; set; }
            public InnerClass()
            {
                total = 0;
            }
           
    }
        namespace Namespace4
        {
            class InInnerClass
            {
                public int elem { get; set; }
                public InInnerClass()
                {
                    

                }
            }
            namespace Newnamespace1.Newnamespace
            {
                class A
                {

                }
            }
        }
    }
}
