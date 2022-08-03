using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    class FlipCoin
    {
        public static void FlipACoin(int turn)
        {
            Random random = new Random();
            if (turn > 0)
            {
                int head = 0;
                int tail = 0;
                for (int i = 1; i <= turn; i++)
                {
                    int flipCheck = random.Next(0, 2);
                    if (flipCheck == 1)
                    {
                        head++;
                    }
                    else
                    {
                        tail++;
                    }
                }
                double percentageOfHeads = (head * 100) / turn;
                Console.WriteLine("Number of time head come after fliping the coin is : {0}\nThe percentage of Heads is : {1}%", head, percentageOfHeads);
                double percentageOfTails = (tail * 100) / turn;
                Console.WriteLine("Number of time tail come after fliping the coin is : {0}\nThe percentage of Tails is : {1}%", tail, percentageOfTails);
            }
            else
            {
                Console.WriteLine("Please enter a positive value to flip the coin.");
            }
        }
    }
}


