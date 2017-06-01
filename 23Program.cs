# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PErson
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student
            {
                FirstAndLastName = "William Smith",
                EPosta = "william@windowslive.com",
                ExamGrade = 50,
                Phone = ""
            };
            Lecturer lec = new Lecturer
            {
                FirstAndLastName = "Steve",
                Department = "IT",
                Task = "Software Developer"
            };
            Console.WriteLine("Name : {0} , Department : {1}, Task : {2} " , lec.FirstAndLastName, lec.Department,lec.Task);
            Console.ReadLine();
        }
    }
}
