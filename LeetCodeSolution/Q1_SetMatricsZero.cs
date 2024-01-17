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
            var n = matrix.Length;
            var m = matrix[0].Length;
            // I am consider the initial row and column as index row col for marking as zero
            int col0 = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        // mark i th rows
                        matrix[i][0] = 0;
                        // mark j th col
                        if (j != 0)
                        {
                            matrix[0][j] = 0;
                        }
                        else
                        {
                            col0 = 0;
                        }
                    }
                }
            }
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < m; j++)
                {
                    if (matrix[i][j] != 0)
                    {
                        if (matrix[0][j] == 0 || matrix[i][0] == 0)
                        {
                            matrix[i][j] = 0;
                        }
                    }
                }
            }
            if (matrix[0][0] == 0)
            {
                //row zero
                for (int j = 0; j < n; j++)
                {
                    matrix[j][0] = 0;
                }
            }
            if (col0 == 0)
            {
                for (int i = 0; i < m; i++)
                {
                    matrix[0][i] = 0;
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
            for (int row = 0; row < matrix.Length; row++)
            {
                Console.Write("[");

                for (int col = 0; col < matrix[row].Length; col++)
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
            int[][] matrix = new int[3][];
            matrix[0] = new int[] { 0, 1, 1, 0 };
            matrix[1] = new int[] { 3, 0, 5, 2 };
            matrix[2] = new int[] { 1, 3, 1, 5 };
            print(matrix);
            Console.WriteLine();
            var newMatrix = SetZerosUsingHashSet(matrix);
            print(newMatrix);
        }
       






    }
}
