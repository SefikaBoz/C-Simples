# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute2
{

[System.AttributeUsage(AttributeTargets.Method)]
    class ControlAttribute : Attribute
    {
        public ControlAttribute()
        {
            Console.WriteLine("Control attribute triggered");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
