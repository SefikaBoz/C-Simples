# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTimeOperations_12._05._2017
{
    class BitConverterClass
    {
        public void BitConverterMethod()
        {
            if (BitConverter.IsLittleEndian)
                Console.WriteLine("LittleEndian architecture");
            else
                Console.WriteLine("BigEndian architecture");
        }
        public void BitConverterMethod2()
        {

            int a = 19785;
            byte[] aByte = BitConverter.GetBytes(a);
            foreach (byte b in aByte)
            {
                Console.Write(b + " ");
            }
            Console.WriteLine(aByte.Length);
            Console.WriteLine(BitConverter.ToInt32(aByte,0));

            int ghgh = 1571;
            byte[] bdizi = BitConverter.GetBytes(ghgh);
            foreach (byte b in bdizi)
            {
                Console.WriteLine(b);
            }
   
        }
    }
}
