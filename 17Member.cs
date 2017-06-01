# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Member
    {
        public string Ad { get; set; }
        public Member()
        {
            Ad = "I am Member";
            Console.WriteLine(Ad);
        }
        public void SendMessage()
        {
            Console.WriteLine("Message sent..");
        }
        
    }
}
