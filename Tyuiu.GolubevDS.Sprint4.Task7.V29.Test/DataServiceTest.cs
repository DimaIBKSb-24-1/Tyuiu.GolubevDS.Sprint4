namespace Tyuiu.GolubevDS.Sprint4.Task7.V29.Test;
using Tyuiu.GolubevDS.Sprint4.Task7.V29.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidCalculate()
    {
        DataService ds = new DataService();
        int rows = 4;
        int columns = 3;
        int[,] mtrx = new int[rows, columns];
        string str = "983157642891";
        int res = ds.Calculate(rows, columns, str);
        int wait = 28;
        Assert.AreEqual(res, wait);
    }
}