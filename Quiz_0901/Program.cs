using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Console.Write("Enter a second number: ");
            string num2 = Console.ReadLine();
            int userRes2 = int.Parse(num2);

            if (userRes1 % 6 == 0)
            {
                Console.Write(userRes1 + ": ");
                count++;
            }

            if (userRes2 % 6 == 0)
            {
                Console.Write(userRes2 + ": ");
                count++;
            }
            Console.WriteLine();
            Console.WriteLine("{0} numbers were divisible by 6.", count);

        }
    }
}
