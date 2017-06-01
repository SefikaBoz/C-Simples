# C-Simples


using IPluginInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    public class Class1 : ICalculate
    {
        public int ToCalculate(int a, int b)
        {
            return a + b;
        }

        public string Name
        {
            get
            {
                return "toplama";
            }
        }
        
    }
}
