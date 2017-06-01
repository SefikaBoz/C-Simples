# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMSDN
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkItem workItemObj = new WorkItem("Fix Bugs", "Fix all bugs in my code branch", new TimeSpan(3, 4, 0, 0));

            ChangeRequest changeReqObj = new ChangeRequest("Change Base Class Design ", "Add members to the class", new TimeSpan(4, 0, 0), 1);

            Console.WriteLine(workItemObj.ToString());

            Console.WriteLine(changeReqObj.ToString());

            changeReqObj.Update("new Title", new TimeSpan(1, 2, 3, 4));

            Console.WriteLine(changeReqObj.ToString());

            ChangeRequest c = new ChangeRequest();

            Console.WriteLine("Press any key to exit..");

            Console.ReadLine();
        }
    }
}
