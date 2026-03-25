using Tyuiu.KopylskikhVM.Sprint1.Task6.V12.Lib;

namespace Tyuiu.KopylskikhVM.Sprint1.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckLastWordRepetiton()
        {
            DataService ds = new DataService();

            string value = "мама мыла раму мама";

            bool res = ds.CheckLastWordRepetiton(value);

            Assert.AreEqual(true, res);
        }
    }
}
