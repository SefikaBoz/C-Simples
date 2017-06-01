# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatGenericsIntroduction
{
    class Point<T>
    {
        public T X { get; set; }
        public T Y { get; set; }
        
        public Point(T xval, T yval)
        {
            X = xval;
            Y = yval;
        }
        public void ResetPoint()
        {
            X = default(T);
            Y = default(T);
        }
    }
}
