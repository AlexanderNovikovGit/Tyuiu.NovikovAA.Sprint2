using Tyuiu.NovikovAA.Sprint2.Task7.V15.Lib;


namespace Tyuiu.NovikovAA.Sprint2.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 0, y = 1.5;
            bool awaited = true, res;
            DataService ds = new DataService();
            res = ds.CheckDotInShadedArea(x, y);
            Assert.IsTrue(res);


        }
    }
}