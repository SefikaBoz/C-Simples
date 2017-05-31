# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatWorks
{
    class NamedAndOptional
    {
        public int Method(int a = 6, int b = 3)
        {
            return a + b;
        }

        public int Method2(int a, int b, int c = 9, int d = 0)
        {
            return a + b + c + d;
        }

    
    }
}
