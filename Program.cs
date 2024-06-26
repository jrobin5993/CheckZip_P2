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
            string[] zipCodes = { /* Your existing zip codes */ };
            double[] deliveryCharges = { /* Your delivery charges */ };

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Print all zip codes");
                Console.WriteLine("2. Print zip codes and delivery charges");
                Console.WriteLine("3. Search for a zip code");
                Console.WriteLine("4. Exit");

                int choice = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        // Print all zip codes
                        foreach (var zip in zipCodes)
                            Console.WriteLine(zip);
                        break;
                    case 2:
                        // Print zip codes and delivery charges
                        for (int i = 0; i < zipCodes.Length; i++)
                            Console.WriteLine($"{zipCodes[i]} - ${deliveryCharges[i]:F2}");
                        break;
                    case 3:
                        // Search for a zip code
                        Console.Write("Enter a zip code: ");
                        string searchZip = Console.ReadLine();
                        int index = Array.IndexOf(zipCodes, searchZip);
                        if (index != -1)
                            Console.WriteLine($"Delivery charge for {searchZip}: ${deliveryCharges[index]:F2}");
                        else
                            Console.WriteLine($"No delivery to {searchZip}");
                        break;
                    case 4:
                        // Exit
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}