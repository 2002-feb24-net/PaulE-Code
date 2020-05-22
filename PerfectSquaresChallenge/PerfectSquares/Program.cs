using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number.");
            long n = Convert.ToInt64(Console.ReadLine());
            var SquareList = FindPerfectSquares(n).Result;
            int? MyFinalAnswer = Calculate(SquareList,n);
            if(MyFinalAnswer == null)
            {
                Console.WriteLine("Assuming every perfect square root can only be used once, the target number can not be reached.");
                return;
            }
            Console.Write("Assuming you can only use each number once, your answer is: ");
            Console.WriteLine(MyFinalAnswer);
        }

        static async Task<List<long>> FindPerfectSquares(long input)
        {
            List<long> MyPerfectSquares = new List<long>();
            MyPerfectSquares.Add(1);
            var List1 = await FindHalf(2,Math.Floor((double)input/2),input);
            var List2 = await FindHalf(Math.Floor((double)input/2),Math.Ceiling(Math.Sqrt(input)),input);

            MyPerfectSquares.AddRange(List1);
            MyPerfectSquares.AddRange(List2);

            MyPerfectSquares.Reverse();
            return MyPerfectSquares;
        }

        private async static Task<List<long>> FindHalf(double x, double y, long input)
        {
            List<long> MyPerfectSquares = new List<long>();
            if(y-x > 50000)
            {
                var List1 = await FindHalf(x,Math.Floor((double)y/2),input);
                var List2 = await FindHalf(x+(Math.Floor((double)y/2)),y,input);
                MyPerfectSquares.AddRange(List1);
                MyPerfectSquares.AddRange(List2);
            }
            else
            {
                long counter = (long) x;
                while(counter <= y)
                {
                    if(counter * counter <= input)
                    {
                        MyPerfectSquares.Add(counter*counter);
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return MyPerfectSquares;
        }

        static int? Calculate(List<long> SquareList, long target)
        {
            int? ListNumberCount = null;
            if(SquareList[0]==target)
            {
                return 1;
            }
            for(int q = 0; q<SquareList.Count; q++)
            {
                int? MyAnswer = TryThis(SquareList,q,SquareList[q],1,target);
                if(ListNumberCount == null || ListNumberCount > MyAnswer)
                {
                    ListNumberCount = MyAnswer;
                }
            };
            return ListNumberCount;
        }

        static int? TryThis(List<long> SquareList, int index, long inputBaseNumber, int currentCount, long target)
        {
            long BaseNumber = inputBaseNumber;
            int count = currentCount;
            for(int z = index; z<SquareList.Count;z++)
            {
                if(inputBaseNumber<target/2)
                {
                    break;
                }
                if(inputBaseNumber+SquareList[z] == target)
                {
                    count = count+1;
                    return count;
                }
                else if(inputBaseNumber+SquareList[z] < target)
                {
                    while(BaseNumber+SquareList[z] < target)
                    {
                        BaseNumber = BaseNumber+SquareList[z];
                        count = count+1;
                    }
                    if(BaseNumber+SquareList[z] == target)
                    {
                        count = count+1;
                        return count;
                    }
                    return(TryThis(SquareList,z+1,BaseNumber,count,target));
                }
            }
            //unreachable
            return null;
        }
    }
}



// Given an integer n (3 < n < 109), find the length of the smallest list of perfect squares which add up to n. Come up with the best algorithm you can; you'll need it!
