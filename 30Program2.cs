# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;

namespace ReflectionBasicExp
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Boolean);
            MemberInfo[] typeMembers = type.GetMembers();
            Console.WriteLine("{0}. tip içinde {1} tane üye mevcuttur." , type.Name, typeMembers.Length);

            int i = 1;
            foreach (MemberInfo member in typeMembers)
            {
                Console.WriteLine("{0} member name {1}, Member Type : {2} " , i ,member.Name, member.MemberType);
                i++;
            }

            Type newTypeObj = new Button().GetType();
            Console.WriteLine("NameSpace : {0}", newTypeObj.Namespace);
            Console.WriteLine("FullName : {0}", newTypeObj.FullName);
            Console.WriteLine("Assembly : {0}", newTypeObj.Assembly.FullName);
            Console.WriteLine("BaseType : {0}", newTypeObj.BaseType);
            Console.WriteLine("is Class : {0}\n", newTypeObj.IsClass.ToString());
            Console.WriteLine("{0} tipi içerisinde tanımlı;", newTypeObj.Name);
            Console.WriteLine("\t{0} adet constructor metot,", newTypeObj.GetConstructors().Length);
            Console.WriteLine("\t{0} adet property,", newTypeObj.GetProperties().Length);
            Console.WriteLine("\t{0} adet metot,", newTypeObj.GetMethods().Length);
            Console.WriteLine("\t{0} adet event vardır", newTypeObj.GetEvents().Length);



            Console.ReadLine();
        }
    }
}
