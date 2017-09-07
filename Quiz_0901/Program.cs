using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 1)	Write a program that will gather 10 numbers from a user.  You must return
    to the console the sum of the numbers. The final line should return the
    average of the numbers. */

namespace Quiz_0901
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("User, please enter 10 numbers: ");
            int count = 10;
            int tally = 0;
            while (count != 0)
            {
                if (tally != 0)
                {
                    Console.WriteLine("You have {0} numbers remaining to enter", count);
                }
                var input = Console.ReadLine();
                Console.WriteLine();
                int convertedInput = int.Parse(input);
                count--;
                tally += convertedInput;
                Console.WriteLine("Your running total is: {0}", tally);
            }
            Console.WriteLine("The AVERAGE of your numbers is: {0}", tally / 10);
        }
    }
}
