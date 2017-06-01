# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceReference
{
    class Program
    {
        static void Main(string[] args)
        {
            // IMyInterface options

            IMyInterface myInterfaceReferance; 

            MyClass myObj = new MyClass();
            MyClass2 myObj2 = new MyClass2();

            myInterfaceReferance = myObj;
            myInterfaceReferance.MyMethod();

            myInterfaceReferance = myObj2;
            myInterfaceReferance.MyMethod();


            // IMyInterface options

            Horse h = new Horse
            {
                AnimalName = "At",
                AnimalSpecies = "Mammal"
            };
            IAnimals ianimal;
            ianimal = h;

            Console.WriteLine("Animal Name : " + ianimal.AnimalName + " Animal Species : " + ianimal.AnimalSpecies);
            h.WhatMyNutritionType();
          


            Console.ReadLine();
        }
    }
}
