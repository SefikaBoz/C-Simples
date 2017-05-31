# C-Simples

using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;

namespace Demo5 { 
class ParamsClass { 
public static int Total(params int[] numbers) {
if (numbers.Length == 0) return 0; int total = 0; foreach (int number in numbers) { total += number; } return total; }

    public static string UnitWord(params string[] str)
    {
        string total = "";
        for (int i = 0; i < str.Length; i++)
        {
            total = total + str[i];
        }
        return total;
    }

    public static void ParamsExamp(int format, params object[] obj)
    {
        if (obj.Length == 0)
            return;
        else if (format == 0)
        {
            foreach (object o in obj)
            {
                Console.WriteLine(o.ToString() + " ");
            }
        }
        else
            foreach (object o in obj)
            {
                Console.Write(o.ToString() + " ");
            }

    }
  
}
}
