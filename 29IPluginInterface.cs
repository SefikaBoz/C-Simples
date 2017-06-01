# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace IPluginInterface
{
    
    public interface ICalculate
    {
        string Name { get; } 


        int ToCalculate(int numberOne, int numberSecond);
    }

    public interface ICalcualteV2
    {

    }

}
