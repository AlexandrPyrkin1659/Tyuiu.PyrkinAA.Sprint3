using Tyuiu.PyrkinAA.Sprint3.Task6.V7.Lib;
namespace Tyuiu.PyrkinAA.Sprint3.Task6.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 17;
            int stopValue = 26;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 344;
            Assert.AreEqual(wait, res);
        }
    }
}
