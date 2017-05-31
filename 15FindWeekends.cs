# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTimeOperations_12._05._2017
{
    class FindWeekends
    {
        public void FindToWeekends()
        {
            DateTime date1 = new DateTime(2017,05,05);
            DateTime date2 = new DateTime(2017,05,16);
            DateTime tempDate = date1;
            long weekend = 0;
            long fridayNumber = 0;

            TimeSpan differenceDate = date2 - date1;
            Console.WriteLine("differenceDate :" + differenceDate.Days);

            for (int i = 0; i < differenceDate.Days; i++)
            {
                tempDate = date1.AddDays(i).Date;
                if(tempDate.DayOfWeek == DayOfWeek.Saturday || tempDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    weekend++;
                }           
                else if(tempDate.DayOfWeek == DayOfWeek.Friday)
                {
                    fridayNumber++;
                }     
            }
            Console.WriteLine("Day number : " + weekend);
        }
    }
}
