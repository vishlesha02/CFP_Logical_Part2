using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical
{
    public class Basic
    {
        public int addTwoNumbers(int a, int b)
        { 
            return a+b;
        }

        public string celsiusToFahrenheit(double celcius)
        {
            double fahrenheit;
            if (celcius < -273.15)
            {
                return "Temperature absolute Zero";
            }
            fahrenheit = ((celcius * 9 / 5) + 32);
            return $"{fahrenheit}";
        }

    }
}
