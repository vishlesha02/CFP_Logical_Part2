﻿using System;
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

        public bool numberIsEven(int num)
        {
            return (num % 2 == 0);
            
        }

        public bool sortedAscending(int[] arr)
        {
            return (arr[0] < arr[1] && arr[1] < arr[2]);
        }

        public bool neighbour(string str)
        {
            return (str[0] == str[1] - 1  || str[0] == str[1] + 1 || str[1] == str[2] - 1 || str[1] == str[2] + 1);
        }

        public string positiveNegativeZero(double num)
        {
            if (num > 0.0)
            {
                return "positive";
            }
            else if (num < 0.0)
            {
                return "negative";
            }
            return "Zero";
        }

        public bool leapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0 || year % 400 == 0);
        }

        public bool NumberContainsThree(int num)
        {
            while (num > 0)
            {
                if (num % 10 == 3)
                {
                    return true;
                }

                num = num/10;
            }
            return false;


        }
    }
}
