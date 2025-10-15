using System;

namespace part_1
{
    class EvenOrOdd
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("your number is Even :) ");
                }
                else
                {
                    Console.WriteLine("your number is Odd!");
                }
            }
            else
            {
                Console.WriteLine(" EROR! must be number !!");
            }

            Console.WriteLine("Tap 'Enter' to close ...");
            Console.ReadLine();
        }
    }
}
