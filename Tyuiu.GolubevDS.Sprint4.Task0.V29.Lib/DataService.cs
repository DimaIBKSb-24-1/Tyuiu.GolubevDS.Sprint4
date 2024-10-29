namespace Tyuiu.GolubevDS.Sprint4.Task0.V29.Lib;

using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint4;

public class DataService : ISprint4Task0V29
{
    public int GetSumOddArrEl(int[] array)
    {
        int sum = array.Where(x => x % 2 != 0).Sum();

        
        return sum;
    }
}
