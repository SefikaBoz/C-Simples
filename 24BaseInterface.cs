# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedAndInterface
{
    // inheritance  at interface
    interface BaseInterface
    {
        void BaseMethod();
    }
    interface DerivedInterface:BaseInterface
    {
        void DerivedMethod();
    }
    class BaseeClass : DerivedInterface
    {
        void BaseInterface.BaseMethod()
        {

        }
        void DerivedInterface.DerivedMethod()
        {

        }

    }

}
