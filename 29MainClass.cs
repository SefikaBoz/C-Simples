# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using IPluginInterface;

namespace ConsoleSpaces
{
    class MainClass
    {
        public static object[] plugins = new object[100];
        static void Main(string[] args)
        {
            DownloadPlugin(".");
            string key = "";
            do
            {
                Console.WriteLine("Enter the first number..");
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the second number..");
                int number2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the oprions..");
                key = Console.ReadLine();
                if (key != "q")
                {
                    ICalculate plugin = PluginSearch(key);
                    if (plugin != null)
                    {
                        int result = plugin.ToCalculate(number, number2);
                        Console.WriteLine("Result is .. : " + result.ToString());
                    }
                    else
                    {
                        Console.WriteLine("A non-installable process selected");
                    }
                }

            } while (key != "q");

        }
        static ICalculate PluginSearch(string name)
        {
            foreach (ICalculate plugin in plugins)
            {
                if (plugin != null && plugin.Name == name)
                    return plugin;
            }
            return null;
        }
        static void DownloadPlugin(string directrory)
        {
            string[] files = Directory.GetFiles(directrory, "*.dll");
            int index = 0;
            foreach (string file in files)
            {
                Assembly asmb = Assembly.LoadFrom(file);
                Type[] types = asmb.GetTypes();
                foreach (Type type in types)
                {
                    if (type.IsClass && typeof(ICalculate).IsAssignableFrom(type))
                    {
                        object obj = Activator.CreateInstance(type);
                        plugins[index] = obj;
                        index++;
                    }
                }
            }
        }
    }
}
