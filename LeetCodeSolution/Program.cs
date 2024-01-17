int[][] SetZeroes(int[][] matrix)
{
    int col0 = 1;
    for (int i = 0; i < matrix.Length; i++)
    {
        for (int j = 0; j <= matrix.Length; j++)
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
    for (int i = 1; i < matrix.Length; i++)
    {
        for(int j=1; j< matrix.Length; j++)
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
        for(int j = 0; j<matrix.Length; j++)
        {
            matrix[0][j] = 0;
        }
    }
    if(col0 == 0)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            matrix[i][0] = 0;
        }
    }


    return matrix;


}

void print(int[][] matrix)
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


int[][] matrix = new int[3][];
matrix[0] = new int[] { 0, 1, 2, 0 };
matrix[1] = new int[] { 3, 0, 5, 2 };
matrix[2] = new int[] { 1, 3, 1, 5 };

print(matrix);
Console.WriteLine();
var newMatrix = SetZeroes(matrix);
print(newMatrix);

