# C-Simples

using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;

namespace Demo7 { public class Singleton { private static Singleton obj = new Singleton();

    private Singleton()
    {

    }
    public static Singleton Obj
    {
        get
        {
            return obj;
        }
    }
   
}
}
