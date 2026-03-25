using Tyuiu.KopylskikhVM.Sprint1.Task4.V30.Lib;

namespace Tyuiu.KopylskikhVM.Sprint1.Task4.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 2;

            double res = ds.Calculate(x, y);
            double wait = Math.Round((x + Math.Pow(y, 3)) / Math.Exp(2 - y), 3);

            Assert.AreEqual(wait, res);
        }
    }
}
