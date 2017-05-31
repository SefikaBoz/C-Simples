# C-Simples

using System; 
using System.Collections.Generic; using System.Linq; 
using System.Text; using System.Threading.Tasks;

namespace CsharpDemo2 { 
class Addition { 
  public int num1 = 89; public int num2 = 45; 
  public void Total() {

        num1 &= num2;
        Console.WriteLine(num1);

        int number = 78;
        string str = "";
        str = (number == 78 ? "true number" : "false number");
        Console.WriteLine(str);

        int num = 90;
        int k = 0;
        k = (num == 90 ? 5 : 4);


        byte a = 10;
        int b = (int)a;

        Console.WriteLine(a.GetType());
        Console.WriteLine(b);
        
        

    }
}
}
