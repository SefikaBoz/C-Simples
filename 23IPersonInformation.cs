# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PErson
{
    interface IPersonInformation
    {
        string FirstAndLastName { get; set; }
        string EPosta { get; set; }
        string Phone { get; set; }
    }
}
