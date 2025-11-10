using System;

public static class GameOfLife
{
    public static int[,] Tick(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] next = new int[rows, cols];

        int[] dx = { -1, -1, -1, 0, 0, 1, 1, 1 };
        int[] dy = { -1, 0, 1, -1, 1, -1, 0, 1 };

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int liveNeighbors = 0;
                for (int k = 0; k < 8; k++)
                {
                    int ni = i + dx[k];
                    int nj = j + dy[k];
                    if (ni >= 0 && ni < rows && nj >= 0 && nj < cols)
                        liveNeighbors += matrix[ni, nj];
                }

                if (matrix[i, j] == 1)
                    next[i, j] = (liveNeighbors == 2 || liveNeighbors == 3) ? 1 : 0;
                else
                    next[i, j] = (liveNeighbors == 3) ? 1 : 0;
            }
        }

        return next;
    }
}
