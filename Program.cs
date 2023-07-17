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
                        Console.WriteLine("Enter your choice ");
                        Console.WriteLine("Press 1 to  Add two numbers");
                        Console.WriteLine("Press 2 to convert Celsius to Fahrenheit");
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
