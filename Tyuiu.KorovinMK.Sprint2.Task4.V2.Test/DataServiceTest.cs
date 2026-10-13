using Tyuiu.KorovinMK.Sprint2.Task4.V2.Lib;
namespace Tyuiu.KorovinMK.Sprint2.Task4.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 7;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 11;
            Assert.AreEqual(wait, res);

        }
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 3;
            double res = ds.Calculate(x, y);
            double wait = 1.6;
            Assert.AreEqual(wait, res);

        }
    }
}
