using Tyuiu.LyapinSE.Sprint1.Task3.V13.Lib;

namespace Tyuiu.LyapinSE.Sprint1.Task3.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double number = 247;
            double expected = 56.000;

            double result = ds.MultiplyOfDigits(number);

            Assert.AreEqual(expected, result);
        }
    }
}