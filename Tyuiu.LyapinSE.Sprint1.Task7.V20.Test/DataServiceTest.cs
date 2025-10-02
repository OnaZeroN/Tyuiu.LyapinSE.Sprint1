using Tyuiu.LyapinSE.Sprint1.Task7.V20.Lib;

namespace Tyuiu.LyapinSE.Sprint1.Task7.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            double result = ds.Calculate(1, 1);
            Assert.AreEqual(2.449, result);
        }
    }
}
