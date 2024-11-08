namespace Tyuiu.GolubevDS.Sprint4.Task2.V13.Test;
using Tyuiu.GolubevDS.Sprint4.Task2.V13.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidCalculate()
    {
        DataService ds = new DataService();
        int[] array = { 2, 5, 8, 3, 6, 7, 2, 4, 9, 1, 2, 3, 6 };
        int res = ds.Calculate(array);
        int wait = 9216;
        Assert.AreEqual(res, wait);
    }
}