using Tyuiu.NovikovAA.Sprint2.Task2.V12.Lib;


namespace Tyuiu.NovikovAA.Sprint2.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            bool res = false;
            int x = 3, y = 3;
            res = ds.CheckDotInShadedArea(x, y);
            Assert.IsTrue(res);
        }
    }
}