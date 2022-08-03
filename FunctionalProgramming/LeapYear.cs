using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    class LeapYear
    {
        public static void LeapYears(int year)
        {
            if((year>=1000)&&(year<=9999))
            {
                if(((year%4==0)&&(year%100!=0))||(year%400==0))
                {
                    Console.WriteLine("{0} is a leap year.", year);
                }
                else
                {
                    Console.WriteLine("{0} is not a leap year.", year);
                }
            }
            else
            {
                Console.WriteLine("Please make sure the year has 4 digits");
            }
        }

    }
}
