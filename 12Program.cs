# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {

        static void Main(string[] args)
        {
            Customer[] customers = new Customer[3];
            customers[0] = new Customer
            {
                Name = "Mark",
                Gender = Gender.Male
            };
            customers[1] = new Customer
            {
                Name = "Mary",
                Gender = Gender.Female
            };
            customers[2] = new Customer
            {
                Name = "Sam",
                Gender = Gender.Unknwon
            };

            foreach (Customer customer in customers)
            {
                Console.WriteLine("Name = {0} and Gender = {1}", customer.Name,GetGender(customer.Gender));
            }

            string[] strAr = Enum.GetNames(typeof(Gender));
            foreach (string str in strAr)
            {
                Console.WriteLine(str);
            }

            short[] values = (short[])Enum.GetValues(typeof(Gender));
            foreach (short val in values)
            {
                Console.WriteLine(val);
            }

            //Gender g = (Gender)9;  //şeklinde cast edilebilir
            //int a = (int)Gender.Female;
            //Console.WriteLine("a : {0} ve b : {1} dır.", a, g);

            Gender gen = (Gender)Season.Winter;

            Console.ReadKey();
        }

        public static string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unknwon:
                    return "Unknwon";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid data detected";

            }
        }

        public enum Season { Winter=1 , Spring=2, Summer=3 };
    }
}
