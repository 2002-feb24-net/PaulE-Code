using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 1000;
            int CountFizz = 0;
            int CountBuzz = 0;
            int CountFizzBuzz = 0;
            for (int i = 0; i<input; i++)
            {
                if (i % 3 == 0 && i% 5 != 0 )
                {
                    Console.Write("Fizz");
                    CountFizz += 1;
                }
                else if (i%5 == 0 && i%3 != 0)
                {
                    Console.Write("Buzz");
                    CountBuzz += 1;
                }
                else if (i%5==0 && i%3==0)
                {
                    Console.Write("Fizzbuzz");
                    CountFizzBuzz += 1;
                }
                else
                {
                    Console.Write (i);
                }
                Console.WriteLine();
            }
            Console.Write("Fizz: {0} Buzz:{1} Fizzbuzz:{2}", CountFizz, CountBuzz, CountFizzBuzz);
            // Fizz = 267 Buzz = 133 Fizzbuzz = 67
        }
    }
}
