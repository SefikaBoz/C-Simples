# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtGenericsPolimorfizm
{
    class TemplateTypeClass<ClassType>
    {
        public ClassType propertiy;
    }
    class TemplateTypeClass<Type1, Type2>
    {
        public TemplateTypeClass(Type1 t1, Type2 t2)
        {
            Console.WriteLine(t2);
            Console.WriteLine(t1);
        }
       
    }
}
