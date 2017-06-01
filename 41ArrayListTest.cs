# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListTest2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            ArrayList mySourceList = new ArrayList();
            mySourceList.Add("three");
            mySourceList.Add("napping");
            mySourceList.Add("cats");
            mySourceList.Add("in");
            mySourceList.Add("the");
            mySourceList.Add("barn");
 

            string[] myTargetArray = new string[15];
            myTargetArray[0] = "The";
            myTargetArray[1] = "quick";
            myTargetArray[2] = "brown";
            myTargetArray[3] = "fox";
            myTargetArray[4] = "jumped";
            myTargetArray[5] = "over";
            myTargetArray[6] = "the";
            myTargetArray[7] = "lazy";
            myTargetArray[8] = "dog";

            mySourceList.CopyTo( 0,myTargetArray,9,6);
            foreach (object obj in myTargetArray)
            {
                Console.WriteLine(obj);
            }

            ArrayList list = new ArrayList(5);
            list.Add("B");
            list.Add("G");
            list.Add("J");
            list.Add("S");
            list.Add("M");

            string[] array1 = new string[list.Count];
            list.CopyTo(array1, 0);

            ArrayList a = new ArrayList();
            a.CopyTo(array1,0);// Mutlaka tipi belli bir diziye kopyalama yapılmalı.
         
            Console.WriteLine("Array 1:");
            foreach (string s in array1)
            {
                Console.WriteLine("\t{0}", s);
            }

            Console.WriteLine("\n\n\n");

            ArrayList trackArray = new ArrayList();
            trackArray = list.GetRange(0, list.Count-3);
            foreach (object obj in trackArray)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("Total element : " + trackArray.Count);
            trackArray.Clear();
            Console.WriteLine("Total word : " + trackArray.Count);
            Console.WriteLine("trackArray capacity : " + trackArray.Capacity);
            Console.ReadKey();
        }

    }
}
