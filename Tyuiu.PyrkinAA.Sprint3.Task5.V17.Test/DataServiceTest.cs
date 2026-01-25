using Tyuiu.PyrkinAA.Sprint3.Task5.V17.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.PyrkinAA.Sprint3.Task5.V17.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            int x = 2;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 12;

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

           

            double wait = 2.998;

            Assert.AreEqual(wait, res);
        }
    }
}