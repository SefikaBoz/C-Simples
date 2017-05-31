# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6
{
    static class MathematicalOperations
    {
     
        //public  MathematicalOperations()
        //{
        // constructor tanımı yapılamaz
        //}
        public static int Add(int number1 , int number2)
        {
            return number1 + number2;
        }

        public static int Subraction(int number1, int number2)
        {
            return number1 - number2;
        }

        public static int Division(int number1, int number2)
        {
            return number1 / number2;
        }

        public static int Multiplication(int number1, int number2)
        {
            return number1 * number2;
        }
        public const double PI = 3.14;

        public const string contValue = "Sefika Boz"; // Use const of string 

        static readonly Total tot = new Total(5,4);// bu bildirimle const ifadesini referans tiplerde kullanmış oluruz (readonly diyerek)
        static readonly Gamer gamer1 = new Gamer();
        static readonly Time time = new Time(20,20,20);

    }
}
