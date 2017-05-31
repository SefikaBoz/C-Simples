# C-Simples

using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;

namespace Demo5 { class ArrayAndMethod { public static void WriteArray(int[] array) { foreach (var item in array) { Console.WriteLine(item); } }

    public static void WriteArrayForAllTypes(Array array, int number)
    {
        foreach (Object item in array)
        {
            if (number == 0)
                Console.WriteLine(item);
            else
                Console.Write(item + " ");
        }
    }
    
}
}
