# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStructorNumerEnumerations_4
{
    class BookIndexer
    {
        private int [] array;
        private double[] array2;
        public BookIndexer(int ArrayLength)
        {
            array = new int[ArrayLength];
        }
        public int ArraySize
        {
            get
            {
                return array.Length;
            }
        }

        public int this[int index]
        {
            set
            {
                array[index] = value;
            }
            get
            {
                return array[index];
            }
        }
        public double this[double index]
        {
            get
            {
                return array2[(int)index];
            }
            set
            {
                array2[(int)index] = value;
            }
        }
       
    }
}
