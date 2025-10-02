using Tyuiu.LyapinSE.Sprint1.Task4.V13.Lib;

namespace Tyuiu.LyapinSE.Sprint1.Task4.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double result = ds.Calculate(1, 1);
            Assert.AreEqual(-0.045, result);
        }
    }
}
