﻿using System;
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

        public string elementaryOperations(int a,int b)
        {
            int add = a + b;
            int sub = a - b;
            int mul = a * b;
            int div = a / b;
        
            return $"{add},{sub},{mul},{div}";
        }

        

    }
}
