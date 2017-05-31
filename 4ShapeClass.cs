# C-Simples

using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;

namespace Demo4 { class ShapeClass { public static void Shape() { int val = 15; int[,] dizi = new int[val, val];

        for (int i = 0; i < val; i++)
        {
            for (int j = 0; j < val; j++)
            {
                if (j == i)
                {
                    dizi[i, j] = 1;
                    dizi[i, val - j - 1] = 1;
                }
                if (i == val / 2)
                {
                    dizi[i, j] = 1;
                }
                if (j == val / 2)
                {
                    dizi[i, j] = 1;
                }
            }
        }
        for (int i = 0; i < val; i++)
        {
            for (int j = 0; j < val; j++)
            {
                if (dizi[i, j] == 1)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
}
