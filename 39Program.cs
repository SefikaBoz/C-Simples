# C-Simple


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_24_05_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowClass<int, string> obj = new ShowClass<int, string>();
            obj.elem1 = 4;
            obj.elem2 = "elem";
            //obj.Show();

            //ShowClass<int, int> newObj = new ShowClass<int, int>();

            //AClass<ShowClass<int,int>> aclassObj = new AClass<ShowClass<int,int>>();
            //aclassObj.Get(obj.elem1);

            DefaultClass<int> defaultObj = new DefaultClass<int>();
            //Console.WriteLine(defaultObj.Options(65, 8));

            Options<string> optionObj = new Options<string>();
            optionObj.Option(obj.elem2, "get");

            Person p = new Person();
            Option<string> endOptionObj = new Option<string>();
            Console.WriteLine(endOptionObj.OptionMethod(p.Name));

            Console.ReadLine();
        }
    }
    class ShowClass<T, K> : IGet<T, K>
    {
        public T elem1 { get; set; }
        public K elem2 { get; set; }
        public void Show()
        {
            Console.WriteLine(elem1 + "" + elem2);
        }
    }
    interface IGet<T, K>
    {
        void Show();
    }
    class AClass<T>
    {
        int b = 12;
        public int Get(T a)
        {
            return 0;
        }
        public int Get(int a)
        {
            return b;
        }
    }
}
