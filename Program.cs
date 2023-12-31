﻿namespace Logical
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Basic basic = new Basic();
            ConditionalStatement conditional = new ConditionalStatement();
            Loops loop = new Loops();
            Strings strObj = new Strings();

            Console.WriteLine("Press 1 for Basic");
            Console.WriteLine("Press 2 for Conditional Statements");
            Console.WriteLine("Press 3 for Loops ");
            Console.WriteLine("Press 4 for Strings ");
            Console.WriteLine("press 5 to Exit");
            Console.WriteLine("-----------------------------------------");


            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Enter your choice");
                        Console.WriteLine("Press 1 to Add two numbers");
                        Console.WriteLine("Press 2 to Convert Celsius to Fahrenheit");
                        Console.WriteLine("Press 3 to Get Elementary Operation Results");
                        Console.WriteLine("Press 4 to Check if Result is same");
                        Console.WriteLine("Press 5 for Modulo Operations");
                        Console.WriteLine("Press 6 to Get Cube");
                        Console.WriteLine("Press 7 to swap Numbers");
                        Console.WriteLine("Press 8 to Exit");
                        Console.WriteLine("-----------------------------------------");


                        int choice1 = int.Parse(Console.ReadLine());

                        switch (choice1)
                        {
                            case 1:
                                {
                                    int result = basic.addTwoNumbers(10, 20);
                                    Console.WriteLine(result);
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine(basic.celsiusToFahrenheit(0));
                                    Console.WriteLine(basic.celsiusToFahrenheit(-300));
                                    Console.WriteLine(basic.celsiusToFahrenheit(100));

                                    break;
                                }
                            case 3:
                                {
                                    Console.WriteLine(basic.elementaryOperations(2, 2));
                                    break;
                                }
                            case 4:
                                {
                                    // Console.WriteLine(basic.isResultSame(2,2));
                                    Console.WriteLine(basic.isResultSame(2 + 2, 2 * 2));
                                    Console.WriteLine(basic.isResultSame(2 - 2, 4 / 2));
                                    break;

                                }
                            case 5:
                                {
                                    Console.WriteLine(basic.moduloOperations(8, 5, 2));
                                    break;
                                }
                            case 6:
                                {
                                    Console.WriteLine(basic.cube(2));
                                    Console.WriteLine(basic.cube(-5.5));
                                    break;
                                }
                            case 7:
                                {
                                    Console.WriteLine("Before Swap : a = 87,b = 45");
                                    Console.Write("After swap : ");
                                    Console.WriteLine(basic.swap(87, 45));
                                    Console.WriteLine("Before Swap : a = -13,b = 2");
                                    Console.Write("After swap : ");
                                    Console.WriteLine(basic.swap(-13, 2));
                                    break;

                                }
                            case 8:
                                {
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("You Entered Wrong Number");
                                    break;
                                }
                        }

                        break;
                    }
                case 2:

                    {

                        Console.WriteLine("Enter Your Choice");
                        Console.WriteLine("Press 1 to Get Absolute Value");
                        Console.WriteLine("Press 2 to Get multiplication if both numbers are divisible by 2 or 3, otherwise returns thier sum.");
                        Console.WriteLine("Press 3 to check if it consists only uppercase letters");
                        Console.WriteLine("Press 4 to check if multiplication or sum of two first numbers is greater than third one");
                        Console.WriteLine("Press 5 to check if checks if Number is even");
                        Console.WriteLine("Press 6 to check if array is sorted in ascending order.");
                        Console.WriteLine("Press 7 to check if at least one neighbour of middle letter is its neighbour in the alphabet.");
                        Console.WriteLine("Press 8 to check if if number is positive, negative or zero");
                        Console.WriteLine("Press 9 to check if year is leap");
                        Console.WriteLine("Press 10 to check if given number contains digit 3");

                        Console.WriteLine("-----------------------------------------");

                        int choice3 = int.Parse(Console.ReadLine());

                        switch (choice3)
                        {
                            case 1:
                                {
                                    Console.WriteLine(conditional.absoluteValue(6832));
                                    Console.WriteLine(conditional.absoluteValue(-392));
                                    break;

                                }
                            case 2:
                                {
                                    Console.WriteLine(conditional.divisibleByTwoOrThree(15, 30));
                                    Console.WriteLine(conditional.divisibleByTwoOrThree(2, 90));
                                    Console.WriteLine(conditional.divisibleByTwoOrThree(7, 12));
                                    break;
                                }
                            case 3:
                                {
                                    Console.WriteLine(conditional.upperCase("XYX"));
                                    Console.WriteLine(conditional.upperCase("dog"));
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine(conditional.greaterThanThirdOne(new int[] { 2, 7, 12 }));
                                    Console.WriteLine(conditional.greaterThanThirdOne(new int[] { -5, -8, 50 }));
                                    break;
                                }
                            case 5:
                                {
                                    Console.WriteLine(conditional.numberIsEven(4));
                                    Console.WriteLine(conditional.numberIsEven(3));
                                    break;
                                }
                            case 6:
                                {
                                    Console.WriteLine(conditional.sortedAscending(new int[] { 3, 7, 10 }));
                                    Console.WriteLine(conditional.sortedAscending(new int[] { 74, 62, 99 }));
                                    break;
                                }
                            case 7:
                                {
                                    Console.WriteLine(conditional.neighbour("XYZ"));
                                    Console.WriteLine(conditional.neighbour("GWK"));
                                    break;
                                }
                            case 8:
                                {
                                    Console.WriteLine(conditional.positiveNegativeZero(5.24));
                                    Console.WriteLine(conditional.positiveNegativeZero(0.0));
                                    Console.WriteLine(conditional.positiveNegativeZero(-994.53));
                                    break;
                                }
                            case 9:
                                {
                                    Console.WriteLine(conditional.leapYear(2016));
                                    Console.WriteLine(conditional.leapYear(2018));
                                    break;
                                }
                            case 10:
                                {
                                    Console.WriteLine(conditional.NumberContainsThree(7201432));
                                    Console.WriteLine(conditional.NumberContainsThree(72014));
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("You Entered Wrong Number");
                                    break;
                                }

                        }
                        break;

                    }

                case 3:
                    {
                        Console.WriteLine("Press 1 to get 10 by 10 multiplication table");
                        Console.WriteLine("Press 2 to get sum of Series (fractions)");
                        Console.WriteLine("Press 3 to get sorted array in ascending order");
                        Console.WriteLine("Press 4 to get biggest number in this array");
                        Console.WriteLine("Press 5 to return number of times that two 7's are next to each other in an array");
                        Console.WriteLine("Press 6 to checks if there are three adjacent numbers where second is greater by 1 than the first one and third is greater by 1 than the second one");
                        Console.WriteLine("Press 7 to return a string of even numbers greater than 0 and less than 100");
                        Console.WriteLine("Press 8 to draw hourglass shape");
                        Console.WriteLine("Press 9 to draw parallelogram");
                        Console.WriteLine("Press 10 to draw Christmas Tree");
                        Console.WriteLine("Press 11 to get full sequence of letters starting from first and ending at the second one");
                        Console.WriteLine("Press 12 to get value of the longest strictly increasing sequence of numbers");
                        Console.WriteLine("Press 13 to return sum of its digits");
                        Console.WriteLine("Press 14 to return sum of all integers and average from range [n, m]");
                        Console.WriteLine("Press 15 to return sum of objects of double type");
                        Console.WriteLine("Press 16 to draw triangle shape");
                        Console.WriteLine("Press 17 to return first number raised to the power of second one");
                        Console.WriteLine("Press 18 to check if there are exactly the same letters on the left side and right side of the string");
                        Console.WriteLine("-----------------------------------------");

                        int choice4 = int.Parse(Console.ReadLine());

                        switch (choice4)
                        {
                            case 1:
                                {
                                    loop.MultiplicationTable();
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine(loop.FractionSum(5));
                                    break;
                                }
                            case 3:
                                {
                                    int[] sortedArr = loop.SortArrayAscending(new int[] { 0, -23, 9, 18, -51, 1, 90, 57, -1, 25 });

                                    foreach (var s in sortedArr)
                                    {
                                        Console.Write($"{s} ");
                                    }
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine(loop.BiggestNumber(new int[] { 190, 291, 145, 209, 280, 300 }));
                                    break;
                                }
                            case 5:
                                {
                                    Console.WriteLine(loop.TwoSevens(new int[] { 8, 2, 5, 7, 9, 0, 7, 7, 3, 1 }));
                                    Console.WriteLine(loop.TwoSevens(new int[] { 9, 4, 5, 3, 7, 7, 7, 3, 2, 5, 7, 7 }));
                                    break;
                                }
                            case 6:
                                {
                                    Console.WriteLine(loop.IncreasingAdjacent(new int[] { 45, 23, 44, 68, 65, 70, 80, 81, 82 }));
                                    Console.WriteLine(loop.IncreasingAdjacent(new int[] { 7, 3, 5, 8, 9, 3, 1, 4 }));
                                    break;
                                }
                            case 7:
                                {
                                    Console.WriteLine(loop.EvenNumbers());
                                    break;
                                }
                            case 8:
                                {
                                    loop.HourGlass();
                                    break;
                                }
                            case 9:
                                {
                                    loop.Parallelogram();
                                    break;
                                }
                            case 10:
                                {
                                    loop.ChristmasTree();
                                    break;
                                }
                            case 11:
                                {
                                    Console.WriteLine(loop.SequenceOfLetters("bg"));
                                    Console.WriteLine(loop.SequenceOfLetters("ap"));
                                    break;
                                }
                            case 12:
                                {
                                    Console.WriteLine(loop.LongestStrictlyIncreasingSequence(new int[] { 4, 7, 2, 6, 4, 5, 6, 7, 8, 0, 7, 1, 2, 3 }));
                                    break;
                                    // 2 4 6 7 8 99 100 
                                    // 1 23 4 5
                                }
                            case 13:
                                {
                                    Console.WriteLine(loop.DigitsSum(5434));
                                    Console.WriteLine(loop.DigitsSum(904861));
                                    break;
                                }
                            case 14:
                                {
                                    Console.WriteLine(loop.SumAndAverage(11, 66));
                                    Console.WriteLine(loop.SumAndAverage(-10, 0));
                                    break;
                                }
                            case 15:
                                {
                                    Console.WriteLine(loop.SumDoubleOnly(new object[] { "abc", 5.6, 14, 'c', true, 'x', false, 567, 2.22 }));
                                    break;
                                }
                            case 16:
                                {
                                    loop.DrawTriangle();
                                    break;
                                }
                            case 17:
                                {
                                    Console.WriteLine(loop.ToThePowerOf(-2, 3));
                                    Console.WriteLine(loop.ToThePowerOf(5, 5));
                                    break;
                                }
                            case 18:
                                {
                                    Console.WriteLine(loop.LettersBalance("fgvgvf"));
                                    Console.WriteLine(loop.LettersBalance("lampddn"));
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("You Entered Wrong Number");
                                    break;
                                }
                        }
                        break;
                    }

                case 4:
                    {
                        Console.WriteLine("press 1 to check sequence of brackets");
                        Console.WriteLine("press 2 add separator between each adjacent characters in a string");
                        Console.WriteLine("press 3 to check if it is a palindrome (is read the same backward as forward)");
                        Console.WriteLine("press 4 to return length of string");
                        Console.WriteLine("press 5 to return string in reverse order");
                        Console.WriteLine("press 6 to sum of all digits in that string");
                        Console.WriteLine("press 7 to return new string in which every odd letter of the word is uppercase");
                        Console.WriteLine("press 8 to return one string made of two strings. First letter of new string is first letter of first string, second letter of new string is first letter of second string ");
                        Console.WriteLine("press 9 to count number of words in a string");
                        Console.WriteLine("press 10 to return number of occurrences of substring in the string");
                        Console.WriteLine("press 11 to write a method that returns array of chars (ASCII characters) sorted in descending order");
                        Console.WriteLine("-----------------------------------------");

                        int choice5 = int.Parse(Console.ReadLine());

                        switch (choice5)
                        {
                            case 1:
                                {
                                    Console.WriteLine(strObj.BracketsSequence("((()))"));
                                    Console.WriteLine(strObj.BracketsSequence("()(())("));
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine(strObj.AddSeparator("ABCD", "^"));
                                    Console.WriteLine(strObj.AddSeparator("chocolate", "-"));
                                    break;
                                }
                            case 3:
                                {
                                    Console.WriteLine(strObj.Palindrome("eye"));
                                    Console.WriteLine(strObj.Palindrome("home"));
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine(strObj.LengthOfString("computer"));
                                    Console.WriteLine(strObj.LengthOfString("ice cream"));
                                    break;
                                } 
                            case 5:
                                {
                                    Console.WriteLine(strObj.StringInReverse("qwerty"));
                                    Console.WriteLine(strObj.StringInReverse("oe93 kr"));
                                    break;
                                }
                            case 6:
                                {
                                    Console.WriteLine(strObj.SumDigitOfString("1q2w3e"));
                                    Console.WriteLine(strObj.SumDigitOfString("L0r3m.1p5um"));
                                    break;
                                }
                            case 7:
                                {
                                    Console.WriteLine(strObj.MakeUpperCase("modem"));
                                    Console.WriteLine(strObj.MakeUpperCase("BookWorm"));
                                    Console.WriteLine(strObj.MakeUpperCase("Aliquam dolor nisl?"));
                                    break;
                                }
                            case 8:
                                {
                                    Console.WriteLine(strObj.MixTwoStrings("aaa", "BBB"));
                                    Console.WriteLine(strObj.MixTwoStrings("good one", "111"));
                                    break;
                                }
                            case 9:
                                {
                                    Console.WriteLine(strObj.NumberOfWords("This is sample sentence"));
                                    Console.WriteLine(strObj.NumberOfWords("OK"));
                                    break;
                                } 
                            case 10:
                                {
                                    Console.WriteLine(strObj.HowManyOccurrences("do it now","do"));
                                    Console.WriteLine(strObj.HowManyOccurrences("empty", "d"));
                                    break;
                                } 
                            case 11:
                                {
                                    Console.WriteLine(strObj.SortCharactersDescending("abcdefg"));
                                    Console.WriteLine(strObj.SortCharactersDescending("hijklmnop"));
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("You Entered Wrong Number");
                                    break;
                                }
                        }
                        break;
                    }
                case 5:
                    {
                        break;
                    }
                default:

                    {
                        Console.WriteLine("You Entered Wrong Number");
                        break;

                    }
            }
        }
    }
}

