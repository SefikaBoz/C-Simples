# C-Simples

using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks;

namespace Quiz { 
  class Program { 
    static void Main(string[] args) { 
      //Customer c1 = new Customer(); 
      //c1.TCIdentity = "18073396906"; 
      //c1.Name = "Sefika";
      //c1.Surname = "Boz"; 
      //c1.Phone = "050665888"; 
      //c1.Email = "sez12@gmail.com";

        //Customer c2 = new Customer{ 
        TCIdentity="123456789",Name="Serafettin",Surname = "Sarisen",Phone = "05432298437",Email = "test@test.com"};

        //byte b1 = 12;
        //long i = 5;
        //b1 = (byte)i;

        //for (int i = 1; i < 100; i++)
        //{
        //    if (i % 7 == 0) {
        //        Console.WriteLine("Bu sayi yediye bolunur : "+ i);
        //        Console.WriteLine("Lutfen tusa basınız");
        //        Console.ReadKey();
        //    }              
        //}

        const int num = 4;
        const double num1 = 12;

        int num2 = num + (int)num1;
        int num4 = num + Convert.ToInt32(num1);

        byte a = 89;
        byte b = 56;
        byte c = 0;

        int d = a + b;

        byte bNum = num + (byte)num1;

        int val = 9; int l = 4;
        // byte a = (byte)ksd + (byte)l;
        int sayi = a + b;
        int result = 0;

        long lSayi1 = 45;
        long lSayi2 = 12;
        result = (int)lSayi1 + (int)lSayi2;

        lSayi2 = val + l;

        decimal dSayi1 = 455787997.89m;
        decimal dSayi2 = 45.7M;

        result = (int)dSayi1 + Convert.ToUInt16(dSayi2);

        float fSayi1 = 56;
        float fSayi2 = 5;
        //  result = (int)fSayi1 + Convert.ToInt32(fSayi2);

        decimal dd = (int)fSayi1 + (int)fSayi1;

        double d1 = 90;
        double d2 = 45;
        decimal ddd = (int)d1 + (int)d2;
        bool bool1 = true;
        string Str = bool1.ToString();
        Console.WriteLine("STR : " + Str);


        Console.WriteLine("dd  " + dd);
        Console.WriteLine("ddd  " + ddd);

        string str = "False";
        string stt = "2";
        bool bValue = Convert.ToBoolean(str);
        int sValue = Convert.ToInt32(stt);
        //Console.WriteLine("sValue : " + sValue);

        //  Console.WriteLine("vValue : " + bValue);

        //  Console.WriteLine("Result : "+ result);

        //Console.WriteLine("bNum  "+bNum);
        //Console.WriteLine(num2);
        //Console.WriteLine(num4);

        short b11 = 1;
        char c1 = (char)b11;

        double dsayi = 45;
        decimal decsayi = (decimal)dsayi;
        int isayi = 77;
        decsayi = isayi;

        decimal decsayi2 = 21.45m;
        double dobsayi2 = (double)decsayi2;
        Console.WriteLine("decsayi2 : " + decsayi2);



        decimal dec = 10;
        byte byt = (byte)dec;
        Console.WriteLine("byt : " + byt);

        int intnum = (int)dec;

        string ss = "5,4";
        double dddd = Convert.ToDouble(ss);
        dddd = dddd + 4.5;
        Console.WriteLine("dddddddd  : " + dddd);
       






        int result2 = 0;
        double dab = 90; double dub = 10;

        dab = result2;
        result2 = (int)dab + (int)dub + Convert.ToInt32(dub);

        decimal decimalnum1 = 45.45m;
        decimal decimalnum2 = 5.78m;

        result2 = (int)decimalnum1 + (int)decimalnum2; Console.WriteLine("İstediğim result :    :" + result2);
        dab = (double)decimalnum1;

        float floatResult = (float)decimalnum1 + (int)decimalnum2;

        dab = (float)decimalnum2;

        char ch = 'g';
        //  bool boolValue = (bool)ch;
        string stR = "false";
        bool boolVal = Convert.ToBoolean(stR);

        bool boolVal2 = true;
        string strval = boolVal2.ToString();

        float foe = 14f;
        short shoe = 9;
        short shortVal2 = 34;
        str = (shoe + shortVal2).ToString();

        int i = 258;
        byte bv = (byte)i;
        Console.WriteLine("bv   :" + bv);

        Console.WriteLine("strval : " + strval);
        Console.WriteLine("Bool Val : " + boolVal);
        Console.WriteLine("dab : : " + dab);
        Console.WriteLine("result2 : : " + result2);

        float dfgh = (int)4.9f;

        Console.WriteLine(dfgh);
        char charval = '4';
        int intval = charval;
        int intvaltwo = Convert.ToInt32(charval);
        Console.WriteLine(" intval " + intval);
        Console.WriteLine(" intvaltwo " + intvaltwo);

        string strvaleu = "4"; // strin dene

        int initval = Convert.ToInt32(strvaleu);

        Console.WriteLine(" initval " + initval);

        int kValue = 1;
        char kChar = 'b';
        kChar = (char)kValue;
        Console.WriteLine("kChar : " + kChar);

        decimal zdecimal = 45m;
        double decimalToInt = (float)zdecimal;
        Console.WriteLine("decimalToInt : " + decimalToInt);
      
        //Console.WriteLine("decsayi : " + decsayi);
        //Console.WriteLine("c1 : " + c1);





        string word = "basarili";
        int number = 7;
                 
        word = number == 7 ? word : "basarisiz";
        Console.WriteLine("Word : " + word);

        Console.WriteLine(number.GetType());

        Type tip = typeof(int);
        Console.WriteLine(tip);

        Type tipd = typeof(sbyte);
        Console.WriteLine(tipd);

        Console.WriteLine(number.GetType());
        Console.WriteLine(tipd.GetType());


     

        Console.ReadKey();

    }


}
}
