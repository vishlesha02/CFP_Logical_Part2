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

        public string elementaryOperations(int a,int b)
        {
            int add = a + b;
            int sub = a - b;
            int mul = a * b;
            int div = a / b;
        
            return $"{add},{sub},{mul},{div}";
        }

        public bool isResultSame(int a,int b)
        {
            /*int add = a + b;
            int sub = a - b;
            int mul = a * b;
            int div = a / b;
            if (add == mul)
            {
                return true;
            }
            if (sub == div)
            {
                return true;
            }

            return false;*/

            return a == b;
        }

        public double moduloOperations(int a,int b,int c)
        {         
            return a%b%c;
        }

        public double cube(double a)
        {
            return a * a * a;
        }

    }
}
