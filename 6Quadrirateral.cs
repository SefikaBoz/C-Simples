# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6
{
    class Quadrirateral
    {
        public int Hight;
        public int Width;

        public int Area()
        {
            return Hight * Width;
        }
        public void SetWidthHight(int width, int hight)
        {
            if(width<0 || hight<0)
            {
                hight = 0;
                width = 0;
            }
            else
            {
                Hight = hight;
                Width = width;
            }
        }
        public void QuadrirateralShow()
        {
            Console.WriteLine("Width :" + Width);
            Console.WriteLine("Hight :" + Hight);
            Console.WriteLine("Area :" + Area());
        }
    }
}
