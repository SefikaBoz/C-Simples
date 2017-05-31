# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStructorNumerEnumerations_4
{
    class MultiDimensionalIndexerExamp
    {
        private int[,] array;

        public MultiDimensionalIndexerExamp(int Size1, int Size2)
        {
            array = new int[Size1, Size2];
        }
        public int Size1
        {
            get
            {
                return array.GetLength(0);
            }
        }
        public int Size2
        {
            get
            {
                return array.GetLength(1);
            }
        }
        public int this[int index1 , int index2]
        {
            get
            {
                return array[index1, index2];
            }
            set
            {
                array[index1, index2] = value;
            }
        }
    }
}
