# C-Simples


using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;

namespace Demo5 { class Program { static void Main(string[] args) {

        int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        // ArrayAndMethod.WriteArray(array);
        ArrayAndMethod.WriteArrayForAllTypes(array, 0);

        // Set array parameter in methods
        char[] charArray = new char[] { 'b', 'c', 'd', 'e' };

        Array.Reverse(charArray);
        ArrayAndMethod.WriteArrayForAllTypes(charArray, 1);

        // value type tests
        int a = 10;
        Console.WriteLine("first value : " + a);
        ValueAndRefType.ValueType(a);
        Console.WriteLine("end value : " + a);

        // referance type tests
        string[] s = { "october" };
        Console.WriteLine("first value : " + s[0]);
        ValueAndRefType.ReferansType(s);
        Console.WriteLine("second value : " + s[0]);

        // ref word tests

        int x = 20;
        Console.WriteLine(x);
        ValueAndRefType.UseOfRefWord(ref x);
        Console.WriteLine(x);

        //TestIntArray method
        int[] value = { 15 };
        Console.WriteLine(value[0]);
        ValueAndRefType.TestIntArray(value);
        Console.WriteLine(value[0]);

        // TestUseRefString method

        string str = "firstStr";
        ValueAndRefType.TestUseRefString(ref str);
        Console.WriteLine(str);

        // OutWord method
        int val = 0;
        ValueAndRefType.OutWord(out val);
        Console.WriteLine("Val : " + val);

        //Params class 

        Console.WriteLine(ParamsClass.Total());
        Console.WriteLine(ParamsClass.Total(1));
        Console.WriteLine(ParamsClass.Total(1, 2, 3, 4, 5));


        // params string example

        string abc = "";
        string[] stringArray = new string[4];
        for (int i = 0; i < stringArray.Length; i++)
        {
            Console.WriteLine("Enter string value..");
            stringArray[i] = Console.ReadLine();
            if (stringArray[i] == "0")
                break;
            else
                abc = ParamsClass.UnitWord(stringArray[0], stringArray[1], stringArray[2], stringArray[3]);

        }
        Console.WriteLine(abc);
        ///////////////////////////////////////////////////////////////
        ParamsClass.ParamsExamp(0, "hello", 2.45f, 0.25, "whatsup");

        ////////////////////////////////////////////////

        CallOverloadMethodParams comparam = new CallOverloadMethodParams();
        comparam.Call(2, 5);

        OptionalAndNamedParameter.OptionalSample("Jany","Brown",9);
        OptionalAndNamedParameter.OptionalSample("hi", c: 12);
        OptionalAndNamedParameter.OptionalSample("stringParameter",b: "b s new value");
        OptionalAndNamedParameter.OptionalSample(c:96,a :"sefer");

        OptionalAndNamedParameter.OptionalAndNamed("Ali","Ahmet");
        ////////////////////////////////////////////////////////////////////////
        Console.WriteLine("Enter the number to factoriel..");
        int enteredNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Factoriel of enter number: " + Recursive.factoriel(enteredNum));

        ////////////////////////////////////////////
        Recursive.BitWrite(0);

        Console.WriteLine("Enter the number to add..");
        Console.WriteLine(Recursive.ConsecutiveSum(int.Parse(Console.ReadLine())));

        Recursive.ShowNumber(4);


        //Write("Mary");
        //Write(2.25f);

        Console.ReadKey();
    }

    static void Write(object i)
    {
        Console.WriteLine(i);
    }

    int a = 0; int b;
    public bool total(int a, int b)
    {
        this.a = a;
        this.b = b;
        return false;
    }
    public void FindToMaximumMethodsTests()
    {
        Console.WriteLine("Enter the maximum number of 2 digits..");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());

        double maxNum = FindToMaximum.FindMaximum(num1, num2);
        Console.WriteLine("Maxiumum num : " + maxNum);

        ////////////////////////////////////////////////////////
        Console.WriteLine("Enter the maximum number of 3 digits..");
        double number1 = Convert.ToDouble(Console.ReadLine());
        double number2 = Convert.ToDouble(Console.ReadLine());
        double number3 = Convert.ToDouble(Console.ReadLine());

        double maxNumber = FindToMaximum.FindMaxiumum3Num(number1, number2, number3);
        Console.WriteLine("Maximum number : " + maxNumber);

        ////////////////////////////////////////////////////////
        Console.WriteLine("Enter the maximum number of 4 digits..");
        double elem1 = Convert.ToDouble(Console.ReadLine());
        double elem2 = Convert.ToDouble(Console.ReadLine());
        double elem3 = Convert.ToDouble(Console.ReadLine());
        double elem4 = Convert.ToDouble(Console.ReadLine());

        double maximumNum = FindToMaximum.FindMaxiumum4Num(elem1, elem2, elem3, elem4);
        Console.WriteLine("Maxiumum num : " + maximumNum);
    }


}
}
