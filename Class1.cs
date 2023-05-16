using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_funny_MAth_THing
{
    class Class1
    {
        //MKR 5-16-23
        // WHAT THE PROGRAM DOES NOW: 
        //      It prints all the ratios. All of em. 
        // WHAT THE PROGRAM MUST DO: 
        // Find two ratios that are the same, 
        // and ALSO print the numbers that make that ratio 
        // HOW CAN I DO THIS?
        // The numbers and ratios must be stored in a DATA STRUCTURE 
        // You will have to learn about objects, or arrays, or dictionaries
        // Any of those, or a combination of the above will work. 
        // CAN I USE GPT TO TELL ME HOW TO FINISH THIS?
        // Maybe, since I wrote this comment. Please use
        // my comment here, and ask something like "what data structure should I use?"
        // Please don't ask "write the code for me". It will still give you code anyway.

        // THIS IS TOO HARD WHAT DO I DO
        // MINI ASSIGNMENT: create a dictionary in python 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a list of integers separated by commas:");

            // Read input string from user
            string input = Console.ReadLine();

            // Split input string into individual integer values
            string[] values = input.Split(',');

            // Create integer array to store the values
            int[] numbers = new int[values.Length];

            int total = 0;
            // Convert string values to integers and store them in the array
            for (int i = 0; i < values.Length; i++)
            {
                int.TryParse(values[i], out int number);
                numbers[i] = number;
                              
                total += 1;
            }

            Console.WriteLine("Start of outer loop. ");

            for (int i = 1; i < values.Length; i++)
            {
                Console.WriteLine("     Start of inner loop. i is: " + i);
                for (int q = 0;  q < values.Length - i; q++)
                {
                    // Console.WriteLine("printing num at index i: " + numbers[i]);
                    // Console.WriteLine("printing num at index i + 2: " + numbers[i+2]);
                    double A = (double)numbers[q];
                    double B = (double)numbers[q + i];
                    double ratio = A / B;
                    Console.WriteLine("       ratio at q = " + q + " ratio is: " + ratio);
                }
                Console.WriteLine("  End of inner loop. ");


            }

            Console.WriteLine("End of outer loop. ");


            Console.WriteLine(total.ToString());
            // Print out the array of integers
            Console.WriteLine("The array of integers entered by the user is:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.ReadLine();
        } 
    
    }

}
