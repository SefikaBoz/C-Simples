# C-Simples

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PErson
{
    interface IEmployee:IAccount
    {
        string Department { get; set; }
        string Task { get; set; }
    }
}
