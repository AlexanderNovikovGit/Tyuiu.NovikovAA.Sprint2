using Tyuiu.NovikovAA.Sprint2.Task5.V6.Lib;

namespace Tyuiu.NovikovAA.Sprint2.Task5.V6.Test
{
    [TestClass]
    public class DataSeerviceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 1, y = 14;
            string awaited = "туз пик", res;
            DataService ds = new DataService();
            res = ds.FindCardNameAndValue(x, y);
            Assert.AreEqual(res, awaited);

        }
    }
}