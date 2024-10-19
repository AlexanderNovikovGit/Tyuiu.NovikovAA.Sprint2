using Tyuiu.NovikovAA.Sprint2.Task6.V3.Lib;


namespace Tyuiu.NovikovAA.Sprint2.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int day = 3;
            string awaited = "среда", res;
            DataService ds = new DataService();
            res = ds.FindDayName(day);
            Assert.AreEqual(awaited, res);
        }
    }
}