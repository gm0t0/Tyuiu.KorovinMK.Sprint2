using Tyuiu.KorovinMK.Sprint2.Task3.V24.Lib;
namespace Tyuiu.KorovinMK.Sprint2.Task3.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 10.988;
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0;
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -27;
            double res = ds.Calculate(x);
            double wait = 0.964;
            Assert.AreEqual(wait, res);
            
        }
        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -30;
            double res = ds.Calculate(x);
            double wait = 600.033;
            Assert.AreEqual(wait, res);

        }
    }
}
