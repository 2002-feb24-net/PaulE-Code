using System;

namespace Day5MorningWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a multi-word phrase. For example, 'computer processing unit'.");
            Acronize(Console.ReadLine());
        }

        static string Acronize(string x)
        {
            string[] MyWordList = x.Split(" ");
            for (int i; i<MyWordList.Length;i++)
            {

            }
            return;
        }
    }
}
