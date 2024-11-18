using System.ComponentModel.Design;

namespace Assignment_3_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a 4 digit year to check if it is/was a leap year");
            int userInput;

            if (int.TryParse(Console.ReadLine(), out userInput))

            {
                Console.WriteLine();

                if (IsLeapYear(userInput))
                {
                    Console.WriteLine($"{userInput} is a leap year");
                }

                else
                {
                    Console.WriteLine($"{userInput} is not a leap year");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input. Please enter a 4 digit year");
            }
        }



        static bool IsLeapYear(int year)
        {
            if (year % 4 == 0)

            {
                if (year % 100 == 0)

                {
                    return year % 400 == 0;
                }
                return true;
            }
            return false;

        }

    }
}


