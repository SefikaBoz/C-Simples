# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;
namespace Test
{
    class VirtualBaseClass
    {
        public virtual void BaseVirtualMethod()
        {
            Console.WriteLine("Base Class VirtualMethod");
        }      
    }
    class DerivedVirtClasss : VirtualBaseClass
    {
        public override void BaseVirtualMethod()
        {
            Console.WriteLine("Derived Class VirtualMethod");
        }
    }
    class EndClass : DerivedVirtClasss
    {
        public override void BaseVirtualMethod()
        {
            Console.WriteLine("EndClass Class VirtualMethod");
        }
    }
    class End2Class : EndClass
    {
        public override void BaseVirtualMethod()
        {
            base.BaseVirtualMethod();
        }
    }
    abstract class AbsClass
    {
        public abstract int MyProperty { get; set; }
    }
    class DerAbClass : AbsClass
    {
        public override int MyProperty
        {
            get { return 6; }
            set { }
        }
    }
}
