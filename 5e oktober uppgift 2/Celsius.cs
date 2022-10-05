using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5e_oktober_uppgift_2
{
    internal class Celsius : TempClass
    {
        //public Celsius(double celsius, double fahrenheit) : base(celsius)
        //{

        //}

        public override double Convert(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) + 5 / 9;
            return celsius; // C = (F – 32) * 5 / 9
        }
    }
}
