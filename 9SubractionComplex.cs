# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStructorNumerEnumerations_3
{
    class SubractionComplex
    {
        private double mReel { get; set; }
        private double mVirtual { get; set; }

        public double Reel
        {
            set
            {
                Reel = value;
            }
            get
            {
                return mReel;
            }
        }
        public double Virtual
        {
            set
            {
                Virtual = value;
            }
            get
            {
                return mVirtual;
            }
        }
        public SubractionComplex()
        {
            mVirtual = 0;
            mReel = 0;
        }
        public SubractionComplex(double a ,double b)
        {
            mReel = a;
            mVirtual = b;
        }
        public static SubractionComplex operator -(SubractionComplex s1 , SubractionComplex s2)
        {
            double reelSub = s1.Reel - s2.Reel;
            double virtSub = s1.Virtual - s2.Virtual;
            return new SubractionComplex(reelSub,virtSub);
        }

        public void WriteScreen()
        {
            Console.WriteLine(mReel + "" + mVirtual + "j");
        }

    }
}
Contact GitHub API Training Shop Blog About
© 2017 GitHub, Inc. Terms Privacy Security 
