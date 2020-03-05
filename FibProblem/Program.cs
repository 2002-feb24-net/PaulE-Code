using System;
using System.Collections.Generic;

namespace FibProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFib(10));
        }

        static int GetFib(int i)
        {
            if (i == 0 || i == 1)
            {
                return i;
            }

            int total = 2;
            int counter = 2;
            int[] MyList = new int[i+1];
            MyList[0] = 1;
            MyList[1] = 1;

            while (counter < i)
            {
                MyList[counter] = MyList[counter-1] + MyList[counter-2];
                total = total+MyList[counter];
                counter++;
            }

            return total;
        }
    }
}
