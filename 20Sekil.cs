# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
     abstract class Sekil
    {
        public int X { get; set; }
        public int Y { get; set; }
        public abstract void WhatAmI();

        public void Write()
        {
            Console.WriteLine("WriteMethod");
        }
        public abstract void Mandatory();
        
        
    }
}
