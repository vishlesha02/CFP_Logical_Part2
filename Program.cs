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
            Console.WriteLine("press 8 to Exit");


            int choice=int.Parse(Console.ReadLine());
            
                switch (choice)
                {
                    case 1:
                    {
                        Console.WriteLine("Enter your choice ");
                        Console.WriteLine("Press 1 to  Add two numbers");


                        int choice1 = int.Parse(Console.ReadLine());
                        switch (choice1)
                        {
                            case 1:
                                {
                                    int result = basic.AddTwoNumbers (10,20);
                                    Console.WriteLine(result);
                                    break;
                                }

                            case 8:
                                { 
                                    break;
                                }

                            default: 
                                {
                                    break;
                                }
                        }
                        break;

                    }
                default:
                    {
                        break;
                    }

                    
               
            
                }




        }
    }
}
