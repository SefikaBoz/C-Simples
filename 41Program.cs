# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList aList = new ArrayList(2);
            aList.Add(1);
            aList.Add(2);
            Console.WriteLine(aList.Capacity);
            aList.Add(3);
            Console.WriteLine(aList.Capacity);
            aList.Add(4);
            aList.Add(5);
            Console.WriteLine(aList.Capacity);
            aList.Insert(3, 6666);
            Console.WriteLine("aList[1]: " + aList[1]);

            ArrayList alist = ArrayList.FixedSize(aList);
            //for (int i = 0; i < 10; i++)
            //{
            //    alist.Add(i); //error index tasşması
            //}

            ArrayList myArrayList = new ArrayList();
            myArrayList.Add("william");
            myArrayList.Add("george");
            myArrayList.Add("michael");
            myArrayList.Add("margret");

            ArrayList mySecondArrayList = new ArrayList();
            mySecondArrayList.Add("ahmet");
            mySecondArrayList.Add("ayse");
            mySecondArrayList.Add("nejat");

            myArrayList.AddRange(mySecondArrayList); 
            Console.WriteLine("MyArrayList elements : ");
            myArrayList.Sort(); // listenin son hali sıralanır.
          

            foreach (object obj in myArrayList)
            {
                Console.WriteLine(obj);
            }


            foreach (object obj in aList)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List' s element count : " + aList.Count);
            Console.WriteLine("aList is fixedSize ? :" + aList.IsFixedSize);


            ArrayList newArrayList = new ArrayList(25);
            newArrayList.Add(465);
            newArrayList.Add(12);
            newArrayList.Add(124);
            newArrayList.Add(120);

            Console.WriteLine("124 elemanı dizide var mı ? : " + newArrayList.BinarySearch(124)); 
            newArrayList.Reverse();
            foreach (object obj in newArrayList)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("newArrayList.Capacity : " + newArrayList.Capacity);
            newArrayList.Remove(465);
            newArrayList.Remove(12);
            Console.WriteLine("newArrayList.Capacity : " + newArrayList.Capacity);
            newArrayList.Clear();
            Console.WriteLine("newArrayList.Capacity : " + newArrayList.Capacity); 
            newArrayList.TrimToSize();
            Console.WriteLine("newArrayList.Capacity : " + newArrayList.Capacity); 

            Console.WriteLine("newArrayList dizisinde 12 elemanı var mıdır ? : " + newArrayList.Contains(12));

            


            Console.ReadLine();
        }
    }
}
