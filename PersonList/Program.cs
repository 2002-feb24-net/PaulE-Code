using System;
using System.Collections.Generic;

namespace PersonList
{
    class Program
    {
        static List<Person> MyNameList = new List<Person> {};
        static string[] MyNames = new string[] {"RealPaul", "FakePaul", "Kyran", "Brenden", "Stacy","Diana", "FakeName", "RealName","Insertion","Testing"};
        static void Main(string[] args)
        {
            MakeList();
            Console.WriteLine("Starting List");
            PrintList(MyNameList);
            InsertionSort(MyNameList);
            Console.WriteLine("Ending List");
            PrintList(MyNameList);
        }

        private static void MakeList()
        {
            foreach(string value in MyNames)
            {
                if (!CheckName(value))
                {
                    var MyPerson = new Person(value);
                    MyNameList.Add(MyPerson);
                }
            }
        }

        private static void PrintList(List<Person> x)
        {
            foreach (Person value in x)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }

        private static bool CheckName(string x)
        {
            foreach (Person value in MyNameList)
            {
                if (value.GetName().ToUpper() == x.ToUpper())
                {
                    return true;
                }
            }
            return false;
        }

        private static void InsertionSort(List<Person> x)
        {

            // ! Insertion sort goes through a whole list with a chosen item. Bubble sort goes through the list swapping only adjacent pairs.
            // ! With an insertion sort, each item it only actively moved once (although it can still get bumped by thing being placed before it)
            for (int i = 1; i<x.Count; i++)
            {
                Person TempPerson = x[i];
                x.Remove(x[i]);
                int q = 0;
                while (q<i)
                {
                    if ((TempPerson.GetName()).CompareTo(x[q].GetName())>0)
                    {
                        q++;
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                x.Insert(q,TempPerson);
            }
        }
    }
}
