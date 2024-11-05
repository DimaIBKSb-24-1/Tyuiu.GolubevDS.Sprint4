namespace Tyuiu.GolubevDS.Sprint4.Task1.V12.Test;
using Tyuiu.GolubevDS.Sprint4.Task1.V12.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidCalculate()
    {
        DataService ds = new DataService();
        int[] numsArray = { 4, 8, 6, 4, 9, 5, 8, 7, 8, 4, 7, 6, 8 };

        int res = ds.Calculate(numsArray);
        int wait = 2205;
        Assert.AreEqual(res, wait);
    }
}