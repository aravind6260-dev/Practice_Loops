using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Arrays
    {
        public Arrays()
        {
            int[] ints = new int[5];
            ints[0] = 31;
            ints[1] = 32;
            ints[2] = 33;
            ints[3] = 34;
            ints[4] = 35;

            //Console.WriteLine(ints);
            for (int i = 0; i < ints.Length; i++)
            {

                Console.WriteLine(ints[i]);
            }
            Console.WriteLine();

            int[] ints1 = new int[] { 1, 3, 2, 4 };

            Array.Sort(ints1);

            for (int i = 0; i < ints1.Length; i++)
            {
                Console.WriteLine(ints1[i]);
            }
            Console.WriteLine();

            int[] ints2 = new int[5] { 12, 15, 13, 14, 17 };
            //Array.Sort(ints2);
            //Console.WriteLine(ints2.Length);
            Array.Reverse(ints2);
            Console.WriteLine("Min Value : " + ints2.Min());
            Console.WriteLine("Max Value : " + ints2.Max());
            Console.WriteLine("Sum Value : " + ints2.Sum());
            for (int i = 0; i < ints2.Length; i++)
            {
                Console.WriteLine(ints2[i]);

            }
            //foreach (int i in ints)
            //{
            //    Console.WriteLine(i);
            //}
            Console.WriteLine();

            int[] ints3 = { 22, 25, 24, 29 };
            Array.Sort(ints3);
            for (int i = 0; i < ints3.Length; i++)
            {
                Console.WriteLine(ints3[i]);
            }
            Console.WriteLine();
            //Multi-Dimensional Array
            Console.WriteLine("Multi-Dimentional Array : ");
            int[,] multi = { { 12, 15, 23 }, { 31, 28, 29 } };
            //Console.WriteLine(multi[0, 2]);
            //int a = 0;
            //for (int i = 0; a < multi.GetLength(0); i++)
            //{
            //    for (int j = 0; j < multi.GetLength(1); j++)
            //    {
            //        a += 5;
            //        multi[i, j] = a;
            //    }
            //}
            for (int i = 0; i < multi.GetLength(0); i++)
            {
                for (int j = 0; j < multi.GetLength(1); j++)
                {
                    Console.WriteLine(multi[i, j]);
                }
                Console.WriteLine();
            }


            //Console.WriteLine("Enter the multiple matrics : ");
            //int rows = Convert.ToInt32(Console.ReadLine());
            //int columns = Convert.ToInt32(Console.ReadLine());

            //int[,] Matrix1 = new int[rows, columns];
            //int[,] Matrix2 = new int[rows, columns];
            //int[,] ResultMatrix = new int[rows, columns];
            //Console.WriteLine("Enter the Matrix1 values : ");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Enter the Matrix2 values : ");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("Enter the sum of both matris : ");
            //{
            //    for (int i = 0; i < rows; i++)
            //    {
            //        for (int j = 0; j < columns; j++)
            //        {
            //            ResultMatrix[i, j] = Matrix1[i, j] + Matrix2[i, j];
            //            Console.Write($"{ResultMatrix[i, j]} ");
            //        }
            //        Console.WriteLine();
            //    }
            //}
        }
    }
}