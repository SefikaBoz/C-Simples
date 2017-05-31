# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsAndEnumerations
{
    enum FORMAT : byte { vertical, horizontal}
    //enum FORMAT : byte { vertical = 5, horizontal = 10}
    //enum FORMAT : byte { vertical = 8, horizontal} 
    enum FORMATDAYS : byte { SUNDAY,MONDAY,TUESDAY,WEDNESDAY,THURSDAY,FRİDAY,SATURDAY}

    class EnumClass
    {
        public void ArrayWrite(Array array, FORMAT f)
        {
            foreach (Object o in array)
            {
                if (f == FORMAT.vertical)
                    Console.WriteLine(o.ToString());
                else
                    Console.Write(o.ToString() + " ");
            }
        }
    }
}
