# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SortedListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Words = { "araba", "masa", "defter", "kitap", "defter","okul" };
            SortedList dictionary = new SortedList();
            dictionary.Add("araba", "car");
            dictionary.Add("masa", "table");
            dictionary.Add("kalem", "pencil");
            dictionary.Add("kitap", "book");
            dictionary.Add("bilgisayar", "computer");

            WriteDisplay(dictionary);

            for (int i = 0; i < Words.Length; i++)
            {
                if (dictionary.ContainsKey(Words[i]))
                    Console.WriteLine(Words[i] + " = " + dictionary[Words[i]]);
                else
                    Console.WriteLine(Words[i] + ", not found.." );
            }
            Console.WriteLine();
            dictionary.Add("dogru", "line");
            WriteDisplay(dictionary);
            Console.WriteLine();
            Console.WriteLine("Total element : {0} " , dictionary.Count);
            Console.WriteLine( "This elements ..");

            ICollection keys = dictionary.Keys;
            foreach (string str in keys)
            {
                Console.Write(str + "-");
            }
            Console.ReadLine();
        }
        public static void WriteDisplay(SortedList sList)
        {
            foreach (DictionaryEntry de in sList)
            {
                Console.WriteLine("{0, -12} : {1, -12}" , de.Key,de.Value);
            }
            Console.WriteLine();
        }
    }
    class Test1
    {
        public void ToTest()
        {
            SortedList sList = new SortedList();/
        }
    }
}
