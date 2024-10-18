using Tyuiu.NovikovAA.Sprint2.Task1.V23.Lib;

namespace Tyuiu.NovikovAA.Sprint2.Task1.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            bool[] res = new bool[6];
            int a = 242, b = 571, c = 325, d = 155;
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] waited = new bool[6] {false, false, false, true, true, true};
            CollectionAssert.AreEqual(waited, res);

        }
    }
}