# C-Simples

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstraintsAtGenerics
{
    class ConstraintsClass
    {

    }
    class Cat : Mammal
    {
        public override void Speak()
        {
            Console.WriteLine("Miyav");
        }
    }
    class Dog : Mammal
    {
        public override void Speak()
        {
            Console.WriteLine("Havv hav");
        }

    }
    class Bat : Mammal
    {
        public override void Speak()
        {
            Console.WriteLine("Yarasa sesi");
        }
    }
    class TheTalking<T> where T : Mammal // belirtilen tur mammal türünden türemiş olmalıdr
    {
        private T mammal;
        public TheTalking(T t)
        {
            mammal = t;
        }
        public void Talking()
        {
            mammal.Speak();
        }

        public void MammalSpeak(T t)
        {
            t.Speak();
        }
    }
    abstract class Mammal
    {
        abstract public void Speak();
    }
    class Comparator<T> where T : IComparable<T>
    {
        public static int ToComparator(T a, T b)
        {
            return a.CompareTo(b);
        }
    }
    class ArithmeticOptions<T> where T : struct
    {
        // template typeın struct yapıda olmasına zorlar.
    }
    class Vehicle<T> where T : class
    {

    }
    class Animal<T> where T : class, IComparable, ICloneable, IDisposable, IEnumerable<T>, new()
    {
        public T MyTProperty { get; set; }
        public void Test(T t)
        {
            MyTProperty = t;
            Console.WriteLine(MyTProperty);
        }
    }
    class AClass : IEnumerable,IComparable, ICloneable, IDisposable // Coklu kullanım
    {
        public object Clone()
        {
            object o = 5;
            return o;
        }

        public int CompareTo(object obj)
        {
            return 5;
        }

        public void Dispose()
        {
            Console.WriteLine();
        }

        public IEnumerator GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    public class BinaryList<KeyType, ValueType> where KeyType : IComparable, IEnumerable
                                               where ValueType : Customer
    {
       public void Add(KeyType key, ValueType value)
        {
            int x = 9; // örnk
            switch (key.CompareTo(x))
            {
                //..
            }
        }
    }
    public class Customer
    {

    }
}
