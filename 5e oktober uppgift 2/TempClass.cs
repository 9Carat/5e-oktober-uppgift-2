using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5e_oktober_uppgift_2
{
    internal class TempClass
    {
        public double celsius; // Testa att bara använda en variabel så kommer constructorn att funka!
        public double fahrenheit;
        public double kelvin;

        //public TempClass(double celsius) // Constructorn funkar om vi istället bara använder en variabel som innehåller temperaturen vi matar in
        //{
        //    this.celsius = celsius;
        //}

        public virtual double Convert(double celsius) // Efter som att vi inte har en constructor behöver vi mata in tempen direkt i metoden 
        {
            double kelvin = celsius + 273;
            return kelvin;
        }
    }
}
