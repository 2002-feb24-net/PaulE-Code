using System;

namespace Day2Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 8;
            for (int i = 0; i <= length; i++)
            {
                // c# has, alongside string (make with "double quotes")
                // also has "char" (character) (make with 's' ingle quotes)
                Console.WriteLine(new String(' ', length - i) + new String('#', i));
                string[] MyString = new string[] {"hi","bye"};
                MyString[1].Substring(0,1);
            }
        }
    }
}
