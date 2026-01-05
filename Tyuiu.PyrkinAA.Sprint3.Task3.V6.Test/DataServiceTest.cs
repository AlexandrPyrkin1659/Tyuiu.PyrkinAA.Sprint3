using Tyuiu.PyrkinAA.Sprint3.Task3.V6.Lib;
namespace Tyuiu.PyrkinAA.Sprint3.Task3.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
          
                DataService ds = new DataService(); 
                string value = "12able 1o s4gh";    
                char item = '*';                    
                string wait = "**able *o s*gh";   
                string res = ds.ReplaceNumOnChar(value, item); 
                Assert.AreEqual(wait, res);         
          
        }
    }
}
