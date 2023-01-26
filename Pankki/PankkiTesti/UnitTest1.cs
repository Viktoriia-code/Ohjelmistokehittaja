using Pankki;

namespace PankkiTesti
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double alkusaldo = 11.99;
            double ottoSumma = 4.55;
            double oletettu = 7.44;

            Pankki.Pankkitili pt = new Pankki.Pankkitili("Jaakko Tarvainen", alkusaldo);
            pt.Otto(ottoSumma);
            Assert.AreEqual(oletettu, pt.Saldo, 0.001, "Jotain mätää Tanskanmaalla");
        }
    }
}