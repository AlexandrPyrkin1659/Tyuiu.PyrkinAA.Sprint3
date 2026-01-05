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
            double res = ds.Calculate(-5, 5);
            double wait = 2.924; 
            Assert.AreEqual(wait, res, 0.001); 
        }
    }
}
