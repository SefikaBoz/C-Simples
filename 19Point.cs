# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMsdn
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

    }
    public class Circle : Point
    {
        
        public int Radius { get; set; }
        public virtual double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    public class Cylinder : Circle
    {
        public int Height { get; set; }
        public override double CalculateArea()
        {
            return (2 * Math.PI * Radius * Height) + 2 * base.CalculateArea();
        }
    }
}
