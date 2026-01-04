using Tyuiu.PyrkinAA.Sprint3.Task0.V7.Lib;
namespace Tyuiu.PyrkinAA.Sprint3.Task0.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeriesForFullRange()
        {
            DataService ds = new DataService();

            double a = 0.75;
            int startValue = 1;
            int stopValue = 20;

            double result = ds.GetSumSeries(a, startValue, stopValue);
            double expected = 0;
            for (int k = 1; k <= 20; k++)
            {
                expected += (Math.Pow(a, k) + 1) * Math.Cos(k);
            }
            expected = Math.Round(expected, 3);

            Assert.AreEqual(expected, result, 0.001);
        }

        [TestMethod]
        public void ValidGetSumSeriesForSmallRange()
        {
            DataService ds = new DataService();

            double a = 0.75;
            int startValue = 1;
            int stopValue = 5;

            double result = ds.GetSumSeries(a, startValue, stopValue);

            double expected = 0;
            for (int k = 1; k <= 5; k++)
            {
                expected += (Math.Pow(a, k) + 1) * Math.Cos(k);
            }
            expected = Math.Round(expected, 3);

            Assert.AreEqual(expected, result, 0.001);
        }

        [TestMethod]
        public void ValidGetSumSeriesForSingleTerm()
        {
            DataService ds = new DataService();

            double a = 0.75;
            int startValue = 1;
            int stopValue = 1;

            double result = ds.GetSumSeries(a, startValue, stopValue);

            double expected = (Math.Pow(a, 1) + 1) * Math.Cos(1);
            expected = Math.Round(expected, 3);

            Assert.AreEqual(expected, result, 0.001);
        }
    }
}
