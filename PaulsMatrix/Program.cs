using System;
using System.Collections.Generic;

namespace PaulsMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(Matrix 1) Please input your first two numbers, with a comma seperating them. eg: 1,2");
            int [] a = Question1();
            Console.WriteLine("(Matrix 1) Please input your second two numbers, with a comma seperating them. eg: 1,2");
            int [] b = Question1();

            Matrix Matrix1 = new Matrix(a,b);
            Matrix1.PrintMatrix();

            Console.WriteLine("(Matrix 2) Please input your first two numbers, with a comma seperating them. eg: 1,2");
            a = Question1();
            Console.WriteLine("(Matrix 2) Please input your second two numbers, with a comma seperating them. eg: 1,2");
            b = Question1();
            Matrix Matrix2 = new Matrix(a,b);
            Matrix2.PrintMatrix();

            Console.WriteLine("What would you like to do with these two matrixes?");
            Console.WriteLine("OPTIONS: ADD, SUBTRACT, MULTIPLY, REVERSE, NEGATE, TRANSPOSE");
            Question2(Matrix1,Matrix2);
        }

        public static int[] Question1()
        {
            string x = Console.ReadLine();
            string[] y = x.Split(",");
            int[] z = new int[y.Length];
            for (int i =0;i<y.Length;i++)
            {
                z[i] = int.Parse(y[i]);
            }

            return z;
        }

        public static void Question2(Matrix a, Matrix b)
        {
            Matrix Matrix1 = a;
            Matrix Matrix2 = b;
            char x = Convert.ToChar((Console.ReadLine()).Substring(0,1).ToUpper());
            switch (x)
            {
                case 'A':
                Matrix1.Add(Matrix2);
                break;

                case 'S':
                Matrix1.Subtract(Matrix2);
                break;

                case 'M':
                Matrix1.Multiply(Matrix2);
                break;

                case 'R':
                Matrix1.Reverse();
                Matrix2.Reverse();
                break;

                case 'N':
                Matrix1.Negation();
                Matrix2.Negation();
                break;

                case 'T':
                Matrix1.Transpose();
                Matrix2.Transpose();
                break;
            }
        }
    }
}
