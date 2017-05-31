# C-Simples


using System; 
using System.Collections.Generic; 
using System.Linq; using System.Text;
using System.Threading.Tasks;

namespace Demo5 {
class ValueAndRefType { 
public static void ValueType(int value) {
value = 50; Console.WriteLine("At method value : " + value); } 
public static void ReferansType(string[] value) { value[0] = "December"; } 
public static void TestIntArray (int[] value) { value[0] = 100; } 
public static void UseOfRefWord(ref int x) { x = 50; } 
public static void TestUseRefString(ref string str) { str = "newStr"; } 
public static void OutWord(out int value) { value = 41;

    }

}
}
