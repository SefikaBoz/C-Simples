# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager man1 = new Manager("George");
            man1.Show();
            Employee e = new Manager("");
            e.Emp();
            Employee ee = new Manager("");
            ee.Emp();
          
          
           
            Console.ReadLine();
        }
    }
}
