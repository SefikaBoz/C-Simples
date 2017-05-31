# C-Simples


using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;

namespace Demo4 { class SystemArrayProperties { public static void SystemArrayFixedSize() { int[] array = new int[45]; bool value = array.IsFixedSize; Console.WriteLine("Bool value = " + value); } public void SystemArrayProp() { bool value; Console.WriteLine("Enter array size.."); int num = int.Parse(Console.ReadLine()); int[] array; if (num > 5) { array = new int[num]; value = array.IsFixedSize; } else { array = new int[num]; value = array.IsFixedSize; } Console.WriteLine("Bool value = " + value); Console.WriteLine("ReadOnly is .. " + array.IsReadOnly); Console.WriteLine("Array is rank = " + array.Rank);

        char[] arr = new char[4] {'a','b','c','d' };
        Array.Reverse(arr,1,3);
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }

    }

    public static void SearchProp()
    {
        int[] array = new int[] { 5, 4, 7, 3, 2, 9, 4, 9, 12, 32, 1, 5, 8 };
        int index = Array.BinarySearch(array, 32);
        Console.WriteLine(index);

        int[] array2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Array.Clear(array2, 2, 6);
        Array.Reverse(array2);
        for (int i = 0; i < array2.Length; i++)
        {
            Console.WriteLine(array2[i]);
        }

        Console.WriteLine("Array get value : " + array.GetValue(2));
        array.SetValue(2, 4);
        Console.WriteLine("Array new value : " + array.GetValue(2));


    }
    public static void CreateInstanceMethod()
    {
        Array myArray = Array.CreateInstance(typeof(int), 5);
        for (int i = 0; i < myArray.Length; i++)
        {
            myArray.SetValue(i, 4); // test reverse (4,i)
        }

        foreach (var item in myArray)
        {
            Console.WriteLine(item);
            myArray.GetValue(0);
        }

    }
    public static void CreateInstanceMethodStr()
    {
        Array myArray = Array.CreateInstance(typeof(string), 4);
        foreach (var item in myArray)
        {
            Console.WriteLine(item);
        }
        //Array array = Array.CreateInstance(typeof(int),5,5);
    }
    public static void CreateInstanceExamp()
    {

        int count = 0;
        Array array = Array.CreateInstance(typeof(int), 5, 4, 3);
        for (int i = 0; i <= array.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= array.GetUpperBound(1); j++)
            {
                for (int k = 0; k <= array.GetUpperBound(2); k++)
                {
                    array.SetValue(i + j + k, i, j, k);
                }
            }
        }
        for (int i = 0; i <= array.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= array.GetUpperBound(1); j++)
            {
                for (int k = 0; k <= array.GetUpperBound(2); k++)
                {
                    Console.WriteLine("Array [" + i + "] [ " + j + "] [" + k + "] = " + array.GetValue(i, j, k));
                    count++;
                }
            }
        }
        Console.WriteLine("Count : " + count);
    }

    public static void CreateInstanceExamp2()
    {
        Array array = Array.CreateInstance(typeof(int), 2, 3);
        for (int i = 0; i <= array.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= array.GetUpperBound(1); j++)
            {
                array.SetValue(i, i, j); // value = i
            }
        }
        for (int i = 0; i <= array.GetUpperBound(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                //Console.WriteLine("[" + i + "][" + j + "] = " + array.GetValue(i, j));
                Console.Write(array.GetValue(i, j) + " ");
            }
            Console.WriteLine();
        }
    }
    public static void GetUpperBoundMethod()
    {
        int[] integers = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

        int upper = integers.GetUpperBound(0);
        int lower = integers.GetLowerBound(0);

        Console.WriteLine("Upper : " + upper + "\nLower : " + lower);
    }
    public static void OperationCopy()
    {
        int[] array = new int[3] { 1, 2, 3 };
        int[] array2 = new int[6];
        Array.Copy(array, 1, array2, 4, 2);
        for (int i = 0; i < array2.Length; i++)
        {
            Console.WriteLine(array2[i]);
        }
    }

    public static void SortMethod()
    {
        Array strArray = Array.CreateInstance(typeof(string), 4);
        strArray.SetValue("Rumeysa", 0);
        strArray.SetValue("Feyza", 1);
        strArray.SetValue("Seyma", 2);
        strArray.SetValue("Serife", 3);

        //Array.Sort(strArray);
        foreach (var elem in strArray)
        {
            Console.WriteLine(elem);
        }
        Console.WriteLine("Searchten donen deger : " + Array.BinarySearch(strArray, "Feyza"));// return index

        Console.WriteLine("Searchten donen deger: " + Array.BinarySearch(strArray, 1, 3, "Rumeysa"));// Dizi sıralanmazsa sonucu bulmuyor bu metot
    }

    public static void Sort()
    {
        string[] sArray = new string[5];
        string str;
        int index;
        sArray.SetValue("daisy", 0);
        sArray.SetValue("rose", 1);
        sArray.SetValue("tulip", 2);
        sArray.SetValue("jasmine", 3);
        sArray.SetValue("lily", 4);

        Console.WriteLine("Search flower : ");
        str = Console.ReadLine();
        Array.Sort(sArray);
        index = Array.BinarySearch(sArray, str);

        if (index <= -1)
            Console.WriteLine("No matches found");
        else
            Console.WriteLine("The " + index + " th index..");
    }
    public static void ClearMethod()
    {
        Array array = Array.CreateInstance(typeof(bool), 3);
        array.SetValue(true, 0);
        array.SetValue(true, 1);
        array.SetValue(false, 2);
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
        Array.Clear(array,0,1);
        Console.WriteLine();
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }

}
}
