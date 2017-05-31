# C-Simples

using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;

namespace Demo7 { class Program {

    static void Main(string[] args)
    {

        RealSingleton r = RealSingleton.Obj;

        Car oto = Car.Auto;
        oto.Brand = "BMW";

        Car oto2 = Car.Auto;
       // oto2.Brand = "Audi";
        Console.WriteLine("Oto2 brans is .. " + oto2.Brand);
        // Console.WriteLine("Oto1 brans is .. " + oto.Brand);

        Console.ReadKey();
    }
}
}
