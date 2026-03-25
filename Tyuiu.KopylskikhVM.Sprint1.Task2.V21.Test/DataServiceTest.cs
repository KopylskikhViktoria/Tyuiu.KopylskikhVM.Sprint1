using Tyuiu.KopylskikhVM.Sprint1.Task2.V21.Lib;

namespace Tyuiu.KopylskikhVM.Sprint1.Task2.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int value = 2;
            int valueTwo = 3;

            var res = ds.CalculateRectangleSquare(value, valueTwo);
            Assert.AreEqual(6, res);
        }
    }
}
