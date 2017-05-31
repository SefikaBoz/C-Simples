# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStructorNumerEnumerations_3
{
    class Clock
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

        public Clock(int hour, int minute, int second)
        {
            Minute = minute + second / 60;
            Second = second % 60;
            Hour = Minute / 60 + hour;
            Minute = Minute % 60;

        }
        public static Clock operator +(Clock c1, Clock c2)
        {
            int hourTotal = c1.Hour + c2.Hour;
            int minuteTotal = c1.Minute + c2.Minute;
            int secondTotal = c1.Second + c2.Second;


            return new Clock(hourTotal, minuteTotal, secondTotal);
        }

        public static Clock operator +(Clock c, int i)
        {
            int totalSecond = c.Second + i;
            return new Clock(c.Hour, c.Minute, totalSecond);
        }

        public static bool operator ==(Clock c1, Clock c2)
        {
            if (c1.Hour == c2.Hour && c1.Minute == c2.Minute && c1.Second == c2.Second)
                return true;
            else
                return false;

        }

        public static bool operator!=(Clock c1, Clock c2)
        {
            return !(c1 == c2);
        }

        public static bool operator true(Clock c)
        {
            if (c.Hour != 0 || c.Minute != 0 || c.Second != 0)
                return true;
            else
                return false;
        }

        public static bool operator false(Clock c)
        {
            if (c.Hour != 0 && c.Minute != 0 && c.Second != 0)
                return true;
            else
                return false;
        }


        public void WriteClock()
        {
            Console.WriteLine("Total hour is : " + Hour + ":" + Minute + ":" + Second);
        }




    }
}
