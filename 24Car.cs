# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedAndInterface
{
    class Car : IEquatable<Car>
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

        public bool Equals(Car car)
        {
            if (this.Make == car.Make && this.Model == car.Model && this.Year == car.Year)
                return true;
            else
                return false;
        }
    }
}
