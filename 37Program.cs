# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatesAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Dog> pets = new Pets();
            pets.GetEnumerator();

            IEnumerable<Cat> pet = new Pets();
            pet.GetEnumerator();

            Console.ReadLine();
        }
    }
}
