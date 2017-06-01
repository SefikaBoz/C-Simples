# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
     abstract class Dikdortgen : Sekil
    {
         public override void WhatAmI()
        {
            Console.WriteLine("I am a rectangle..");
        }
         public abstract void NormalMethod();

        public override void Mandatory()
        {
            Console.WriteLine("override mandatory");
        }
}
}
