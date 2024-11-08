namespace Tyuiu.GolubevDS.Sprint4.Task2.V13.Lib;
using tyuiu.cources.programming.interfaces.Sprint4;

public class DataService : ISprint4Task2V13
{
    public int Calculate(int[] array)
    {
        int sumArray = 1;
        for (int i = 0; i <= array.Length - 1; i++)
        {
            if ((array[i] % 2 == 0) && (array[i] >= 2) && (array[i] <= 9))
            {
                sumArray *= array[i];
            }
        }
        return sumArray;
    }
}
