# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Graphic2D;
using Graphic3D;
using NameSpaces2.Namespace3;

using Point2D = Graphic2D.Point;
using Point3D = Graphic3D.Point;
using K = System.Console;


namespace NameSpaces2
{
    class Program
    {
        private static DisposClass dis2;

        static void Main(string[] args)
        {
            //DisposClass dis = new DisposClass();
            //using (dis)
            //{
            //    Console.WriteLine("using block");
            //}
            //Console.WriteLine("outside using block");

            

            using (DisposClass dis = new DisposClass(),  dis2 = new DisposClass())
            {
                K.WriteLine("using bloguu");
                //dis.Dispose();
            }

            //Point2D p2 = new Point2D(); 
            //Point3D p3 = new Point3D(); 

            NestedNamesoacesExamp nesObj = new NestedNamesoacesExamp();
            Namespace3.InnerClass inObj = new Namespace3.InnerClass();
            Namespace3.Namespace4.InInnerClass ininnerObj = new Namespace3.Namespace4.InInnerClass();

            InnerClass inObgfj = new InnerClass(); //added using NameSpaces2.Namespace3 ; 


            K.ReadKey();
        }

    }
}
namespace Graphic3D
{
    public class Point
    {
        public Point()
        {
            K.WriteLine("Point3D");
        }
    }
}
namespace Graphic2D
{
    public class Point
    {
        public Point()
        {
            K.WriteLine("Point2D");
        }
    }
}
