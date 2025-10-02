﻿using Tyuiu.LyapinSE.Sprint1.Task1.V21.Lib;

namespace Tyuiu.LyapinSE.Sprint1.Task1.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.25, res);
        }
    }
}
