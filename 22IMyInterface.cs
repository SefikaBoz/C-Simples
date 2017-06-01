# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceReference
{
    interface IMyInterface
    {
        void MyMethod();
    }
    class MyClass : IMyInterface
    {
  
        public void MyMethod()
        {
            Console.WriteLine("MyClass method");
        }
    }
    class MyClass2 : IMyInterface
    {
        public void MyMethod()
        {
            Console.WriteLine("MyClass2 method");
        }
    }
}
