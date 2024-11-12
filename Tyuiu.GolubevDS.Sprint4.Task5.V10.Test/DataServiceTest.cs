namespace Tyuiu.GolubevDS.Sprint4.Task5.V10.Test;
using Tyuiu.GolubevDS.Sprint4.Task5.V10.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidCalculate()
    {
        DataService ds = new DataService();
        int[,] mas2 = new int[5, 5] { { 1, -2, 3,-1,0 },
                                      { 4,5,-4,2,7 },
                                      { -3,1,6,0,-4 },
                                      { -1,2,3 ,4,5 },
                                      { 0,-4,3,1,6  } };
        int res = ds.Calculate(mas2);
        int wair = 53;
        Assert.AreEqual(res, wair);
    }
}