namespace Tyuiu.GolubevDS.Sprint4.Task0.V29.Test;
using Tyuiu.GolubevDS.Sprint4.Task0.V29.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidGetSumOddArrEl()
    {
        DataService ds = new DataService();
        int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int res = ds.GetSumOddArrEl(array);  
        int expectedSum = 25;
        Assert.AreEqual(expectedSum, res);
    }


}


