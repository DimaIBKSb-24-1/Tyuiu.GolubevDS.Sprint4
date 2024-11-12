namespace Tyuiu.GolubevDS.Sprint4.Task7.V29.Lib;
using tyuiu.cources.programming.interfaces.Sprint4;

public class DataService : ISprint4Task7V29
{
    public int Calculate(int n, int m, string value)
    {
        if (value.Length != n * m)
        {
            throw new ArgumentException("Длина строки не соответствует размеру матрицы");
        }

        // Создаем матрицу  
        int[,] matrix = new int[n, m];

        // Заполняем матрицу из строки  
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = value[i * m + j] - '0'; // Преобразуем символ в цифру  
            }
        }

        // Подсчитываем сумму четных чисел  
        int evenSum = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] % 2 == 0) // Проверяем, четное ли число  
                {
                    evenSum += matrix[i, j];
                }
            }
        }

        return evenSum;
    }
}
