using Microsoft.Extensions.DependencyModel;
using Tyuiu.KopylskikhVM.Sprint1.Task0.V0.Lib;

namespace Tyuiu.KopylskikhVM.Sprint1.Task0.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(5, res);
        }
       
    }
}
