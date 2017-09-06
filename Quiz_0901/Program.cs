using System;
using System.Linq;

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
