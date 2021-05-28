using System;
using ArrayHelper;

namespace CurrentsumOfArrayElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the length of the array:");
            int lengthOfArray = ArrayHelper.ConsoleHelper.ReadNumberFromConsole("", 5, 0);

            int[] nums = new int[lengthOfArray];
            Random rmd = new Random();

            for (int i = 0; i < lengthOfArray; i++)
            {
                nums[i] = rmd.Next(0, 1000);
            }

            Console.WriteLine();
            if (lengthOfArray < 1)
            {
                Console.WriteLine("No array was given!");               
            }
            else
            {
                ConsoleHelper.PrintArray("the given array is: ", nums);

                int[] output = new int[nums.Length];

                for (int i = 0; i < nums.Length; i++)
                {
                    output[i] = ArrayHelper.ArrayHelper.SumaCurenta(i, nums);
                }

                ArrayHelper.ConsoleHelper.PrintArray($"The resulted array is: ", output);
            }
            
        }


    }


}

