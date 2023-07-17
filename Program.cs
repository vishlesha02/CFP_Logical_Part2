using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Basic basic=new Basic();

            Console.WriteLine("Press 1 for Basic");
            Console.WriteLine("Press 2 for Conditional Statements");
            Console.WriteLine("Press 3 for Loops ");
            Console.WriteLine("press 4 to Exit");
            Console.WriteLine("-----------------------------------------");


            int choice=int.Parse(Console.ReadLine());
            
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
                        Console.WriteLine("-----------------------------------------");


                        int choice1 = int.Parse(Console.ReadLine());

                        switch (choice1)
                        {
                            case 1:
                                {
                                    int result = basic.addTwoNumbers (10,20);
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
                                    Console.WriteLine(basic.elementaryOperations(2,2));
                                    break;
                                }
                            case 4:
                                {
                                    // Console.WriteLine(basic.isResultSame(2,2));
                                    Console.WriteLine(basic.isResultSame(2+2,2*2));
                                    Console.WriteLine(basic.isResultSame(2-2,4/2));
                                    break;

                                }
                            case 5:
                                {
                                    Console.WriteLine(basic.moduloOperations(8,5,2));
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
                                    Console.WriteLine(basic.swap(87,45));
                                    Console.WriteLine("Before Swap : a = -13,b = 2");
                                    Console.Write("After swap : ");
                                    Console.WriteLine(basic.swap(-13,2));
                                    break;

                                }
                            default: 
                                {
                                    Console.WriteLine("You Entered Wrong Option");
                                    break;
                                }
                        }
                        break;

                    }
                default:
                    {
                        Console.WriteLine("You Entered Wrong Option");
                        break;
                    }

                    
               
            
                }




        }
    }
}
