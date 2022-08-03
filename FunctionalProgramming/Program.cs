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
            Console.WriteLine("Please choose number between 1 to 10 as shown below\n");
            Console.WriteLine("1:Flip a coin");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter the Number of time you would like to flip the coin");
                    int numOfTurns = Convert.ToInt32(Console.ReadLine());
                    FlipCoin.FlipACoin(numOfTurns);
                    break;
                default:
                    Console.WriteLine("Enter a valid number. Terminating application");
                    break;
            }
            Console.ReadLine();
        }
    }
}

