using Tyuiu.PyrkinAA.Sprint3.Task4.V1.Lib;
namespace Tyuiu.PyrkinAA.Sprint3.Task4.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethodIC()
        {
          DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = 0.962;
            Assert.AreEqual(res, wait);

        }
    }
}
