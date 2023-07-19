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
            double j = 0.0;
            for (double i = 1; i <= num; i++)
            {
                j = j + (1 / (i * i));

            }
            return j;
        }

        public int[] SortArrayAscending(int[] arr)
        {
            int temp;
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                for (int j = i + 1; j <= arr.Length - 1; j++)
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
            for (int i = 1; i < arr.Length; i++)
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
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == 7 && arr[i + 1] == 7)
                {
                    count++;
                }
            }
            return count;
        }

        public bool IncreasingAdjacent(int[] arr)
        {
            bool found = false;
            for (int i = 0; i < arr.Length - 2; i++)
            {
                if (arr[i] + 1 == arr[i + 1] && arr[i + 1] + 1 == arr[i + 2])
                {
                    found = true;
                }
            }
            return found;
        }

        public string EvenNumbers()
        {
            string str = string.Empty;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    str += i + " ";
                }
            }
            return str;
        }

        public void HourGlass()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = i; j <= 5; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            for (int i = 4; i >= 1; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = i; j <= 5; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }

        public void Parallelogram()
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 8; k++)
                {

                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }

        public void ChristmasTree()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                for (int l = 2; l <= i; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                for (int l = 2; l <= i; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                for (int l = 2; l <= i; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public string SequenceOfLetters(string word)
        {
            string fullSequence = null;
            for (int i = word[0]; i <= word[1]; i++)
            {
                fullSequence = fullSequence + (char)(i);
            }

            return fullSequence;
        }


        public int LongestStrictlyIncreasingSequence(int[] arr)
        {
            int tempLongest = 0;
            int longest = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {

                if (arr[i + 1] > arr[i])
                {
                    tempLongest++;
                }
                else
                {
                    tempLongest = 0;
                }

                if (tempLongest > longest)
                {
                    longest = tempLongest;
                }

            }
            return longest;
        }

        public int DigitsSum(int num)
        {
            int sum = 0;
            while (num > 0)
            {

                sum = sum + num % 10;
                num = num / 10;
                Console.WriteLine();


            }
            return sum;
        }

        public string SumAndAverage(int n,int m)
        {
            int sum = 0;
            int count = 0;
            double avg=0.0;
                for (int i = n; i <= m; i++)
                {
                sum = sum + i;
                count++;
                }
            avg = sum / (double)count;

            return $"sum = { sum} avg={avg}";
            
        }

    }
}
