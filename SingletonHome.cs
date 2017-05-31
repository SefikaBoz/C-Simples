# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo7
{
    class SingletonHome
    {
        private static SingletonHome home;

        private SingletonHome()
        {
           // Private constructor defined for not creating new class and not being accessed from outside
        }

        static SingletonHome()
        {
            home = new SingletonHome();
        }

        public static SingletonHome Home
        {
            get
            {
                return Home;
            }
        }


    }
}
Contact GitHub API Training Shop Blog About
© 2017 GitHub, Inc. Terms Privacy 
