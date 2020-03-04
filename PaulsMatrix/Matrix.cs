using System;
using System.Collections.Generic;

namespace PaulsMatrix
{
    class Matrix
    {
        public int[,] MyMatrix;

        public Matrix(int[] a,int[] b)
        {
            MyMatrix = new int[2,2];
            for (int i = 0;i<a.Length;i++)
            {
                this.MyMatrix[0,i] = a[i];
                this.MyMatrix[1,i] = b[i];
            }

        }

        public int Get (int a, int b)
        {
            return this.MyMatrix[a,b];
        }

        public void Add(Matrix x)
        {
            int total1 = this.MyMatrix[0,0] + x.Get(0,0);
            int total2 = this.MyMatrix[0,1] + x.Get(0,1);
            int total3 = this.MyMatrix[1,0] + x.Get(1,0);
            int total4 = this.MyMatrix[1,1] + x.Get(1,1);
            Console.WriteLine("[{0} , {1}]", total1, total2);
            Console.WriteLine("[{0} , {1}]", total3, total4);
        }

        public void Subtract(Matrix x)
        {
            int total1 = this.MyMatrix[0,0] - x.Get(0,0);
            int total2 = this.MyMatrix[0,1] - x.Get(0,1);
            int total3 = this.MyMatrix[1,0] - x.Get(1,0);
            int total4 = this.MyMatrix[1,1] - x.Get(1,1);
            Console.WriteLine("[{0} , {1}]", total1, total2);
            Console.WriteLine("[{0} , {1}]", total3, total4);
        }

        public void Multiply(Matrix x)
        {
            int total1 = this.MyMatrix[0,0] * x.Get(0,0);
            int total2 = this.MyMatrix[0,1] * x.Get(0,1);
            int total3 = this.MyMatrix[1,0] * x.Get(1,0);
            int total4 = this.MyMatrix[1,1] * x.Get(1,1);
            Console.WriteLine("[{0} , {1}]", total1, total2);
            Console.WriteLine("[{0} , {1}]", total3, total4);
        }

        public void Reverse()
        {
            int total1 = this.MyMatrix[0,0]; 
            int total2 = this.MyMatrix[0,1]; 
            int total3 = this.MyMatrix[1,0];
            int total4 = this.MyMatrix[1,1];
            this.MyMatrix[0,0] = total4;
            this.MyMatrix[0,1] = total3;
            this.MyMatrix[1,0] = total2;
            this.MyMatrix[1,1] = total1;
            Console.WriteLine("[{0} , {1}]", MyMatrix[0,0], MyMatrix[0,1]);
            Console.WriteLine("[{0} , {1}]", MyMatrix[1,0], MyMatrix[1,1]);
        }

        public void Negation()
        {
            int total1 = this.MyMatrix[0,0]*-1; 
            int total2 = this.MyMatrix[0,1]*-1; 
            int total3 = this.MyMatrix[1,0]*-1;
            int total4 = this.MyMatrix[1,1]*-1;
            Console.WriteLine("[{0} , {1}]", total1, total2);
            Console.WriteLine("[{0} , {1}]", total3, total3);
        }

        public void Transpose()
        {
            int total1 = this.MyMatrix[0,0]; 
            int total2 = this.MyMatrix[0,1]; 
            int total3 = this.MyMatrix[1,0];
            int total4 = this.MyMatrix[1,1];
            this.MyMatrix[0,0] = total2;
            this.MyMatrix[0,1] = total1;
            this.MyMatrix[1,0] = total4;
            this.MyMatrix[1,1] = total3;
            Console.WriteLine("[{0} , {1}]", MyMatrix[0,0], MyMatrix[0,1]);
            Console.WriteLine("[{0} , {1}]", MyMatrix[1,0], MyMatrix[1,1]);
        }

        public void PrintMatrix()
        {
            for (int i = 0;i<2;i++)
            {
                for (int q=0;q<2;q++)
                {
                    Console.WriteLine("Array {0}: {1}",i, MyMatrix[i,q]);
                }
            }
        }
    }
}