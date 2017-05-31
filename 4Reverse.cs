# C-Simples

using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;

namespace Demo4 { class Reverse { public static void ToReverse() { string temp; string[] array = new string[] { "john", "jack", "jany" }; for (int i = 0; i < array.Length / 2; i++) { temp = array[i]; array[i] = array[array.Length - 1 - i]; array[array.Length - 1 - i] = temp; } foreach (var item in array) { Console.WriteLine(item); }

    }
  
    public static void ExampleArray()
    {
        int[] array = new int[20];
        Random rnd = new Random();

        int max = 0, min = 100, total = 0;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(1, 100);
            if (array[i] > max)
                max = array[i];
            else if (array[i] < min)
                min = array[i];
            total += array[i];
        }

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Max : " + max);
        Console.WriteLine("Min : " + min);
        Console.WriteLine("Ortalama : " + (float)total/(float)array.Length);


    }
}
}
