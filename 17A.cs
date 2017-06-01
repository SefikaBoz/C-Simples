# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class A
    {
        private int value = 10;
        protected int val = 6;

        public class B : A
        {
            public int getValue()
            {
                return value + val;
            }
        }
    }
    public class C : A
    {
        public int getValue()
        {
            return val ;
            
        }
        public void Show()
        {
            Console.WriteLine(val);
        }

    }
    public class D : C
    {
        public int getValue()
        {
            return val;
        }
    }
    abstract class AbClass
    {
        public abstract void  As();
        public void Aaa()
        {
            Console.WriteLine("asdkaş");
        }
    }
    class Test : AbClass
    {
        public override void As()
        {
            Console.WriteLine();
        }
    }

}
