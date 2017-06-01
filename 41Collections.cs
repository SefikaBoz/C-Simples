# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections_25_05_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            //AClass obj = new AClass();
            //ArrayList arr = new ArrayList(obj);

            //ArrayList aList = new ArrayList();
            //Console.WriteLine("Default capacity : " + aList.Capacity);
            //aList.Add(4);
            //aList.Add("december");
            //aList.Add('B');
            //aList.Add(454.78m);
            //aList.Add(4564.4f);
            //aList.Add(true);
            //WriteDisplay(aList);

            //Console.WriteLine();
            //aList.Remove("december");

            //WriteDisplay(aList);

            
            
            ArrayList AList = new ArrayList();
            AList.Add("january");
            AList.Add("february");
            AList.Add("march");
            AList.Add("april");
            ArrayListExample arrayListExapmle = new ArrayListExample(45);
            AList.Add(arrayListExapmle);

            foreach (object obj in AList)
            {
                //Console.WriteLine((string)obj);
            }

            Console.ReadLine();

        }
        public static void WriteDisplay(ArrayList list)
        {
            foreach (object obj in list)
            {
                Console.Write(" " + obj);
            }
        }
    }
    class ArrayListExample
    {
        int x;
        public ArrayListExample(int x)
        {
            this.x = x;
        }

    }

    class AClass : ICollection
    {
        public int Count
        {
            get
            {
                return 5;
            }
        }

        public bool IsSynchronized
        {
            get
            {
                return true;
            }
        }

        public object SyncRoot
        {
            get
            {
                return new AClass();
            }
        }

        public void CopyTo(Array array, int index)
        {
            Console.WriteLine("CoptTo");
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
