# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6
{
    class ConstructorHourClass
    {
        public int hour;
        public int minute;
        public int second;
        // use to this at constructors
        public ConstructorHourClass(int h, int m, int s)
        {
            second = s % 60;
            int newMinute = m + s / 60;
            minute = newMinute % 60;
            hour = h + newMinute / 60;
                      
        }
        public ConstructorHourClass()
        {
            second = 0;
            minute = 0;
            hour = 0;
        }

        public ConstructorHourClass(ConstructorHourClass newTime)
        {
            second = newTime.second;
            minute = newTime.minute;
            hour = newTime.hour;
        }
        ~ConstructorHourClass()
        {
            Console.WriteLine("ConstructorHourClass ının yıkıcı metodu çağrıldı..");
        }
        public void Write()
        {
            Console.WriteLine("Hour : " + hour);
            Console.WriteLine("Minute : " + minute);
            Console.WriteLine("Second : " + second);
        }
        
    }
}
