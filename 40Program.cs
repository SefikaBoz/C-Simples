# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstraintsAtGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Options<int> optionsObj = new Options<int>();
            optionsObj.GetOptions();

            Options<string> optionsStr = new Options<string>();
            optionsStr.GetOptions();

            Options<bool> optionsBool = new Options<bool>();
            optionsBool.GetOptions();

            Options<Person> optionsPerson = new Options<Person>();
            optionsPerson.GetOptions();
            Person person = new Person();

            OptionsTest<int> testObj = new OptionsTest<int>();
            testObj.GetTestOptions(person.TC);

            Console.WriteLine("\n\n");

            TheTalking<Dog> dog = new TheTalking<Dog>(new Dog());
            dog.Talking();

            Cat c = new Cat();
            TheTalking<Cat> cat = new TheTalking<Cat>(c);
            cat.Talking();

            TheTalking<Bat> bat = new TheTalking<Bat>(new Bat());
            bat.Talking();

            Console.WriteLine("Mammal speak method..");
            bat.MammalSpeak(new Bat());

            Console.WriteLine("\n\n");
            Console.WriteLine("End denemeler..");

            TheTalking<Mammal> mammal = new TheTalking<Mammal>(new Cat());
            Console.WriteLine("Mammal için talking..");
            mammal.Talking();

            Console.WriteLine("Dog için mammal speak..");
            mammal.MammalSpeak(new Dog());

            Console.WriteLine("Cat için mammal speak..");
            mammal.MammalSpeak(new Cat());

            Console.WriteLine("IComparable interfaceinden derived olanlar için example ..");

            int temp1 = Comparator<int>.ToComparator(4, 5);

            int tempStr = Comparator<string>.ToComparator("action", "action");

            int tempDateTime = Comparator<DateTime>.ToComparator(DateTime.Now, DateTime.Now.AddDays(1));

            int tempDecimal = Comparator<decimal>.ToComparator(4456546m, 9653.565m);

            Console.WriteLine("temp1 : {0} , tempStr : {1} , tempDateTime : {2} , tempDecimal : {3}" , temp1, tempStr, tempDateTime, tempDecimal);

            //AClass aclass = new AClass();
            //object obj = aclass.GetEnumerator();

           Console.ReadLine();
        }
    }
 class Options<T>
    {
        public void GetOptions()
        {
            T temp = default(T);
            Console.WriteLine(temp);
            Console.WriteLine("hello");
        }
    }
    class Person
    {
        public string Name  { get; set; }
        public int TC { get; set; }
    }
    class OptionsTest<T>
    {
        public void GetTestOptions(T tempValue)
        {
            T a;
            a = tempValue;
            tempValue = default(T);
            Console.WriteLine("A : " + a);
            Console.WriteLine("TempValue : " + tempValue);
        }
    }
}
