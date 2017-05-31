# C-Simples



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6
{
    class Quadrirateral2
    {
        // get set sample code

        private int mHeight;
        private int mWidth;

        public int Height
        {
            get { return mHeight; }
            set
            {
                if (mHeight < 0)
                    mHeight = 0;
                else
                    mHeight = value;
            }
        }

        public int Width
        {
            get { return mWidth; }
            set
            {
                if (mWidth < 0)
                    mWidth = 0;
                else
                    mWidth = value;
            }
        }
        public int Area()
        {
            return mWidth * mHeight;
        }
        public void SetWidthHight(int mHeight, int mWidth)
        {
            if (mWidth < 0 || mHeight < 0)
            {
                mHeight = 0;
                mWidth = 0;
            }
            else
            {
                this.mWidth = mWidth;
                this.mHeight = mHeight;
            }      
        }
        public void QuadrirateralShow()
        {
            Console.WriteLine("Width :" + mWidth);
            Console.WriteLine("Hight :" + mHeight);
            Console.WriteLine("Area :" + Area());
        }
        public bool IsSquare() // Can be used member prop or set get methods
        {
            if (Width == Height)
                return true;
            else
                return false;
        }
        public double DiogonalLength()
        {
            return Math.Sqrt(mWidth*mWidth + mHeight + mHeight);
        }
    }
}
