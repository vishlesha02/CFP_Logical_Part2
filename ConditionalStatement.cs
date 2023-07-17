using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical
{
    public class ConditionalStatement
    {
        public int absoluteValue(int a)
        {
            return Math.Abs(a);
        
        }

        public double divisibleByTwoOrThree(int a,int b)
        {
            if (a % 2 == 0 && b % 2 == 0 || a % 3 == 0 && b % 3 == 0)
            {
                return a * b;
            }
            return a + b;
        }

        public bool upperCase(string a)
        {
            return (a[0] >= 65 && a[1] >= 65 && a[2] >= 65) && (a[0] <= 90 && a[1] <= 90 && a[2] <= 90);
        
        }

        public bool greaterThanThirdOne(int[] arr)
        {
            int mul = arr[0] * arr[1];
            int sum = arr[0] + arr[1];
            if (mul > arr[2] || sum > arr[2])
            {
                return true;
            }
            return false;
        }
    }
}
