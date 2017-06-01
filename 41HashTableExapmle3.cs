# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTableExapmle3
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable mySourceHT = new Hashtable();
            mySourceHT.Add("A", "valueA");
            mySourceHT.Add("B", "valueB");

            String[] myTargetArray = new String[15];
            myTargetArray[0] = "The";
            myTargetArray[1] = "quick";
            myTargetArray[2] = "brown";
            myTargetArray[3] = "fox";
            myTargetArray[4] = "jumped";
            myTargetArray[5] = "over";
            myTargetArray[6] = "the";
            myTargetArray[7] = "lazy";
            myTargetArray[8] = "dog";
            
 
            Console.WriteLine("After copying the keys, starting at index 6:");
            mySourceHT.Keys.CopyTo(myTargetArray, 6);


            foreach (object obj in myTargetArray)
            {
                Console.WriteLine(obj);
            }

     
            Console.WriteLine("After copying the values, starting at index 6:");
            mySourceHT.Values.CopyTo(myTargetArray, 6);

            foreach (object obj in myTargetArray)
            {
                Console.WriteLine(obj);
            }



            Console.ReadKey();
        }

     
    }
}
