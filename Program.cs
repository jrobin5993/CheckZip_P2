using System;

/*
 * Name:            JaLeel Robinson
 * Date:            06-26-2024
 * Descriptiopn:    CSC242-0101-CheckZip
 * Resource:
 */

namespace CheckZip
{
    class Program
    {
        static void Main(String[] args)
        {
            // This program allows the user to enter 10 zip codes.
            // The program then sorts the data and displays the
            // data in order.

            // Initialize the array with 10 zip codes
            int[] zipCodes = new int[10];
            Console.WriteLine("Please enter 10 zip codes, press Enter after each.");

            // Loop to collect zip codes from the user
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter zip code [i + 1]: ");
                while (!int.TryParse(Console.ReadLine(), out zipCodes[i]) || zipCodes[i] < 0)
                {
                    Console.Write("Invalid input. Please enter a valid positive zip code: ");
                }
            }

            //Sort the zip codes
            Array.Sort(zipCodes);
            Console.WriteLine("\nThe sorted zip codes are:");

            // Loop to display the sorted zip codes
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(zipCodes[i]);
            }

            // Keep the console window open
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();

        }
    }
}