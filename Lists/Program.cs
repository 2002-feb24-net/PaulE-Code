using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int howMany = numbers.Count();
            numbers.Add(123);
            int firstItem = numbers[0];
            // int thirdItem = numbers[2];

            numbers[0] = 5;
            numbers.Insert(0, 1000);

            numbers.Contains(500);
            numbers.Add(500);
            numbers.Contains(500);

            numbers.RemoveAt(2);
            numbers.Remove(500);

            foreach(int num in numbers)
            {
                sum += sum;
            }
        }
    }
}
