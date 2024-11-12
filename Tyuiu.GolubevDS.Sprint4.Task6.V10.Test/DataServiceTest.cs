namespace Tyuiu.GolubevDS.Sprint4.Task6.V10.Test;
using Tyuiu.GolubevDS.Sprint4.Task6.V10.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidCalculate()
    {
        DataService ds = new DataService();
        var words = new string[] { "�����", "����", "�����", "����", "�������", "�������", "��������" };
        string[] res = ds.Calculate(words);
        string[] wait = { "�����", "����", "�����", "����", };
        CollectionAssert.AreEqual(wait, res);
    }
}