# C-Simples


using ListCollectionExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsGiris
{
    class Program
    {
        static void Main(string[] args)
        {
            //List myList = new List();
            //myList.Add(3);

            //int value = (int)myList[0];
            //Console.WriteLine(value);


            Liste<object> list = new Liste<object>();
            list.Add("december");
            list.Add("november");
            list.Add('a');
            list.Add(456.25m);
            list.Add("september");


            Liste<int> myIntegerList = new Liste<int>();
            //myIntegerList("june"); error


            myIntegerList.Add(12);
            myIntegerList.Add(22);
            Console.WriteLine(myIntegerList[0]);
            Console.WriteLine("myIntegerList[0]. elements type is .. " + myIntegerList[0].GetType());
            int added = myIntegerList[0];
            Console.WriteLine("Added : " + added); 


            DateTime dateTimeObj = new DateTime(1992, 03, 12);
            Liste<DateTime> myDateList = new Liste<DateTime>();
            myDateList.Add(dateTimeObj);
            Console.WriteLine("My date list 0. element is .. " + myDateList[0]);


            Console.ReadLine();
        }
    }
}
