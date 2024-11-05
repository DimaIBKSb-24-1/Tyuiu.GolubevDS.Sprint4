namespace Tyuiu.GolubevDS.Sprint4.Task1.V12.Lib;
using tyuiu.cources.programming.interfaces.Sprint4;

public class DataService : ISprint4Task1V12
{
    public int Calculate(int[] array)
    {
        int sumArray = 1;
        for (int i = 0; i <= array.Length - 1; i++)
        {
            if ((array[i] % 2 != 0) && (array[i] >= 4) && (array[i] <= 9))
                {
                    sumArray *= array[i];
                }
        }
        return sumArray;
    }
}
