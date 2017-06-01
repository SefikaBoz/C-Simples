# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTableExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable dictionary = new Hashtable();
            dictionary.Add("araba", "car");
            dictionary.Add("masa", "table");
            dictionary.Add("kalem", "pencil");
            dictionary.Add("kitap", "book");

            //ICollection keys = dictionary.Keys;
            //foreach (object key in keys)
            //{
            //    Console.WriteLine(dictionary[key]);
            //}

            IDictionaryEnumerator ide = dictionary.GetEnumerator();
            while (ide.MoveNext())
            {
                Console.WriteLine(ide.Key + "=" + ide.Value);
            }

            dictionary.Clear();
            Console.WriteLine("Total words : " + dictionary.Count);
            string[] array = new string[20];
            dictionary.Keys.CopyTo(array, 0);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadLine();
        }
    }
}
