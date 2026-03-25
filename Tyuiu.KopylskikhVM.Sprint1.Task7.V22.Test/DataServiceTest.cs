using Tyuiu.KopylskikhVM.Sprint1.Task7.V22.Lib;

namespace Tyuiu.KopylskikhVM.Sprint1.Task7.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 0.5;
            double y = 1.0;

            double res = ds.Calculate(x, y);

            Assert.AreEqual(1.113, res);
        }
    }
}
