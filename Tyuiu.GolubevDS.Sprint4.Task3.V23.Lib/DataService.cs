﻿namespace Tyuiu.GolubevDS.Sprint4.Task3.V23.Lib;

using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint4;

public class DataService : ISprint4Task3V23
{
    public int Calculate(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        int count = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (array[i, j] % 2 == 0)
                {
                    count++;
                }
            }
        }
        return count;
    }

}
