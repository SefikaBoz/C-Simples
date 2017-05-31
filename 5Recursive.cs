# C-Simples


using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;

namespace Demo5 { class Recursive { public static int factoriel(int fact) { if (fact == 0) return 1; return fact * factoriel(fact - 1);

    }

    public static void BitWrite(int num)
    {
        if (num == 0)
            return;
        BitWrite(num >> 1);
        Console.Write(num & 1);
    }
    public static int ConsecutiveSum(int number)
    {
        if (number == 0)
            return 0;
        else if (number == 1)
        {
            return 1;
        }
        return number + ConsecutiveSum(number - 1);

    }
    public static void ShowNumber(int number)
    {
        if (number > 1)
            ShowNumber(number - 1);
        Console.Write(" " + number);
    }
}
}
