# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedAndInterface
{
    sealed class BaseClass
    {
        public static int MyProperty { get; set; }
        public static void BaseMethod()
        {
          
        }   
        public void Apply()
        {
            Console.WriteLine("Done");
        }
    }
    //class DerivedClass : BaseClass // can not be inherited (Because of the sealed word)
    //{
    //    public void DerivedMethod()
    //    {

    //    }
    //}

}
