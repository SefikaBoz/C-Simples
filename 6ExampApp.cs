# C-Simples

using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;

namespace Demo6 { class ExampApp { public double [] Exampapp(params double [] array) {

        double [] sqrtArray = new double [array.Length];
        for (int i = 0; i < array.Length; i++)
        {
          double temp = array[i];
            sqrtArray[i] = Math.Sqrt(temp);
        }
        return sqrtArray;
    }

    public int fib(int a)
    {
        if (a == 0)
            return 0;
        if (a == 1)
            return 1;
        return fib(a - 1) + fib(a - 2);
    }
}
}
