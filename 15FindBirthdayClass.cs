# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTimeOperations_12._05._2017
{
    class FindBirthdayClass
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public void FindBirthday()
        {
            Console.WriteLine("Enter your birth year..");
            Year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your birth mounth..");
            Month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your birth day..");
            Day = Convert.ToInt32(Console.ReadLine());

            DateTime today = DateTime.Today;
            DateTime birthDate = new DateTime(Year,Month,Day);

            TimeSpan difference = today - birthDate;
            Console.WriteLine("Number of days past .. : " + difference.Days);

            Console.WriteLine("Your birthday is .. : " + birthDate.Day);

            Console.WriteLine("Your birthday is .. : " + birthDate.DayOfWeek);

            Console.WriteLine("Your birt month is .. : " + birthDate.Month);

            Console.WriteLine("Your birth day is .. : " + birthDate.DayOfYear);


        }
    }
}
