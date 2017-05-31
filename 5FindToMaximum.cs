# C-Simples


using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;

namespace Demo5 { class FindToMaximum { public static double FindMaximum(double num1, double num2) {

        if (num1 > num2)
            return num1;
        return num2;
    }
    public static double FindMaxiumum3Num(double num1, double num2, double num3)
    {
        return FindMaximum(FindMaximum(num1, num2), num3);
    }
    public static double FindMaxiumum4Num(double num1, double num2, double num3, double num4)
    {
        return FindMaximum(FindMaximum(num1,num2),FindMaximum(num3,num4));
    }
}
}
