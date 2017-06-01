# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtGenericsPolimorfizm
{
    public class BaseClass<U>
    {
        private U element;
        public BaseClass(U param)
        {
            this.element = param;
        }
    }
    public class DerivedClass<T, U> : BaseClass<U>
    {
        private T derivedElement;
        public DerivedClass(T p1, U p2) : base(p2)
        {
            this.derivedElement = p1;
        }
    }
    public class DerivedClass2<T> : BaseClass<int>
    {
        private T derivedElement;
        public DerivedClass2(T p1, int p2) : base(p2)
        {
            this.derivedElement = p1;
        }
        public DerivedClass2(T p1, string p2, int p3) : base(p3)
        {
            Console.WriteLine("{0},{1},{2}",p1,p2,p3);
        }
    }
    public class DerivedClass3<T> : BaseClass<string>
    {
        private T derivedElement;
        public DerivedClass3(string p1, T p2) : base(p1)
        {
            this.derivedElement = p2;
        }
    }
}
