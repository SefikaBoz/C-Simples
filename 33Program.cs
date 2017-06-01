# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBasicExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Result<Person> res = new Result<Person>();
            res.Message = "successful";
            res.Successful = "true";

            Console.WriteLine(res.GetType());
            Console.WriteLine(res.Message);
            Console.ReadLine();
        }//GenericBasicExample.Result`1[GenericBasicExample.Person]
    }
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
    class Result<T> where T : class
    {
        public string Message { get; set; }
        public string Successful { get; set; }
        public T Data { get; set; }     
    }
}
