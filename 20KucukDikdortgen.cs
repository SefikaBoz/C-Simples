# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
     class KucukDikdortgen : Dikdortgen
    {
        public KucukDikdortgen()
        {        
        }
        public override void WhatAmI()
        {
            base.WhatAmI();
            Write();
        }
        public override void NormalMethod()
        {
            throw new NotImplementedException();         
        }
    }
     abstract class EnKucukDikdortgen : KucukDikdortgen
    {
        public override void WhatAmI()
        {
            string str = "John";
            Console.Write(str);
        }
        public override void Mandatory()
        {
            Console.Write("");
        }

    }
}
