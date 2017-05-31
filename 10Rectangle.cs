# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsAndEnumerations
{
    struct Rectangle
    {
      
        public int Edge1 { get; set; }
        public int Edge2 { get; set; }

        public Rectangle(int edge1, int edge2)
        {
            Edge1 = edge1;
            Edge2 = edge2;

        }
        public int CalculateArea(int edge1, int edge2)
        {
            int area = edge1 * edge2;
            return area;
        }
    }
   
}
