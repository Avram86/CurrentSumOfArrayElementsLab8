using System;

namespace CurrentsumOfArrayElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the length of the array:");
            string input = Console.ReadLine();

            if(int.TryParse(input, out int length))
            {
                int[] nums = new int[length];
                Random rmd = new Random();

                for(int i = 0; i < length; i++)
                {
                    nums[i] = rmd.Next(0, 1000);
                }

                Console.WriteLine();
                Console.Write("The array is:");
                foreach(var elem in nums)
                {
                    Console.Write($"{elem}, ");                    
                }

                Console.WriteLine();

                int[] output = new int[nums.Length];
                for(int i = 0; i < nums.Length; i++)
                {
                    output[i] = SumaCurenta(i, nums);
                }

                Console.Write("The output array is: ");
                foreach(var element in output)
                {
                    Console.Write($"{element}, ");
                }
                Console.WriteLine();
            }

           
        }

        private static int SumaCurenta(int index, int[] array)
        {
            int suma=0 ;
            for (int i = 0; i <= index; i++)
            {
                suma =suma+ array[i];
            }
            return suma;
        }
    }
}
