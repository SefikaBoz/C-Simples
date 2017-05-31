# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Customer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }

    }
    public enum Gender :short { Unknwon = 5, Male = 12, Female }
}
