using System;
using System.Collections.Generic;

public static class SaddlePoints
{
    public static IEnumerable<(int, int)> Calculate(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int r = 0; r < rows; r++)
        {
            int rowMax = int.MinValue;
            for (int c = 0; c < cols; c++)
            {
                if (matrix[r, c] > rowMax)
                    rowMax = matrix[r, c];
            }

            for (int c = 0; c < cols; c++)
            {
                if (matrix[r, c] != rowMax) 
                    continue;

                bool isColMin = true;
                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i, c] < matrix[r, c])
                    {
                        isColMin = false;
                        break;
                    }
                }

                if (isColMin)
                    yield return (r + 1, c + 1);
            }
        }
    }
}
