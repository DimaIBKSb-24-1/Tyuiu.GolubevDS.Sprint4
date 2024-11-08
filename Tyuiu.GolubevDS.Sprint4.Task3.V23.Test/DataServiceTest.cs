namespace Tyuiu.GolubevDS.Sprint4.Task3.V23.Test;
using Tyuiu.GolubevDS.Sprint4.Task3.V23.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidCalculate()
    {
        DataService ds = new DataService();
        int[,] mas2 = new int[5, 5] { { 7, 5, 5, 6, 7 },
                                       {8, 7, 8, 4, 3, }, 
                                       {5, 6, 7, 8, 3,}, 
                                       {4, 2, 3, 6, 4, }, 
                                       {5, 2, 4, 2, 3,} };
        int res = ds.Calculate(mas2);
        int wait = 13;
        Assert.AreEqual(res, wait);
    }
}