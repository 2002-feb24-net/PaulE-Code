﻿using System;
using PalindromeLibrary;

namespace ConsoleApp1
{
    class MainFile
    {
        static void Main(string[] args)
        {
            Console.Write("Input String: ");
            string x = Console.ReadLine();
            var MyPalinDromeChecker = new Palindrome();
            Console.WriteLine(MyPalinDromeChecker.IsPalindrome(x));
        }
    }
}




/*
in your personal code repo, in a folder named `Palindrome`:
two projects, a library project and a unit test project.
library should have an interface defining a type which can check if a string is a palindrome.
library should have a class that implements that interface.
all the behavior of the class should be unit tested.

a palindrome reads the same forwards and backwards.
for example, these should be considered palindromes:
- "nurses run"
- "racecaR"
- "1221"
- "never odd, or even."
and these should not be considered palindromes:
- "one two one"
- "123abccba123"
*/