using Tyuiu.KopylskikhVM.Sprint1.Task1.V30.Lib;

namespace Tyuiu.KopylskikhVM.Sprint1.Task1.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4.0;

            var res = ds.Calculate(x);
            Assert.AreEqual(3, res);
        }
    }
}
