using Tyuiu.NovikovAA.Sprint2.Task0.V21.Lib;

namespace Tyuiu.NovikovAA.Sprint2.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 1705; int y = 775;
            DataService ds = new DataService();
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] Wait = new bool[6] {false, false, false, false, false, false};
            CollectionAssert.AreEqual(Wait, res);
        }
    }
}