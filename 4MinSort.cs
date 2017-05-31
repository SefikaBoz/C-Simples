# C-Simples

using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;

namespace Demo4 { class MinSort { public static void Sort() { int[] fisrtArray = new int[] { 8, 9, 5, 4, 1, 2, 2, 0 }; int temp = 0;

        for (int i = 0; i < fisrtArray.Length - 1; i++)
        {
            for (int j = i + 1; j < fisrtArray.Length; j++)
            {
                if (fisrtArray[i] > fisrtArray[j])
                {
                    temp = fisrtArray[i];
                    fisrtArray[i] = fisrtArray[j];
                    fisrtArray[j] = temp;
                }
            }
        }

        foreach (var item in fisrtArray)
        {
            Console.WriteLine(item);
        }
    }

}
}
