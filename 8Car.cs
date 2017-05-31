# C-Simples


using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;

namespace Demo7 { class Car { static Car auto; private Car() { } public static Car Auto { get { if (auto == null) auto = new Car(); return auto; }
} string brand; public string Brand { get { return brand; } set { brand = value; } }

}
}
