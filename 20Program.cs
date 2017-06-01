# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            KucukDikdortgen kd = new KucukDikdortgen();
            kd.Write();

            DerivedClass der = new DerivedClass();
            der.BaseMethod();

            der.AbstractMethod();


            DerivedDerivedClass ddclas = new DerivedDerivedClass();
            ddclas.BaseMethod();
            ddclas.AbstractMethod();

            Console.WriteLine();

            DerDerDerivedClass dd = new DerDerDerivedClass();
            dd.AbstractMethod();
            dd.BaseMethod();

            A a = new A();
            a.BaseMethod();

            DerivedVirtClasss d = new DerivedVirtClasss();
            d.BaseVirtualMethod();

            EndClass en = new EndClass();
            en.BaseVirtualMethod();

            End2Class e2 = new End2Class();
            e2.BaseVirtualMethod();


            Console.ReadLine();
        }
    }
}
