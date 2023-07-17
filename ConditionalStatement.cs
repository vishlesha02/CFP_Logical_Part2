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
            if (a % 2 == b % 2 || a % 3 == b % 3)
            {
                return a * b;
            }
            return a + b;
        }
    }
}
