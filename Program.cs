using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Basic basic = new Basic();
            ConditionalStatement conditional = new ConditionalStatement();

            Console.WriteLine("Press 1 for Basic");
            Console.WriteLine("Press 2 for Conditional Statements");
            Console.WriteLine("Press 3 for Loops ");
            Console.WriteLine("press 4 to Exit");
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
                                    Console.WriteLine(conditional.divisibleByTwoOrThree(15,30));
                                    Console.WriteLine(conditional.divisibleByTwoOrThree(2,90));
                                    Console.WriteLine(conditional.divisibleByTwoOrThree(7,12));
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
                                    Console.WriteLine(conditional.greaterThanThirdOne(new int[] {-5, -8, 50}));
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
                                    Console.WriteLine(conditional.sortedAscending(new int[] {3,7,10}));
                                    Console.WriteLine(conditional.sortedAscending(new int[] {74,62,99}));
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

