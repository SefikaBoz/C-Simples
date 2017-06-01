# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Member m = new Member();

            Console.WriteLine();

            Moderator moderator = new Moderator();

            Console.WriteLine(moderator.Ad);

            Console.WriteLine(m.Ad);

            Member mem1 = new Member
            {
                Ad = "John"
            };
            Moderator mod1 = new Moderator
            {
                Ad = "Jill"
            };

            if (mod1 is Member)
                Console.WriteLine(mod1.Ad + " is member..");
            else
                Console.WriteLine(mod1.Ad + " is not member..");

            if (mem1 is Moderator)
                Console.WriteLine(mem1.Ad + " is member..");
            else
                Console.WriteLine(mem1.Ad + " is not member..");


            SubLine s = new SubLine();


            A a = new A();

            C c = new C();
            Console.WriteLine(c.getValue());
            

       

            Console.ReadKey();
        }
    }
}
