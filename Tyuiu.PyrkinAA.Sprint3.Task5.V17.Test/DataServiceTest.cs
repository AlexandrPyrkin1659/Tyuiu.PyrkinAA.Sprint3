using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PyrkinAA.Sprint3.Task5.V17.Lib;

namespace Tyuiu.PyrkinAA.Sprint3.Task5.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 12;
            double res = ds.GetSumSumSeries(x, startValue1, stopValue1, startValue2, stopValue2);
            double wait = 143.624;
            Assert.AreEqual(wait, res, 0.001);
        }
    }
}
