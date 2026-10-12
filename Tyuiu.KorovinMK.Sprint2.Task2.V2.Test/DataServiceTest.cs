using Tyuiu.KorovinMK.Sprint2.Task2.V2.Lib;
namespace Tyuiu.KorovinMK.Sprint2.Task2.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 3;
            int y = 3;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
