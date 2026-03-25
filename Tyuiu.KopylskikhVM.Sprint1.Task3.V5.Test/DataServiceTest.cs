using Tyuiu.KopylskikhVM.Sprint1.Task3.V5.Lib;

namespace Tyuiu.KopylskikhVM.Sprint1.Task3.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateDistance()
        {
            DataService ds = new DataService();

            double scale = 120;
            double distanceOnMap = 3.5;

            double res = ds.DistanceLength(scale, distanceOnMap);

            Assert.AreEqual(420, res);
        }
    }
}
