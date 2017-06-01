# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMsdn
{
    class Program
    {
        static void Main(string[] args)
        {
            Deposit depositObj = new Deposit();

            Transfer transferObj = new Transfer();

            EFT eftObj = new EFT();

            Deposit refEft;

            refEft = depositObj;
            refEft.WithdrawMoney();

            refEft = transferObj;
            refEft.WithdrawMoney();

            refEft = eftObj;
            refEft.WithdrawMoney();


            //Point 
            Circle circleObj = new Circle();
            circleObj.Radius = 2;
            Console.WriteLine("Circle area is : " + circleObj.CalculateArea());

            Cylinder cylinderObj = new Cylinder();
            cylinderObj.Radius = 2;
            cylinderObj.Height = 15;
            Console.WriteLine("Cylinder area is : "  + cylinderObj.CalculateArea());


            Console.ReadLine();
        }
    }
}
