using Tyuiu.NovikovAA.Sprint2.Task3.V25.Lib;


namespace Tyuiu.NovikovAA.Sprint2.Task3.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public async void TestMethod1()
        {
            double x = -1, res;
            DataService ds = new DataService();
            double awaited = 0;
            res = ds.Calculate(x);
            Assert.AreEqual(awaited, x);

        }
    }
}