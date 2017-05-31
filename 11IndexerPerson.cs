# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStructorNumerEnumerations_4
{
    class IndexerPerson
    {
        string[] Person = { "John", "Mary", "Jany", "Allen", "Jill" };
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= Person.Length)
                {
                    Console.WriteLine("0 ile {0} arasında bir sayi girin..", Person.Length - 1);
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Dizinin {0}. elemanı : {1}", x, Person[x]);
                    return null;
                }
                else
                    return Person[index];
                   
            }
            set
            {
                if (index < 0 || index >= Person.Length)
                {
                    Console.WriteLine("0 ile {0} arasında bir sayı girin..", Person.Length - 1);
                    ;
                }
                else
                    Person[index] = value;
            }
        }
        public int ArrayLenght
        {
            get
            {
                return Person.Length;
            }
        }
        


    }
}
