# C-Simples

using System; 
using System.Collections.Generic; 
using System.Linq; using System.Text; 
using System.Threading.Tasks;

namespace Demo4 { class IrregularArray { public static void IrregulararrayDef() { int[][] array = new int[3][]; array[0] = new int[1]; array[1] = new int[2]; array[4] = new int[4]; } public static void IrregulararrayExmp() { int[][] array = new int[3][]; array[0] = new int[] { 1, 2, 3 }; array[1] = new int[] { 4, 5, 6, 7 }; array[2] = new int[] { 8, 9 }; for (int i = 0; i < array.GetLength(0); i++) { for (int j = 0; j < array[i].GetLength(0); j++) { Console.WriteLine("Array [" + i + " " + j + "] = " + array[i][j]);

            }
        }
    }
    public static void IrregularExp()
    {
        int[][] array = new int[4][];
        array[0] = new int[] { 0, 1, 2, 3 };
        array[1] = new int[] { 4, 5 };
        array[2] = new int[] { 6, 7 };
        array[3] = new int[] { 8, 9, 10 };
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array[i].GetLength(0); j++)
            {
                Console.Write(array[i][j] +" ");
            }
            Console.WriteLine();
        }

        
    }

}
}
