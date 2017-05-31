# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6
{   
    class Time
    {
        public int hour;
        public int minute;
        public int second;

        public Time(int h, int m, int s)
        {
            second = s % 60;
            int newMinute = m + s / 60;
            minute = newMinute % 60;
            hour = newMinute / 60 + h;

        }
        public Time(int m, int s) : this(0, m, s)
        {

        }
        public Time(int m) : this(0, m, 0)
        {

        }

        public void Write()
        {
            Console.WriteLine("Hour : " + hour);
            Console.WriteLine("Minute : " + minute);
            Console.WriteLine("Second : " + second);

        }


    }
}
