using OHCEB3Nantes;

namespace MSTest
{
    [TestClass]
    public class PalindromesTest
    {
        [TestMethod("QUAND on saisit une chaîne de caractères " +
                                  "ALORS elle est renvoyée en miroir")]
        public void MiroirTest()
        {
            var console = new ConsoleMock();
            var ohce = new Ohce(console);
            Task.Run(() => ohce.Start(CancellationToken.None));

            // QUAND on saisit une chaîne de caractères dans la console
            console.SimulerEcriture("toto");

            Thread.Sleep(10);

            // ALORS elle est renvoyée en miroir
            Assert.IsTrue(console.Contenu.Contains("otot"));
        }

        [TestMethod("QUAND on saisit une chaîne qui est un palindrome " +
                                  "ALORS elle est renvoyée en miroir " +
                                  "ET \"Bien dit !\" est écrit")]
        public void PalindromeTest()
        {
            var ohce = new Ohce(new ConsoleStub());

            // QUAND on saisit une chaîne de caractères dans la console
            const string chaîneTestée = "kayak";
            var sortie = ohce.SaisirChaîne(chaîneTestée);

            // ALORS elle est renvoyée en miroir
            Assert.IsTrue(sortie.StartsWith(chaîneTestée));

            // ET "Bien dit !" est écrit
            Assert.IsTrue(sortie.EndsWith(Environment.NewLine + "Bien dit !"));
        }

        [TestMethod("QUAND le programme démarre ALORS \"Bonjour\" est écrit dans la console")]
        public void BonjourTest()
        {
            // QUAND le programme démarre
            var spy = new ConsoleSpy();
            var ohce = new Ohce(spy);

            // ALORS \"Bonjour\" est écrit dans la console
            Assert.IsTrue(spy.ContentWritten.Contains("Bonjour"));
        }
    }
}