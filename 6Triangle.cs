# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6
{
    class Triangle
    {
        public int BaseEdge { get; set; }
        public int Height { get; set; }
        public void SetTriangle(int BaseEdge, int Height)
        {
            if (BaseEdge < 0 || Height < 0)
            {
                BaseEdge = 1;
                Height = 1;
            } 
            else
            {
                this.BaseEdge = BaseEdge;
                this.Height = Height;

                //BaseEdge = BaseEdge;
                //Height = Height;
            }
        }
        public int Area()
        {
            return BaseEdge * Height / 2;
        }

    }
}
