using System;

namespace Armstrong_Number
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Stores input number in the variable originalNumber
            int originalNumber;
            // Stores single digit of the given number
            int remainder;
            // Stores sum of digits of the given number
            int sum = 0;
            /* TempNumber will have a copy of the given number for the calculation.
            Value of variable originalNumber would change in the below while-loop.
            We are storing it in another variable to compare the results at 
            the end of the program */
            int tempNumber;
            // Print message line  
            Console.WriteLine("Enter the number: ");
            // Store number in originalNumber variable with type cast
            originalNumber = int.Parse(Console.ReadLine());

            // To account for numbers larger than 999
            int numLength = originalNumber.ToString().Length;

            // Copy original number into tempNumber
            tempNumber = originalNumber;

            Console.WriteLine("\n\n");
            Console.WriteLine("==== Before Logic ====");
            Console.WriteLine("======================");
            Console.WriteLine("Original number is: " + originalNumber);
            Console.WriteLine("Temporary number is: " + tempNumber);
            Console.WriteLine("Sum of digit is: " + sum);

            Console.WriteLine("\n\n");
            Console.WriteLine("==== In Logic ====");
            Console.WriteLine("==================");
            Console.WriteLine("\n");

            // Main Armstrong logic
            // We are adding base power of every digit and storing the sum in variable sum

            while (originalNumber > 0)
            {
                remainder = originalNumber % 10;
                Console.WriteLine("Remainder number is: " + remainder);
                sum = (int)(sum + Math.Pow(remainder, numLength));
                Console.WriteLine("Sum of single digit number is: " + sum);
                originalNumber = originalNumber / 10;
                Console.WriteLine("Original number is: " + originalNumber);
                Console.WriteLine("=====================================");
            }

            Console.WriteLine("\n");
            Console.WriteLine("=========================================");

            // Compare the value of tempNumber and a sum variable
            if (tempNumber == sum)
            {
                // If the value of tempNumber and the sum variable are the same, number is Armstrong
                Console.WriteLine("Entered number is an Armstrong number");
            }
            else
            {
                // If the values are not the same, it is not
                Console.WriteLine("Entered number is not an Armstrong number");
            }
            Console.WriteLine("\n");
        }
    }
}