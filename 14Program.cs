# C-Simples


using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks;

namespace SystemNamespaces_12._05._2017 { 
class Program { static void Main(string[] args) { 
        Console.WriteLine(UInt16.MaxValue); 
        //short type Console.WriteLine(UInt64.MaxValue); 
        //long ype Console.WriteLine(UInt32.MaxValue); 
        // int type Console.WriteLine(UInt16.MinValue); 
        Console.WriteLine(UInt32.MinValue); 
        Console.WriteLine(UInt64.MinValue);

        string a = "56";
        int m = Int32.Parse(a);
        Console.WriteLine("a : " + a);
        Console.WriteLine(a is string);

        //compareTo() prototiip: int CompareTo(object o)

        int num = 12;
        Console.WriteLine("compareTo() test result : " + num.CompareTo(17));
        Console.WriteLine("compareTo() test result : " + num.CompareTo(10));
        Console.WriteLine("compareTo() test result : " + num.CompareTo(12));


        //compareTo() prototiip: bool Equals(object o)
        Console.WriteLine("num : " + num.Equals(12));
        Console.WriteLine("num : " + num.Equals("12"));

        string sNum = "10";          
        Console.WriteLine("sNum.Equals : " + sNum.Equals("10"));
        Console.WriteLine("sNum.Equals : " + sNum.Equals(10));

        int iNum = 10;
        Console.WriteLine("iNum.Equals : " + iNum.Equals(12));
        Console.WriteLine("iNum.Equals : " + iNum.Equals("10"));
        Console.WriteLine("iNum.Equals : " + iNum.Equals(10));

        //Double Single yapıları (gercek sayi turleri)

        Console.WriteLine("Epsilon : " + Double.Epsilon); 

        double nan = Double.NaN; // herhangi bir sayıyı temsil etmeyen deger

        double tot = nan + 5;
        Console.WriteLine("Nan total is : " + tot);
        Console.WriteLine("nan degerinin type ı : " + nan.GetType());

        Console.WriteLine("Double.PositiveInfinity result : " + Double.PositiveInfinity); 
        Console.WriteLine("Double.PositiveInfinity result : " + Double.NegativeInfinity); 

        double infinityNum = 12;
        infinityNum = Double.PositiveInfinity; 
        Console.WriteLine("infinityNum degiskeni sonsuz mudur ? : " + Double.IsPositiveInfinity(infinityNum));
        Console.WriteLine("infinityNum degiskeni sonsuz mudur ? : " + Double.IsNegativeInfinity(infinityNum));
        Console.WriteLine("45 sayısı sonsuz mudur ? : " + Double.IsInfinity(45)); 

        Console.WriteLine("MinChar : {0}  " , Char.MaxValue);

        char ch = 'b';
        Console.WriteLine(ch.CompareTo('c'));
        Console.WriteLine(ch.CompareTo('b'));
        Console.WriteLine(ch.CompareTo('a'));

        //Parse

        string chr = "A";

        char c = Char.Parse(chr);
        Console.WriteLine("c degeri : " + c);

        int numC = c;
        Console.WriteLine("numC : " + numC);

        //GetNumericValue
        char character = 'a';
        Console.WriteLine("character : " + Char.GetNumericValue(character));
        char character2 = '4';
        Console.WriteLine("character2 : " + Char.GetNumericValue(character2));


        //IsUpper use 1 :
        Console.WriteLine("character upper mı : " + Char.IsUpper(character));
        Console.WriteLine("character lower mı : " + Char.IsLower(character));

        //IsUpper use 2 :
        string str = "tesTing";
        Console.WriteLine("tesTing wordunun 4. harfi büyük mü ?  : " + Char.IsUpper(str,3));
        Console.WriteLine("character karakteri bir kontrol karakteri midir ? :  " + Char.IsControl(character));

        Console.WriteLine("character2 bir sayi karakteri midir ?  : " + Char.IsDigit(character2));
        Console.WriteLine("character2 bir sayi  ya da harf karakteri midir ?  : " + Char.IsLetterOrDigit(character2));

        char punc = ';';
        Console.WriteLine("punc karakteri  midir ?  : " + Char.IsPunctuation(punc));
        char space = ' ';
        Console.WriteLine("space bir seperator karakteri midir ?  : " + Char.IsSeparator(space));
        char space2 = '-';
        Console.WriteLine("space2 bir seperator karakteri midir ?  : " + Char.IsSeparator(space2));

        char sym = '+';
        Console.WriteLine("sym bir sembol karakteri midir ?  : " + Char.IsSymbol(sym));

        string strC = "+-/+";
        Console.WriteLine("+-/+ 4. eleman bir sembol karakteri midir ?  : " + Char.IsSymbol(strC,3));


        // IsWhiteSpace
        Console.WriteLine("Bir tusa basınız..");
        char inputStr = Convert.ToChar(Console.ReadLine());
        if (Char.IsWhiteSpace(inputStr))
        {
            Console.WriteLine("You left a space..");
        }
        else
            Console.WriteLine("You have not left a space..");

        // IsDigit

        string strArray = "9:00 ' da burada ol";

        for (int i = 0; i < strArray.Length; i++)
        {
            if (Char.IsDigit(strArray[i]))
                Console.WriteLine(strArray[i]);
        }

        //ToUpper

        Console.WriteLine("Yazı dizisi girin ..");
        string strA = Console.ReadLine();

        for (int i = 0; i < strA.Length; i++)
        {
            Console.Write(Char.ToUpper(strA[i]));
        }
        Console.WriteLine();
        Console.Write(strA[0]);
        Console.WriteLine(Char.ToUpper(strA[0]));

        // bool type  FalseString and TrueString
        Console.WriteLine(bool.FalseString);
        Console.WriteLine(bool.TrueString);

        // bool type  equals and toString
        bool deneme = true;
        bool dene = true;
      
        Console.WriteLine("\n" + Boolean.Equals(deneme, dene));


        //Decimal type

        decimal d1 = 45;
        decimal d2 = 67;
        Console.WriteLine("Decimal total is : " + Decimal.Add(d1, d2));
        Console.WriteLine("Decimal Divide is : " + Decimal.Divide(d1, d2));
        Console.WriteLine("Decimal Multiply is : " + Decimal.Multiply(d1, d2));
        Console.WriteLine("Decimal Subtract is : " + Decimal.Subtract(d1, d2));
        Console.WriteLine("Decimal Remainder is : " + Decimal.Remainder(d1, d2));// %

        // DEcimal.Floor
        decimal number1 = 45432.79m;
        Console.WriteLine ("number1 den buyuk olmayan en buyuk tam sayı sayi : " + Decimal.Floor(number1));

        //Negate
        Console.WriteLine("Number is negative : " + Decimal.Negate(number1));

        // GetBits
        Console.WriteLine("Number1 get bits : " + Decimal.GetBits(number1)[0]);
        Console.WriteLine("Number1 get bits : " + Decimal.GetBits(number1)[1]);
        Console.WriteLine("Number1 get bits : " + Decimal.GetBits(number1)[2]);

        //Round
        Decimal dec1 = new Decimal(986576,0,0,false,2);
        Console.WriteLine(Decimal.Round(dec1, 4));

        decimal d = 54646.54654m;
        Console.WriteLine(Decimal.Round(d, 2));

        // truncate

        decimal decim= 4987.346m;
        Console.WriteLine("Decim : " + Decimal.Truncate(decim));


        // Date and time operations





        Console.ReadKey();
    }
}
