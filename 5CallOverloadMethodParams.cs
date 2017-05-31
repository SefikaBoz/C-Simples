# C-Simples


using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;

namespace Demo5 { 
public class CallOverloadMethodParams { 
public void Call(int a , params object [] obj) 
{ Console.WriteLine("Called 1.method"); } 
public void Call(int a , object b) 
{ Console.WriteLine("Called 2.method"); 
}
}
}
