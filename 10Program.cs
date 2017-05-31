# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsAndEnumerations
{
    class Program
    {
        static void Main(string[] args)
        {
          
            //EnumClass deneme

            int[] array = new int[5];
            EnumClass ec = new EnumClass();
            ec.ArrayWrite(array,FORMAT.vertical);
            ec.ArrayWrite(array,FORMAT.horizontal);

            Console.WriteLine("Horizontal : " + (int)FORMAT.horizontal); 
            Console.WriteLine("Vertical : " + (double)FORMAT.vertical);

            string[] Symbols = FORMATDAYS.GetNames(typeof(FORMATDAYS));
            foreach (string str in Symbols)
            {
                Console.WriteLine(str);
            }



            //Student std = new Student();
            //std.Name = "John";
            //std.Surname = "Brown";
            //std.Field = Field.Digital;
            //Lesson les = new Lesson
            //{
            //    Name = "math",
            //    Exam1 = 60,
            //    Final = 40
            //};

            //Lesson les2 = new Lesson
            //{
            //    Name = "Physics",
            //    Exam1 = 87,
            //    Final = 45
            //};
            //std.Lessons.Add(les);
            //std.Lessons.Add(les2);
            //Console.WriteLine(std.Average);


            // Studentt struct test

            Console.WriteLine();

            Studentt s = new Studentt();
            s.no = 125;
            Console.WriteLine(s.no);
            Metot(s);
            Console.WriteLine(s.no);


            // Rectangle class test

            Rectangle rec = new Rectangle();
            rec.CalculateArea(12, 40);
            Console.ReadKey();
        }

        public struct Studentt
        {
            public string Name;
            public string Surname;
            public int no;
        }
        public static void Metot(Studentt o)
        {
            o.no = 849;
        }

    }

}
Contact GitHub API Training Shop Blog About
© 2017 GitHub, Inc. Terms Privacy Security Statu
