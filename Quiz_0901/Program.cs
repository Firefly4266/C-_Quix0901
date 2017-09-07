using System;
using System.Linq;

/* 2) Write a program that will accept two integers as input from the user.
    It should then return every number that is evenly divisible by 6 on a
    single line delimited by colons(:).  Finally, it should return a line
    stating how many numbers were in fact divisible by 6.*/

namespace Quiz_0901
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            Console.Write("Please enter a number: ");
            string num1 = Console.ReadLine();
            int userRes1 = int.Parse(num1);

            Console.Write("Enter a second number (larger than first): ");
            string num2 = Console.ReadLine();
            int userRes2 = int.Parse(num2);

            int[] range = Enumerable.Range(userRes1, userRes2).ToArray();

            for (int i = 0; i < range.Length; i++)
            {
                if (range[i] % 6 == 0)
                {
                    Console.Write(range[i] + ": ");
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("{0} numbers were divisible by 6.", count);
        }
    }
}
