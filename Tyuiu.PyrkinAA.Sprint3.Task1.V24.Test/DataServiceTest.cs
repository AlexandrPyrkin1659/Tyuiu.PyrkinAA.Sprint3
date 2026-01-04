using Tyuiu.PyrkinAA.Sprint3.Task1.V24.Lib;
namespace Tyuiu.PyrkinAA.Sprint3.Task1.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int x = 5;
            int startValue = 1;
            int stopValue = 12;

            double result = ds.GetSumSeries(x, startValue, stopValue);

            double expected = 0;
            for (int i = 1; i <= 12; i++)
            {
                double term = Math.Pow(2.0 / (6 + Math.Pow(5, i)), i);
                expected += term;
            }
            expected = Math.Round(expected, 3);

            Assert.AreEqual(expected, result, 0.001);
        }

        [TestMethod]
        public void ValidGetSumSeriesPartialRange()
        {
            DataService ds = new DataService();

            int x = 5;
            int startValue = 1;
            int stopValue = 5;

            double result = ds.GetSumSeries(x, startValue, stopValue);

            double expected = 0;
            for (int i = 1; i <= 5; i++)
            {
                double term = Math.Pow(2.0 / (6 + Math.Pow(5, i)), i);
                expected += term;
            }
            expected = Math.Round(expected, 3);

            Assert.AreEqual(expected, result, 0.001);
        }

        [TestMethod]
        public void ValidGetSumSeriesSingleTerm()
        {
            DataService ds = new DataService();

            int x = 5;
            int startValue = 1;
            int stopValue = 1;

            double result = ds.GetSumSeries(x, startValue, stopValue);

            double term = Math.Pow(2.0 / (6 + Math.Pow(5, 1)), 1);
            double expected = Math.Round(term, 3);

            Assert.AreEqual(expected, result, 0.001);
        }
    }
}
