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

        public int[] SortArrayAscending(int[] arr)
        {
            int temp;
            for (int i = 0; i <= arr.Length-1; i++)
            {
                for (int j = i + 1; j <= arr.Length-1; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                
                }
            }
            return arr;

        }

        public int BiggestNumber(int[] arr)
        {
            int biggest = arr[0];
            for (int i=1; i < arr.Length; i++)
            {
                if (arr[i] > biggest)
                {
                    biggest = arr[i];
                }
            }
            return biggest;
        }

        public int TwoSevens(int[] arr)
        {
            int count=0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] == 7 && arr[i+1]==7)
                {
                    count++;
                }
            }
            return count;
        }

        public bool IncreasingAdjacent(int[] arr)
        {
            bool found=false;
            for (int i=0;i< arr.Length-2;i++)
            {
                if (arr[i] + 1 == arr[i + 1] && arr[i+1]+1 == arr[i+2])
                {
                    found = true;
                }
            }
            return found;
        }
    }
}
