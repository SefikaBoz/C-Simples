# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStructorNumerEnumerations_4
{
    class Car
    {
        public int Weight { get; set; }
        public string Model { get; set; }

        public string[] cars;
        public Car(int len)
        {          
            cars = new string[len];
        }
        public int ArrayCarSize
        {
            get { return cars.Length; }
        }
        public string this[int index]
        {
            get
            {
                return cars[index];
            }
            set
            {
                cars[index] = value;
            }
        }
    }
}
