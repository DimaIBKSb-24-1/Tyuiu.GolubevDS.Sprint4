namespace Tyuiu.GolubevDS.Sprint4.Task5.V10.Lib;
using tyuiu.cources.programming.interfaces.Sprint4;

public class DataService : ISprint4Task5V10
{
    public int Calculate(int[,] matrix)
    {
        int positiveSum = 0;
  
        if (matrix.GetLength(0) != 5 || matrix.GetLength(1) != 5)
        {
            throw new ArgumentException("Матрица должна быть размером 5 на 5.");
        }

        
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (matrix[i, j] > 0)
                {
                    positiveSum += matrix[i, j];   
                }
            }
        }

        return positiveSum;
    }
}
