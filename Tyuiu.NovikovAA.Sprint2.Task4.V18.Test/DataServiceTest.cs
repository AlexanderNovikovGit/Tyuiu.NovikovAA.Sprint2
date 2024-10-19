using Tyuiu.NovikovAA.Sprint2.Task4.V18.Lib;

namespace Tyuiu.NovikovAA.Sprint2.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.0, y = 2.0, aweited = 20.0, res;
            res = ds.Calculate(x, y);
            Assert.AreEqual(res, x);
        
        }
    }
}