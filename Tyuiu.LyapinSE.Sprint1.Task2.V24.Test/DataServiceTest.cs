using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.LyapinSE.Sprint1.Task2.V24.Lib;   

namespace Tyuiu.LyapinSE.Sprint1.Task2.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int value1 = 7;
            int value2 = 10;

            int res = ds.CalculateDiffSquare(value1, value2);

            Assert.AreEqual(9, res);
        }
    }
}
