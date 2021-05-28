using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHelper
{
    public static class ConsoleHelper
    {
        /// <summary>
        /// Reads a number from the console.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="maxAttempts">Maximum amount of attempts</param>
        /// <param name="defaultValue">is 0 if no value was written</param>
        /// <returns>A number</returns>
        public static int ReadNumberFromConsole(string label, int maxAttempts, int defaultValue)
        {
            label = label ?? "please enter a number";
            int attempts = 0;

            while (attempts < maxAttempts)
            {
                Console.Write(label);
                string value = Console.ReadLine();

                if(int.TryParse(value, out int number))
                {
                    return number;
                }

                attempts++;
                Console.Write($"Value {value} is not a number! You have {maxAttempts-attempts} attempts left!");
            }
            return defaultValue;
        }

        /// <summary>
        /// Prints a given array transforming it into a string
        /// </summary>
        /// <param name="array">Given array</param>
       public static void PrintArray(string label, int[] array)
        {
            string result = string.Join(", ", array ?? new int[0]);

            Console.WriteLine($"{label} : {result}");
        }
    }
}
