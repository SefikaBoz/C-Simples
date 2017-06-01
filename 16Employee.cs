# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts
{
    public abstract class Employee
    {
        private string na;
        protected string name;
        protected int protecteddeneme;
        private int privatedeneme;
        public int publicdeneme;
        public Employee(string name)
        {
            this.name = name;
            Console.WriteLine("Bu bir employe");
        }
        public abstract void Show();
        public void Emp()
        {
            Console.WriteLine("Emp");
        }
        static void StaticMethod()
        {
            Console.WriteLine("Hello I am static method ()");
        }
    }

    public class Manager: Employee
    {
        
        public Manager(string name):base(name) {
            Console.WriteLine("Bu bir manager");
        }

        public override void Show()
        {
            System.Console.WriteLine("Name : " + name);
        }
        public void Man()
        {
            Console.WriteLine("Man");
            Employee e = new Manager("");
            
            
        }
    }
}
