using System;

namespace IterationStatements
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            string input = Console.ReadLine() ?? string.Empty;
            int number = input != null ? int.Parse(input) : 0;

            if (IsWithinRange(number))
            {
                Console.WriteLine($"{number} is within the range -10 to 10.");
            }
            else
            {
                Console.WriteLine($"{number} is not within the range -10 to 10.");
            }

            DisplayMultiplicationTable(number);

            Program program = new Program();

            program.PrintNumbers1000toMinus1000();
            program.PrintNumbers3to999By3();
            program.CheckIfNumbersAreEqual(5, 10);
            program.CheckIfNumberIsEvenOrOdd(7);
            program.CheckIfNumberIsPositiveOrNegative(-3);
            program.CheckIfCandidateCanVote("20");
        } // End of Main method

        // Print numbers 1000 to -1000.
        public void PrintNumbers1000toMinus1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        // Print numbers 3 to 999, incrementing by 3 each time.
        public void PrintNumbers3to999By3()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        // Method to check equality of two integers.
        public void CheckIfNumbersAreEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("The numbers are equal.");
            }
            else
            {
                Console.WriteLine("The numbers are not equal.");
            }
        }

        // Determine if a number is even or odd.
        public void CheckIfNumberIsEvenOrOdd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
        }

        // Check if a number is positive or negative.
        public void CheckIfNumberIsPositiveOrNegative(int num)
        {
            if (num > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }

        // Determine voting eligibility based on age.
        public void CheckIfCandidateCanVote(string ageInput)
        {
            int age;
            bool success = int.TryParse(ageInput, out age);

            if (!success)
            {
                Console.WriteLine("Invalid age input.");
                return;
            }

            if (age >= 18)
            {
                Console.WriteLine("The candidate can vote.");
            }
            else
            {
                Console.WriteLine("The candidate cannot vote.");
            }
        }

        // Check if an integer is within the range -10 to 10.
        static bool IsWithinRange(int num)
        {
            return num >= -10 && num <= 10;
        }

        // Display the multiplication table (1 to 12) of a given integer.
        static void DisplayMultiplicationTable(int num)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }
    }
}
