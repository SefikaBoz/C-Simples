# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStructorNumerEnumerations_4
{
    class Index
    {
        public int Number;
          
        public int this[int index]
        {
            get
            {
                return Number;
            }
            set
            {
                if (index > 0)
                    Number += value;
                else if (index < 0)
                    Number -= value;
                
            }
        }

    }
}
