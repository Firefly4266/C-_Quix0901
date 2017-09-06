using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 3)	Write a program that will ask for the user to supply the size of an array.
        Then ask the user to enter enough random numbers to fill the array.  The
        output of the program should be each number printed out on a single line
        sorted in ascending order. */

namespace Quiz_0901
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please specify an array size (interger value): ");
            string input = Console.ReadLine();
            int size = int.Parse(input);
            int[] tree = new int[size];

            for (int i = 0; i < tree.Length; i++)
            {
                int count = 0;
                if (tree.Length != count)
                {
                    Console.Write("Enter intergers to fill the array to the number specified: ");
                    input = Console.ReadLine();
                    int value = int.Parse(input);
                    tree[i] = value;
                    count++;
                }
            }
            Console.WriteLine(tree.Length);
        }
    }
}
