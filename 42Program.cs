# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics___3__25_05_2017
{
    class Program
    {
        static void Main(string[] args)
        {

            DelegateClass.Delegate<int> integerDelegate = new DelegateClass.Delegate<int>(DelegateClass.Add);
            int temp = integerDelegate(45, 6);
            Console.WriteLine(temp);

            DelegateClass.Delegate<string> strDelegate = new DelegateClass.Delegate<string>(DelegateClass.Add);
            string strTemp = strDelegate("nasıl", "sın");
            Console.WriteLine(strTemp);

            DelegateClass d = new DelegateClass();
            DelegateClass.DelegateMethod<int> intObj = new DelegateClass.DelegateMethod<int>(d.Write);
            intObj(1111111111);

            DelegateClass s = new DelegateClass();
            DelegateClass.DelegateMethod<string> strObj = new DelegateClass.DelegateMethod<string>(s.Write);
            strObj("hallo welt");


            Console.ReadLine();
        }
    }
}
