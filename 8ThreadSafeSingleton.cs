# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo7
{
    public class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton tt = new ThreadSafeSingleton();

        //private static ThreadSafeSingleton()
        //{

        //}
        private ThreadSafeSingleton()
        {

        }
    
        public static ThreadSafeSingleton TT
        {
            get{
                return tt;
            }
        }
    }
}
