using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = {
            {1, 2, 3, 4},
            {4, 2, 3, 1},
            {3, 1, 2, 4},
            {2, 4, 1, 3}
        };

        int row1, row2;
        FindMostSimilarRows(array, out row1, out row2);

        Console.WriteLine($"Najbardziej zbliżone wiersze: {row1} i {row2}");
    }

    static void FindMostSimilarRows(int[,] array, out int row1, out int row2)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        int minDifference = int.MaxValue;
        row1 = 0;
        row2 = 0;

        for (int i = 0; i < rows - 1; i++)
        {
            for (int j = i + 1; j < rows; j++)
            {
                int difference = CalculateRowDifference(array, i, j, columns);
                if (difference < minDifference)
                {
                    minDifference = difference;
                    row1 = i;
                    row2 = j;
                }
            }
        }
    }

    static int CalculateRowDifference(int[,] array, int row1, int row2, int columns)
    {
        int difference = 0;

        for (int k = 0; k < columns; k++)
        {
            int elementDifference = (array[row1, k] - array[row2, k]) * (array[row1, k] - array[row2, k]);
            difference += elementDifference;
        }

        return difference;
    }
}