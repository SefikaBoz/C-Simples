# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtGenericsPolimorfizm
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass2<int> der2 = new DerivedClass2<int>(123,"str",12345);

            TemplateTypeClass<int> templateObj = new TemplateTypeClass<int>();
            templateObj.propertiy = 4;

            TemplateTypeClass<int> templateObj2 = new TemplateTypeClass<int>();
            templateObj2.propertiy = 658;

            Console.WriteLine("templateObj + templateObj2 :  " + (templateObj.propertiy + templateObj2.propertiy));


            TemplateTypeClass<string> templateStrObj = new TemplateTypeClass<string>();
            templateStrObj.propertiy = "test";

            Console.WriteLine("templateObj + templateObj2 :  " + (templateObj.propertiy + templateStrObj.propertiy));

            Array newArray = Array.CreateInstance(typeof(int), 10);
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray.SetValue(10, i);
            }

            TemplateTypeClass<Array, int> tempObj = new TemplateTypeClass<Array, int>(newArray,852);

            

            Console.ReadLine();
        }
  

    }
}
