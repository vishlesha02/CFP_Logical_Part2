using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical
{
    public class Loops
    {
        
        public void MultiplicationTable()
        {
            
            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine();

                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(i * j + "\t");
                
                }
            
            }
            
        }

        public double FractionSum(int num)
        {
            double  j=0.0;
            for (double i = 1; i <= num; i++)
            {
                j = j+(1/(i*i));
                
            }
            return j;
        }
    }
}
