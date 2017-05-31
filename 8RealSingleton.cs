# C-Simples


using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;

namespace Demo7 { public class RealSingleton { private static RealSingleton obj;

    private RealSingleton()
    {

    }
    //public static RealSingleton Obj()
    //{
    //    if (obj == null)
    //        obj = new RealSingleton();
    //    return obj;
    //}
    public static RealSingleton Obj
    {
        get
        {
            if (obj == null)
                obj = new RealSingleton();
            return obj;

        }   
    }                             

 
}
}
