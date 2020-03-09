using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameToGradeMap = new Dictionary<string, int>();

            nameToGradeMap["Bob"] = 91;

            string[] names = {"A","B","C"};
            int[] grades = {1,2,3};
            nameToGradeMap = new Dictionary<string, int>()
            {
                ["Bill"] =59
            };

        }

        class Student
        {
            string name;
            int grade;
        }
    }
}
