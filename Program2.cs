# C-Simples

using System; 
using System.Collections.Generic; 
using System.Linq; using System.Text; 
using System.Threading.Tasks;

namespace CsharpDemo2 { 
class Program { 
  static void Main(string[] args) { 
    object customers = "Sefika"; 
    var s = customers as Customer;

        int i = 50;
        bool b = i is int;
        bool c = i is object;
        bool d = i is double;
        bool e = i is string;
        Console.WriteLine( ""+ b + c + d + e);
        Addition ad = new Addition();
        ad.Total();



        Type t = typeof(Addition);
        Console.WriteLine("t : " + t.ToString());

        Type t2 = typeof(Addition);

        Addition addition = new Addition();
        Type t3=addition.GetType();

        Console.WriteLine("t1 : " + t.ToString());
        Console.WriteLine("t2 : " + t.ToString());
        TransformTest.TransformTst();

       

        //object element = new Program();
        //string st = element as string;
        //element = "klj";


        //bool val = st is string;
        //Console.WriteLine(val);

        Console.ReadKey();
    }
}
}
