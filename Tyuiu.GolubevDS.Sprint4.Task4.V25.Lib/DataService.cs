﻿namespace Tyuiu.GolubevDS.Sprint4.Task4.V25.Lib;
using tyuiu.cources.programming.interfaces.Sprint4;

public class DataService : ISprint4Task4V25
{
    public int Calculate(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        int sum = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (matrix[i, j] % 2 == 0)
                {
                    sum+= matrix[i, j];
                }
            }
        }
        return sum;
    }
}
