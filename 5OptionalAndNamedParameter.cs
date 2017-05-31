# C-Simples


using System; 
using System.Collections.Generic; 
using System.Linq; using System.Text; 
using System.Threading.Tasks;

namespace Demo5 { 
class OptionalAndNamedParameter { 
public static void OptionalSample(
string a , string b = "bfirstParameter",int c = 34) {
Console.WriteLine("a = " + a +" b = " + b + " c = " + c); 
} 
public static void OptionalAndNamed(string a ="aa",string b = "bb", int c = 7) {
Console.WriteLine("Called first methods .."); 
Console.WriteLine("a = " + a +" b = " + b + " c = " + c); } 
public static void OptionalAndNamed(string a, string b) {
// call default Console.WriteLine("Called second methods .."); }

}
}
