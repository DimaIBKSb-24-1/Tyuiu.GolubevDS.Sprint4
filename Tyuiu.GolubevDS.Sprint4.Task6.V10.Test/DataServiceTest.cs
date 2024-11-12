namespace Tyuiu.GolubevDS.Sprint4.Task6.V10.Test;
using Tyuiu.GolubevDS.Sprint4.Task6.V10.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidCalculate()
    {
        DataService ds = new DataService();
        var words = new string[] { "Театр", "Кино", "Музей", "Парк", "Зоопарк", "Концерт", "Выставка" };
        string[] res = ds.Calculate(words);
        string[] wait = { "Театр", "Кино", "Музей", "Парк", };
        CollectionAssert.AreEqual(wait, res);
    }
}