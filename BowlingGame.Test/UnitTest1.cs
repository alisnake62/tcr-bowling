using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGame.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test2Quilles()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 2 quilles
            partie.Lancer(2);

            // ALORS le score est de 0
            Assert.AreEqual(0, partie.Score);
        }


        [TestMethod]
        public void Test2Lancers1Quille()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 1 quilles deux fois
            partie.Lancer(1);
            partie.Lancer(1);

            // ALORS le score est de 2
            Assert.AreEqual(2, partie.Score);
        }

        [TestMethod]
        public void Test1Quille()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber une quille
            partie.Lancer(1);

            // ALORS le score est de 0
            Assert.AreEqual(0, partie.Score);
        }

        [TestMethod]
        public void TestLancerRaté()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 0 quilles
            partie.Lancer(0);

            // ALORS le score est de 0
            Assert.AreEqual(0, partie.Score);
        }

        [TestMethod]
        public void TestStrike()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 10 quilles
            partie.Lancer(10);

            // ALORS le score est de 0
            Assert.AreEqual(0, partie.Score);
        }

        [TestMethod]
        public void TestSpare()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 10 quilles en 2 fois
            partie.Lancer(9);
            partie.Lancer(1);

            // ALORS le score est de 0
            Assert.AreEqual(0, partie.Score);
        }

        [TestMethod]
        public void Test1QuilleEn1LanceApresSpare()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 1 quille après un spare
            partie.Lancer(9);
            partie.Lancer(1);
            partie.Lancer(1);

            // ALORS le score est de 12
            Assert.AreEqual(12, partie.Score);
        }

        // [TestMethod]
        // public void Test1QuilleEn1LanceApresSrike()
        // {
        //     // ETANT DONNE une partie
        //     var partie = new Partie();

        //     // QUAND on fait tomber 1 quille après un strike
        //     partie.Lancer(10);
        //     partie.Lancer(1);

        //     // ALORS le score est de 0
        //     Assert.AreEqual(1, partie.Score);
        // }

        [TestMethod]
        public void Test5QuilleEn2LanceApresSrike()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 1 quille après un strike
            partie.Lancer(10);
            partie.Lancer(1);
            partie.Lancer(4);

            // ALORS le score est de 0
            Assert.AreEqual(20, partie.Score);
        }

        [TestMethod]
        public void TestQuilleEn4LanceApresSrike()
        {
            // ETANT DONNE une partie
            var partie = new Partie();

            // QUAND on fait tomber 1 quille après un strike
            partie.Lancer(10);
            partie.Lancer(1);
            partie.Lancer(4);
            partie.Lancer(6);

            // ALORS le score est de 0
            Assert.AreEqual(26, partie.Score);
        }
    }
}