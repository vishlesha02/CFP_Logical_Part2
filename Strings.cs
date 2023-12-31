﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical
{
    public class Strings
    {
        public bool BracketsSequence(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                {
                    count++;
                }
                else 
                {
                    count--;
                }
            }
            return count == 0;
        }

        public string AddSeparator(string letter,string separator)
        {
            string word = null;
            for (int i = 0; i < letter.Length; i++)
            { 
                word = word + letter[i];
                //word = word + separator;
                if (i != letter.Length - 1)
                { 
                    word += separator;
                }
            }
            return word;

        }

        public bool Palindrome(string str)
        {
            for (int i = 0; i < str.Length/2; i++)
            {
                if (str[i] != str[ str.Length-1-i])
                { 
                    return false; 
                }

            }
            return true;
        }

        public int LengthOfString(string str)
        {
            int count = 0;
         
            for (int i = 0; i < str.Length; i++)
            {
                count++;
            }
            return count;
        }

        public string StringInReverse(string str)
        {
            string newStr = "";

            for (int i = str.Length-1; i >=0; i--)
            {
               newStr += str[i];
            }
            return newStr;
        }

        public int SumDigitOfString(string str)
        {
            
            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    sum += (int)char.GetNumericValue(str[i]);

                }
            }
            return sum;
        }

        public string MakeUpperCase(string str)
        {
            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                {
                    newStr += char.ToUpper(str[i]);

                }
                else 
                {
                    newStr += str[i];
                }
            }

            return newStr;
        }

        public string MixTwoStrings(string str1, string str2)
        {
            string newStr = "";
            int maxLength = Math.Max(str1.Length, str2.Length);

            for (int i = 0; i < maxLength; i++)
            {
                if (i < str1.Length)
                {
                    newStr += str1[i];
                }
                if(i < str2.Length)
                {
                    newStr += str2[i];
                }
            }
            return newStr;
        }

        public int NumberOfWords(string str)
        {
            int count = 0;
            bool insideWord=false;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsWhiteSpace(str[i]))
                {
                     insideWord = false;
                }
                else if(!insideWord)
                {
                    insideWord= true;   
                    count++;
                }
            }
            return count ;
        }

        public int HowManyOccurrences(string str,string subStr)
        {
           
            int count = 0;

            int found;
            
            for (int i = 0; i < str.Length; i++)
            {
                found = str.IndexOf(subStr, i);

                if (found > -1)
                {
                    count++;
                    i = found;
                }
            }
            return count;
        
        }

        public char[] SortCharactersDescending(string arr)
        {
            char[] charArray = arr.ToCharArray();
            char temp;

            for (int i = 0; i < charArray.Length; i++)
            {
                for (int j = i + 1; j < charArray.Length; j++)
                {
                    if (charArray[i] < charArray[j])
                    {
                        temp = charArray[i];
                        charArray[i] = charArray[j];
                        charArray[j] = temp;
                    }
                }
            }
            return charArray;
        }
    }
}
