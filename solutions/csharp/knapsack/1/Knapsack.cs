using System;

public static class Knapsack
{
    public static int MaximumValue(int maximumWeight, (int weight, int value)[] items)
    {
        int n = items.Length;
        int[,] dp = new int[n + 1, maximumWeight + 1];

        for (int i = 1; i <= n; i++)
        {
            int w = items[i - 1].weight;
            int v = items[i - 1].value;
            for (int j = 0; j <= maximumWeight; j++)
            {
                if (w > j)
                    dp[i, j] = dp[i - 1, j];
                else
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i - 1, j - w] + v);
            }
        }

        return dp[n, maximumWeight];
    }
}
