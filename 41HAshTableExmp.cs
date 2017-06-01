# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable(); 
            hashtable.Add("myKey", "myValue");
            hashtable["myKey2"] = "myValue2";
            hashtable[4] = 879764;
            Person person = new Person { Name = "Janet" };
            hashtable[person] = person.Name;
            //Console.WriteLine(hashtable["myKey"]);
            //Console.WriteLine(hashtable["myKey2"]);
            //Console.WriteLine(hashtable[4]);

            Console.WriteLine("hashtable ın total element count ı : " + hashtable.Count);
            ICollection myKey = hashtable.Keys;
            foreach (object key in myKey) 
            {
                Console.WriteLine(hashtable[key]);
            }

            Hashtable myHashTable = new Hashtable();
            myHashTable.Add("Araba", "Car");
            myHashTable.Add("Masa", "Table");
            myHashTable.Add("Kalem","Pencil");
            myHashTable["Kitap"] = "Book";
            myHashTable["Bilgisayar"] = "Computer";

            ICollection keys = myHashTable.Keys;
            //foreach (string key in keys)
            //{
            //    Console.WriteLine(key + "=" + myHashTable[key]);
            //}
            Console.WriteLine("Total word : " + myHashTable.Count);

            myHashTable.Remove("Araba");

            myHashTable.Clear();
            Console.WriteLine("Total word : " + myHashTable.Count);
           

            Console.ReadLine();
        }
    }
    class Person
    {
        public string Name { get; set; }
    }
   
}
