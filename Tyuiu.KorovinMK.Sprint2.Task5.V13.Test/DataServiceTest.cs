using Tyuiu.KorovinMK.Sprint2.Task5.V13.Lib;
namespace Tyuiu.KorovinMK.Sprint2.Task5.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int g = 2024;
            int m = 2;
            int n = 28;
            string wait = "2024.2.29";
            var res = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual(wait, res);
        }
    }
}
