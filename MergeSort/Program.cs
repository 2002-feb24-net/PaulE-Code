using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // ! It divides input array in two halves, sorts the two halves and then merges the two sorted halves.

            // * Gathers the users input. See GetInput Method for more

            int[] MergeArray = new int[] {3,2,1};
            
            foreach (int var in MergeSort(MergeArray,0,MergeArray.Length - 1))
            {
                Console.Write(var+",");
            }


            int[] MyArray = GetInput();

            // creates 2 empty arrays with half the length of the main array (to break it in half)
            // adds one to length to handle odd numbers. Will be empty for evens, but doesnt break the code.

            int[] Array1 = new int[(MyArray.Length/2)+1];
            int[] Array2 = new int[(MyArray.Length/2)+1];

            // * adds the numbers to both halfs by using the half length as a devider
            // this doesnt have to be done at the same time, but more efficient

            for (int i = 0; i<Array1.Length;i++)
            {
                Array1[i] = MyArray[i];
                Array2[i] = MyArray[i+((MyArray.Length/2)-1)];
            }

            // * uses a foreach loop to print out every number in the sorted and merged array
            // TODO : see SortArray method for more info on sorting and merging the two halves

            foreach (int var in SortArray(Array1,Array2))
            {
                Console.Write(var+",");
            }

        }

        static int[] GetInput()
        {
            // * Asks the user for an input, and then stores that input

            Console.WriteLine("Please put in any number of numbers, seperated by spaces. Example: 2 3 4 5");
            string x = Console.ReadLine();

            // * divides the input by spaces
            // the output here is still strings, and needs to be converted to ints

            string[] y = x.Split(" ");

            // * makes a int array to store the converted string array

            int[] z = new int[y.Length];

            // * goes through the list of strings to convert them to ints, and then places them into our int array

            for(int i = 0; i<y.Length;i++)
            {
                z[i] = int.Parse(y[i]);
            }

            // * returns the int array

            return z;
            
        }

        static int[] SortArray(int[] x,int[] y)
        {
            // ! method uses the bubble sorter to go through both halves, sort them, and then merge them

            // * makes a boolean to check if the array has been changed in one pass of the loop. 
            // resets on every new pass of loop

            bool error = true;
            while (error == true)
            {
                error = false;
                // starts at index 1 and looks backwards, to avoid out of bounds errors.
                for (int i = 1;i<x.Length;i++)
                {
                    // swaps if not in order, and sets the boolean to true (so it will loop again)
                    if(x[i]<x[i-1])
                    {
                        error = true;
                        int temp = x[i];
                        x[i] = x[i-1];
                        x[i-1] = temp;
                    }
                    // same thing, but for the 2nd half. I decided to loop through both arrays at the same time. 
                    // this is technically slower and less efficient, but wtevr
                    if(y[i]<y[i-1])
                    {
                        error = true;
                        int temp = y[i];
                        y[i] = y[i-1];
                        y[i-1] = temp;
                    }
                }
            }

            //creates a new long array that is long enough to store both sorted halves
            int[] z = new int[x.Length+y.Length];
            for (int i = 0; i<z.Length; i=i+2)
            {
                z[i] = x[i/2];
                z[i+1] = y[i/2];
            }

            // same loop
            error = true;
            while (error == true)
            {
                error = false;
                for (int i = 1;i<z.Length;i++)
                {
                    if(z[i]<z[i-1])
                    {
                        error = true;
                        int temp = z[i];
                        z[i] = z[i-1];
                        z[i-1] = temp;
                    }
                }
            }

            // ! retruns the long (and sorted) array
            return z;
        }

        public static int[] MergeSort(int[] array)
        {

            if (array.Length > 2)
            {
                int[] temp = new int[2];
                for (int i = 0 ; i<2 ; i++)
                {
                    temp[i] = array[i];
                }
                return(MergeSort(temp));
            }
            else
            {
                if(array[0] > array[1])
                {
                    int temp = array[1];
                    array[1] = array[0];
                    array[0] = temp;
                    return array;
                }
                else
                {
                    return array;
                }
            }
        }

        public static int[] MergeSort(int[] array,int left,int right)
        {
            int[] temp = new int[array.Length];
            int newLeft = left;
            if(left+1 == right)
            {
                if (array[left]<array[right])
                {
                    temp[newLeft++] = array[left++];
                    temp[newLeft] = array[right];
                    return MergeSort(temp, left, right);
                }
                else if (array[left]>array[right])
                {
                    temp[newLeft++] = array[right--];
                    temp[newLeft] = array[left];
                    return MergeSort(temp, left, right);
                }
                else
                {
                    return temp;
                }
            }
            else
            {
                return MergeSort(array, left, right-1);
            }

        }
    }
}
