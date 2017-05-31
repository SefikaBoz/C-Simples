# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpaces
{
    class UsingTest : IDisposable
    {
  
        public void Dispose()
        {
               Console.WriteLine("Called the Dispose() method");
        }
    }
}
