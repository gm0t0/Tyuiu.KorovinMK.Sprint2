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
            int n = 8;
            string wait = "09.02.2024";
            var res = ds.FindDateOfNextDay(n, m, g);
            Assert.AreEqual(wait, res);

        }
    }
}
