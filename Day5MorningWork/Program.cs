﻿using System;

namespace Day5MorningWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a multi-word phrase. For example, 'computer processing unit'.");
            Console.WriteLine(Acronize(Console.ReadLine()));
        }

        static string Acronize(string x)
        {
            string[] MyWordList = x.Split(" ");
            string result = "";

            for (int i=0; i<MyWordList.Length;i++)
            {
                result = result + MyWordList[i].Substring(0,0);
                MyWordList[i].TrimStart();
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
