using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Switchuing_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (1-3):");
            int number = int.Parse(Console.ReadLine());// same as conver.Toint32
            switch (number) 
            {
                case 1:
                    Console.WriteLine("you entered '1'");
                    break;
                    case 2:
                    Console.WriteLine("You entered '2'");
                    break;  
                    case 3:
                    Console.WriteLine("You entered '3'");
                    break;  
                    default:
                    Console.WriteLine("Invalid input. please enter a number between 1 and 3");
                    break;

                    
            }
            Console.WriteLine();
        }
        
    }
}
