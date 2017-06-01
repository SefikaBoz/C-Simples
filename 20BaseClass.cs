# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    abstract class BaseClass
    {
        public virtual void BaseMethod()
        {
            Console.WriteLine("I am a virtual method in baseclass ..");
        }
        public virtual int number()
        {
            return 7;
        }
        public abstract void AbstractMethod();

    }
    class DerivedClass : BaseClass
    {
        public override void BaseMethod()
        {
            Console.WriteLine("Derived class ın BaseMethoduyum");
        }
        public override void AbstractMethod()
        {
            Console.WriteLine("Derived classın anstract metoduyum");
        }
    }
    class DerivedDerivedClass : DerivedClass
    {
        public override void AbstractMethod()
        {
            base.AbstractMethod();
        }
        public override void BaseMethod()
        {
            Console.WriteLine("I am basemethod in DerivedDerived class");
        }
    }

    class DerDerDerivedClass : DerivedDerivedClass
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("Would it be called Derderderderder ... :)");
        }
        public override void BaseMethod()
        {
            base.BaseMethod();
        }
    }
    class A : DerDerDerivedClass
    {
        public override void BaseMethod()
        {
            Console.WriteLine("A class ' s basemethod..");
        }
    }
    class B : BaseClass
    {
        public override void BaseMethod()
        {
            base.BaseMethod();
        }
        public override void AbstractMethod()
        {
            Console.WriteLine("B class 's abstract method..");
        }
    }
    abstract class AbClass
    {
        public void dene()
        {
            Console.WriteLine("What you will try?  ");
        }
    }
    class Deneme : AbClass
    {
        public void TestMethod()
        {
            Console.WriteLine("Trying..");
        }

    }
}
