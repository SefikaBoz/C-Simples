# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Array.BinarySearch(array[][] == "0");



            //Array Class's methods

            //Array arr = Array.CreateInstance(typeof(int), 3);
            //arr.SetValue(5, 0);
            //arr.SetValue(5, 1);
            //arr.SetValue(5, 2);
            //int[] num = new int[2] { 1, 2 };

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //Array a = Array.CreateInstance(typeof(int), num[1]);
            //--------------------------------------------------------------------------------------------------------------------------------

            // Optional parameters
            NamedAndOptional naoObj = new NamedAndOptional();
            int temp = naoObj.Method();
            Console.WriteLine(temp);

            int t = naoObj.Method(1);
            Console.WriteLine(t);

            int tmp = naoObj.Method(54, 2);
            Console.WriteLine(tmp);


            // Named parameters

            int tt = naoObj.Method(b: 10);
            Console.WriteLine(tt);

            int tmt = naoObj.Method2(2, 13, d: 4);
            Console.WriteLine(tmt);








            //--------------------------------------------------------------------------------------------------------------------------------
            // Params class ile ilgili işlemler

            //int[] array = new int[5];
            //Console.WriteLine("Dizinin elemanlarını girin ..");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Params param = new Params();

            //int total = param.Method(array);

            //Console.WriteLine("Array s elements total is .. = " + total);

            //int otherTotal = param.Method(5, 1, 0, 0, 0, 0, 5, 2, 3, 4);

            //Console.WriteLine("Other array  total is .. = " + otherTotal);

            //--------------------------------------------------------------------------------------------------------------------------------

            //ValueAndReferans parameters sınıfının işlemleri

            //int a = 7;
            //ValueAndReferans varObj = new ValueAndReferans();
            //varObj.Method(a);
            //Console.WriteLine(a); // dikkat : metodu cagırınca a = 20 olması gerekiyo gibi dusunuldu ama a = 7 olarak kaldı


            //string str = "sefika";
            //string temp = varObj.Method2(str);
            //Console.WriteLine(str);
            //Console.WriteLine(temp);

            ////object ob = 12;
            ////varObj.Method4(ob);
            ////Console.WriteLine(ob);

            //DEneme d = new DEneme();
            //d.num1 = 6;
            //d.num2 = 1;
            //varObj.Method4(d.num1, d.num2);
            //Console.WriteLine(d.num1 + " " + d.num2);


            //string[] strArray = new string[4] {"101", "101", "101", "101" };
            //varObj.Method3(strArray);

            //foreach (string item in strArray)
            //{
            //    Console.Write( item + " " );
            //}



            //--------------------------------------------------------------------------------------------------------------------------------

            // MethodParametersArray class ı ile ilgili işlemler (Metoda parametre olrak dizi verme) 

            int[] intArray = new int[3] { 1, 2, 3 };

            MethodParametersArray mpaObject = new MethodParametersArray();
            // mpaObject.Method(intArray);

            // mpaObject.Method2(intArray); --> İkinci yontem (Array sınıfı kullanarak)
            //------------------------------------------------ --------------------------------------------------------------------------------
            // Array sınıfının sort metodu kullanımı

            //Array str = Array.CreateInstance(typeof(string),6);
            //str.SetValue("Sefika",0);
            //str.SetValue("Feyza", 1);
            //str.SetValue("Rumeysa",2);
            //str.SetValue("Serife", 3);
            //str.SetValue("Arif", 4);
            //str.SetValue("Ahmet", 5);

            //Console.WriteLine("Sırasız dizi : ");

            //foreach (string item in str)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //Array.Sort(str);
            //foreach (string item in str)
            //{
            //    Console.Write(item + " ");
            //}

            //// Dizilerde arama :
            //Console.WriteLine("\nAranan elemanın indeksi : "+ Array.BinarySearch(str, "Rumeysa"));
            //Array.Reverse(str);



            //--------------------------------------------------------------------------------------------------------------------------------

            // Array sınıfının Copy metodu kullanımı

            //int[] array = { 1, 2, 3, 4 };

            //int[] cop = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            //Array.Copy(array,2,cop,8,2);

            //foreach (var item in cop)
            //{
            //    Console.WriteLine(item);
            //}

            //--------------------------------------------------------------------------------------------------------------------------------


            // Array sınıfının CopyTo metodu kullanımı
            //int[] array = { 1, 2, 3, 4 };

            //int[] cop = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            //array.CopyTo(cop, 0);

            //foreach (var item in cop)
            //{
            //    Console.WriteLine(item);
            //}

            //--------------------------------------------------------------------------------------------------------------------------------
            // Array sınıfı ile GetUpperBound metodu kullanarak 3 Boyutlu dizi ornegi


            //Array array = Array.CreateInstance(typeof(int), 5, 4, 3);
            //for (int i = 0; i <= array.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= array.GetUpperBound(1); j++)
            //    {
            //        for (int k = 0; k <= array.GetUpperBound(2); k++)
            //        {
            //            array.SetValue(i + j + k, i, j, k);
            //            Console.Write(array.GetValue(i,j,k));
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //}


            //--------------------------------------------------------------------------------------------------------------------------------

            ////Array Class's properties
            //int[][] array = new int[4][];
            //array[0] = new int[2];
            //array[1] = new int[1];
            //array[2] = new int[6];
            //int a = array[0].Rank; Console.WriteLine(a);

            //bool b = array[0].IsReadOnly; Console.WriteLine(b);

            //bool b2 = array[1].IsFixedSize; Console.WriteLine(b2);

            //--------------------------------------------------------------------------------------------------------------------------------
            // Irregular array
            //int[][] array = new int[3][];
            //array[0] =new int [4];
            //array[1] = new int[2];
            //array[2] = new int[6];


            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array[i].GetLength(0); j++)
            //    {
            //        Console.Write(array[i][j]);
            //    }
            //    Console.WriteLine();

            //}


            //--------------------------------------------------------------------------------------------------------------------------------


            //int[ , ] a = new int [3][];  ??  bu hatalı unutma

            //int val = 10;
            //string[,] array = new string[val, val];
            //for (int i = 0; i < val; i++)
            //{           
            //    for (int j = 0; j < 5; j++) // 5 yerine val yaz
            //    {
            //        if (i == j) {
            //            array[i, j] = "*";
            //        }
            //        array[val-1 - j, j] = "*";            
            //    }             
            //}
            //for (int i = 0; i < val; i++)
            //{
            //    for (int j = 0; j < val; j++)
            //    {
            //        if (array[i, j] == "*")
            //            Console.Write(array[i, j]);
            //        else
            //            Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}
            //--------------------------------------------------------------------------------------------------------------------------------
            //int[,] array = { { 1, 2 }, { 3, 4 }, { 5, 6 } }; // 3 * 2 boyutlu

            //array[2, 1] = 8;

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.WriteLine(array[i, j]);
            //    }
            //}

            //--------------------------------------------------------------------------------------------------------------------------------
            //char[] s = { 's', 'd', 'f' };
            //int[] array1 = new int[4], array2 = new int[4], dizi = new int[75];

            //int[] arr1, arr2; // dizi bildirimi
            //arr1 = new int[100]; // dizi tanımı

            //// Random
            //Random rnd = new Random();


            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    arr1[i] = rnd.Next(1,11);
            //}
            //int[] newArray = new int [10] ;
            //for (int i = 0; i < 100; i++)
            //{
            //    newArray[arr1[i] - 1] ++;
            //}

            //foreach (int i in newArray)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine(i);

            //}

            //--------------------------------------------------------------------------------------------------------------------------------
            //Console.WriteLine("Sayi gir..");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int[] array = new int[number];

            //bool [] boolArray = new bool[number];

            //string[] strArray = new string[] {"ben","sen","o" };
            //string[] strAr = { "45", "50", "55" };

            //strArray = strAr;
            //strArray[0] = "ahmet";
            //strArray[1] = "mehmet";


            //foreach (var item in strAr)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in strArray)
            //{
            //    Console.WriteLine(item);
            //}
            Console.ReadKey();
        }
    }
}
