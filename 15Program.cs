# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTimeOperations_12._05._2017
{
    class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date();
            date.MaxDate();

            date.Now();
            date.Today();

            date.GetDate();

            date.DateTest();

            FindBirthdayClass fbc = new FindBirthdayClass();
            fbc.FindBirthday();


            CalculateDate calDate = new CalculateDate();
            calDate.ToCalculateDate();


            FindWeekends f = new FindWeekends();
            f.FindToWeekends();

            BitConverterClass bCon = new BitConverterClass();
            bCon.BitConverterMethod();

            BitConverterClass bCon2 = new BitConverterClass();
            bCon2.BitConverterMethod2();


            Console.ReadKey();
        }
    }
}
