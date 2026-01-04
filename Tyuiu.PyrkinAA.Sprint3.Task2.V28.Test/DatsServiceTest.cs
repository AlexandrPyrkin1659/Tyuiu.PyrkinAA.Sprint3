using Tyuiu.PyrkinAA.Sprint3.Task2.V28.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Tyuiu.PyrkinAA.Sprint3.Task2.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 9;

            double result = ds.GetMultiplySeries(startValue, stopValue);

            double expected = 1.0;
            double cosValue = Math.Cos(1.8);

            for (int k = 1; k <= 9; k++)
            {
                double term = (Math.Pow(2, k) / (k + 1)) * cosValue;
                expected *= term;
            }
            expected = Math.Round(expected, 3);

            Assert.AreEqual(expected, result, 0.001);
        }

        [TestMethod]
        public void ValidGetMultiplySeriesPartialRange()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 5;

            double result = ds.GetMultiplySeries(startValue, stopValue);

            double expected = 1.0;
            double cosValue = Math.Cos(1.8);

            for (int k = 1; k <= 5; k++)
            {
                double term = (Math.Pow(2, k) / (k + 1)) * cosValue;
                expected *= term;
            }
            expected = Math.Round(expected, 3);

            Assert.AreEqual(expected, result, 0.001);
        }

        [TestMethod]
        public void ValidGetMultiplySeriesSingleTerm()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 1;

            double result = ds.GetMultiplySeries(startValue, stopValue);

            double cosValue = Math.Cos(1.8);
            double term = (Math.Pow(2, 1) / (1 + 1)) * cosValue;
            double expected = Math.Round(term, 3);

            Assert.AreEqual(expected, result, 0.001);
        }
    }
}