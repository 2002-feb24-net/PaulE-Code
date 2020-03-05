using System;

namespace BetterMergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data =  {1,5,7,3,9,6,7};
            MergeSort(data);
            Console.WriteLine (data);
        }

        static void MergeSort(int[] array)
        {
            if(array.Length < 2)
            {
                return;
            }

            int middle = array.Length/2;

            int[] left = SubArray(array, 0, middle);
            int[] right = SubArray(array, middle, array.Length);

            MergeSort(left);
            MergeSort(right);

            int l = 0;
            int r = 0;
            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if(l >= left.Length)
                {
                    result[i] = right[r++];
                }
                else if (r >= right.Length)
                {
                    result[i] = left[l++];
                }
                if (left[l] <= right[r])
                {
                    result[i] = left[l++];
                }
                else
                {
                    result[i] = right[r++];
                }
            }


        }

        static int[] SubArray(int[] array, int start, int end)
        {
            int length = end - start;
            int[] result = new int[length];

            for (int i = 0; i< length; i++)
            {
                result[i] = array[start + i];
            }
            return result;
        }
    }
}
