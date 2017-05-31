# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTimeOperations_12._05._2017
{
    public class Date
    {
        public void MaxDate()
        {
            DateTime d;
            d = DateTime.MaxValue;
            Console.WriteLine(d);
            
        }
        public void MinDate()
        {
            DateTime d = new DateTime();
            d = DateTime.MinValue;
            Console.WriteLine(d);
        }
        public void Now()
        {
            Console.WriteLine(DateTime.Now);
        }
        public void Today()
        {
            Console.WriteLine(DateTime.Today);
        }
        public void GetDate()
        {
            DateTime date = new DateTime();
            date = DateTime.MaxValue;
            Console.WriteLine(date.Date);
        }
        public void DateTest()
        {
            DateTime date = new DateTime(5);
            if(date.Date == DateTime.Today)
            {
                Console.WriteLine("date.Date = DateTime.Today "  );
            }
            Console.WriteLine("date.Date" + date.Date);
            date = DateTime.Now;
            Console.WriteLine("date.Date : " + date.Date);
            Console.WriteLine("date.Day : " + date.Day);
            Console.WriteLine("date.Month : " + date.Month);
            Console.WriteLine("date.Year : " + date.Year);
            Console.WriteLine(DateTime.DaysInMonth(2017,04)); 
            Console.WriteLine(DateTime.DaysInMonth(2017, 02));
            Console.WriteLine(DateTime.DaysInMonth(2016, 02));
            Console.WriteLine(DateTime.DaysInMonth(2015, 02));
            Console.WriteLine(DateTime.DaysInMonth(2014, 02));
            
            Console.WriteLine("date.DayOfWeek :" + date.DayOfWeek);
            Console.WriteLine("date.TimeOfDay :" + date.TimeOfDay);
            Console.WriteLine("date.Hour :" + date.Hour);
            Console.WriteLine("date.Minute :" + date.Minute);
            Console.WriteLine("date.Second :" + date.Second);
            Console.WriteLine("date.Millisecond :" + date.Millisecond);

        }
    }
}
