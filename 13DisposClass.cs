# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpaces2
{
    class DisposClass : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Dispose () cagrildi..");
        }
    }
   
}
