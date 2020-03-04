using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] MyArray = GetInput();
            //BubbleSort(MyArray);
            foreach (int var in BubbleSort(MyArray))
            {
                Console.Write(var+",");
            }
        }

        static int[] GetInput()
        {
            Console.WriteLine("Please put in any number of numbers, seperated by spaces. Example: 2 3 4 5");
            string x = Console.ReadLine();
            string[] y = x.Split(" ");
            int[] z = new int[y.Length];
            for(int i = 0; i<y.Length;i++)
            {
                z[i] = int.Parse(y[i]);
            }
            return z;
            
        }

        static int[] BubbleSort(int[] y)
        {
            bool error = true;
            while (error == true)
            {
                error = false;
                for (int i = 1;i<y.Length;i++)
                {
                    if(y[i]<y[i-1])
                    {
                        error = true;
                        int temp = y[i];
                        y[i] = y[i-1];
                        y[i-1] = temp;
                    }
                }
            }
            return y;
        }
    }
}
