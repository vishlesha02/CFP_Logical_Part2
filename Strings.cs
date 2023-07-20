using System;
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
    }
}
