# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] args test

            //int a = args.Length;
            //Console.WriteLine("Args dizisinin boyutu : " + a);



            // App example

            //ExampApp exampApp = new ExampApp();

            //double[] tempArray = exampApp.Exampapp(1, 2, 4, 9, 25, 81, 144);
            //foreach (double temp in tempArray)
            //{
            //    Console.WriteLine(temp);
            //}

            //for (int i = 0; i <= 10; i++)

            //{
            //    Console.WriteLine("" + exampApp.fib(i));
            //}

            // Classes

            CreditAccount account = new CreditAccount();

            account.AccountNo = 123458965566;
            account.Limit = 000000000;
            account.CardOwner = "John Smith";

            Console.WriteLine(account.AccountNo);
            Console.WriteLine(account.Limit);
            Console.WriteLine(account.CardOwner);

            // Birden fazla sınıf nesnesi tanımlama (referans tipi)

            CreditAccount account2 = new CreditAccount();
            CreditAccount account3;

            account2.AccountNo = 12345678912456;
            Console.WriteLine("Account2 account no : " + account2.AccountNo);
            account3 = account2;

            Console.WriteLine("Account3 's account no : " + account3.AccountNo);
            account3.AccountNo = 3434;


            Console.WriteLine("Account3 account no : " + account3.AccountNo);
            Console.WriteLine("Account2 account no : " + account2.AccountNo);

            account2.AccountNo = 12121212;
            Console.WriteLine("Account3 account no : " + account3.AccountNo);
            Console.WriteLine("Account2 account no : " + account2.AccountNo);

            // (deger tipi)
            int a, b;
            a = 20;
            b = a;
            Console.WriteLine("A : " + a);

            b = 5;
            Console.WriteLine("A : " + a);
            Console.WriteLine("B : " + b);


            // Quadrirateral class test

            Quadrirateral q = new Quadrirateral();
            q.SetWidthHight(20, 10);
            q.QuadrirateralShow();

            Quadrirateral quad = new Quadrirateral();
            quad.SetWidthHight(5, 10);
            quad.QuadrirateralShow();



            // Triangle class test

            Triangle tr = new Triangle();
            tr.SetTriangle(12, 5);
            Console.WriteLine("Triangle area is : " + tr.Area());



            //Quadrirateral2 class test

            Quadrirateral2 q2 = new Quadrirateral2();
            q2.SetWidthHight(2, 2);
            Console.WriteLine("Quadrirateral2 class width is : " + q2.Width);
            q2.Height = 45;
            q2.Width = 10;
            Console.WriteLine("Quadrirateral2 class new width is : " + q2.Width);

            Quadrirateral2 quad2 = new Quadrirateral2();
            quad2.SetWidthHight(1, 54);

            //quad2.Width = -23;
            //quad2.Width = -6;

            Console.WriteLine("Quadrirateral2 class test width is : " + quad2.Area());
            Console.WriteLine("Is Square ?  : " + quad2.IsSquare());
            Console.WriteLine(quad2.DiogonalLength());

            ConstructorHourClass csc = new ConstructorHourClass(60, 60, 60);
            csc.Write();

            //Use Copy Constructor example
            ConstructorHourClass csc2 = new ConstructorHourClass(csc);

            csc2.Write();

            //csc2 = csc;
            //csc = new ConstructorHourClass(70, 56, 69);
            csc.hour = 160;
            //csc.hour = 150;
            csc.Write();
            csc2.Write();

            //Time time = new Time(65);
            //time.Write();

            //Total t = new Total(8);
            //t.ToTotal();

            Zaman z1 = new Zaman(5, 5, 5);
            z1.Yaz();
            Zaman z2 = new Zaman(z1);
            z2.Yaz();

            // z2 = z1;
            //z1 = new Zaman(10, 10, 10);

            z1.saat = 1000; z1.Yaz();
            z2.dakika = 50; z2.Yaz();


            Gamer o = new Gamer();
            Console.WriteLine("Total gamer is : " + Gamer.total);

            Gamer g = new Gamer();
            Console.WriteLine("Total gamer is : " + Gamer.total);



            // MathematicalOperations.Add(5, 6); static class examp.



            Console.ReadKey();


        }


    }


}
