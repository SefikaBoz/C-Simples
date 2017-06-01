# C-Simples

using System; using System.Collections.Generic; 
using System.Linq; using System.Text; 
using System.Threading.Tasks;

namespace Inheritance { 
  class Moderator : Member { 
    public Moderator() { 
    Ad = "I m moderator"; 
    Console.WriteLine(Ad); 
    } 
    public void DeleteMessage() { 
    Console.WriteLine("Message is deleted.."); 
    } 
  }
  
 }
