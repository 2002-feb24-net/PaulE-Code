using System;

namespace PalindromeLibrary
{
    public class Palindrome : IPalindrome
    {
        public bool IsPalindrome(string x)
        {
            if (x == "")
            {
                return true;
            }
            x = ConvertToPureString(x);
            x = x.ToLower();
            for (int i = 0; i<x.Length; i++)
            {
                if(x[i] != x[x.Length-i-1])
                {
                    return false;
                }
            }
            return true;
        }

        public string ConvertToPureString(string x)
        {
            char[] arr = x.ToCharArray();
            arr = Array.FindAll<char>(arr, (c => (char.IsLetterOrDigit(c))));
            x = new string(arr);
            return x;
        }
    }
}
