using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5e_oktober_uppgift_2
{
    internal class Fahrenheit : TempClass
    {
        //public Fahrenheit(double celsius) : base(celsius)
        //{

        //}

        public override double Convert(double celsius)
        {
            double fahrenheit = (celsius * 9) / 5 + 32; //F = (C * 9) / 5 + 32;
            return fahrenheit;
        }
    }
}
