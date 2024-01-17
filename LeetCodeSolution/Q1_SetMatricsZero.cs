using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolution
{
    public static class Q1_SetMatricsZero
    {
        #region Inplace
        // inPlace Logic with O(1) Space complexity
        private static int[][] SetZeroes(int[][] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix[0].Length;

            // Variables to track whether the first row and first column should be zeroed
            bool firstRowZero = false;
            bool firstColZero = false;

            // Check if the first row should be zeroed
            for (int j = 0; j < cols; ++j)
            {
                if (matrix[0][j] == 0)
                {
                    firstRowZero = true;
                    break;
                }
            }

            // Check if the first column should be zeroed
            for (int i = 0; i < rows; ++i)
            {
                if (matrix[i][0] == 0)
                {
                    firstColZero = true;
                    break;
                }
            }

            // Use the first row and first column to mark the zeros
            for (int i = 1; i < rows; ++i)
            {
                for (int j = 1; j < cols; ++j)
                {
                    if (matrix[i][j] == 0)
                    {
                        matrix[i][0] = 0;
                        matrix[0][j] = 0;
                    }
                }
            }

            // Set zeros based on markings
            for (int i = 1; i < rows; ++i)
            {
                for (int j = 1; j < cols; ++j)
                {
                    if (matrix[i][0] == 0 || matrix[0][j] == 0)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }

            // Zero the first row if needed
            if (firstRowZero)
            {
                for (int j = 0; j < cols; ++j)
                {
                    matrix[0][j] = 0;
                }
            }

            // Zero the first column if needed
            if (firstColZero)
            {
                for (int i = 0; i < rows; ++i)
                {
                    matrix[i][0] = 0;
                }
            }
            return matrix;
        }

        #endregion


        // using hashset in 
        #region hasset
        private static int[][] SetZerosUsingHashSet(int[][] matrix)
        {
            var n = matrix.Length;
            var m = matrix[0].Length;
            var row = new HashSet<int>();
            var col = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        row.Add(i);
                        col.Add(j);
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (row.Contains(i) || col.Contains(j))
                    {
                        matrix[i][j] = 0;
                    }
                }

            }
            return matrix;

        }



        #endregion
        private static void print(int[][] matrix)
        {
            var n = matrix.Length;
            var m = matrix[0].Length;
            for (int row = 0; row < n; row++)
            {
                Console.Write("[");

                for (int col = 0; col < m; col++)
                {
                    Console.Write(matrix[row][col]);

                    if (col < matrix[row].Length - 1)
                    {
                        Console.Write(", ");
                    }
                }

                Console.WriteLine("],");
            }

        }

        public static void Run()
        {
            int[][] matrix = new int[1][];
            matrix[0] = new int[] { 1, 0, 3 };
            //matrix[1] = new int[] { 3, 0, 5, 2 };
            //matrix[2] = new int[] { 1, 3, 1, 5 };
            print(matrix);
            Console.WriteLine();
            var newMatrix = SetZeroes(matrix);
            print(newMatrix);
        }
       






    }
}
