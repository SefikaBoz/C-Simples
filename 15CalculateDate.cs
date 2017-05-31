# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTimeOperations_12._05._2017
{
    class CalculateDate
    {
        public int DateNumber { get; set; }
        
        public void ToCalculateDate()
        {
            Console.WriteLine("Day number : ");
            DateNumber = Convert.ToInt32(Console.ReadLine());
            TimeSpan difference = new TimeSpan(DateNumber,0,0,0);
            DateTime dateTime = DateTime.Today + difference;
            Console.WriteLine("Date time : " + dateTime);
            Console.WriteLine("Date time : " + dateTime.DayOfWeek);

         
        }
    }
}
