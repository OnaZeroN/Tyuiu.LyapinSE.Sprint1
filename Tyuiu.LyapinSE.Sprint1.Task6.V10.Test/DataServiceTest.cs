using Tyuiu.LyapinSE.Sprint1.Task6.V10.Lib;

namespace Tyuiu.LyapinSE.Sprint1.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestDeleteMiddleLetter()
        {
            DataService ds = new DataService();
            string input = "Привет мир это тестовое задание";

            string result = ds.DeleteMiddleLetter(input);

            string expected = "Привет мр эо тестовое задние";
            Assert.AreEqual(expected, result);
        }
    }
}
