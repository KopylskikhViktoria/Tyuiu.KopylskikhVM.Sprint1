using Tyuiu.KopylskikhVM.Sprint1.Task5.V2.Lib;

namespace Tyuiu.KopylskikhVM.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFahrenheitToСelsius()
        {
            DataService ds = new DataService();

            double f = 68; // должно быть 20°C

            int res = ds.FahrenheitToСelsius(f);

            Assert.AreEqual(20, res);
        }
    }
}
