using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Fuctional Programming application.\n");
            Console.WriteLine("Please choose number as shown below to run corresponding application\n");
            Console.WriteLine("1:Flip coin\n2:Leap Year");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter the Number of time you would like to flip the coin");
                    int numOfTurns = Convert.ToInt32(Console.ReadLine());
                    FlipCoin.FlipACoin(numOfTurns);
                    break;
                case 2:
                    Console.WriteLine("Enter the year you would like to check : ");
                    int yearCheck = Convert.ToInt32(Console.ReadLine());
                    LeapYear.LeapYears(yearCheck);
                    break;
                default:
                    Console.WriteLine("Enter a valid number. Terminating application");
                    break;
            }
            Console.ReadLine();
        }
    }
}

