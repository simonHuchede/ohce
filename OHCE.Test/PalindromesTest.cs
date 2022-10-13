using System.Text;
using OHCEB3Nantes;

namespace OHCE.Test
{
    public class PalindromesTest
    {
        [Fact(DisplayName = "QUAND on saisit une chaîne de caractères " +
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
            Assert.Contains("otot", console.Contenu);
        }

        [Fact(DisplayName = "QUAND on saisit une chaîne qui est un palindrome " +
                            "ALORS elle est renvoyée en miroir " +
                            "ET \"Bien dit !\" est écrit")]
        public void PalindromeTest()
        {
            var ohce = new Ohce(new ConsoleStub());

            // QUAND on saisit une chaîne de caractères dans la console
            const string chaîneTestée = "kayak";
            var sortie = ohce.SaisirChaîne(chaîneTestée);

            // ALORS elle est renvoyée en miroir
            Assert.StartsWith(chaîneTestée, sortie);

            // ET "Bien dit !" est écrit
            Assert.EndsWith(Environment.NewLine + "Bien dit !", sortie);
        }

        [Fact(DisplayName = "QUAND le programme démarre ALORS \"Bonjour\" est écrit dans la console")]
        public void BonjourTest()
        {
            // QUAND le programme démarre
            var spy = new ConsoleSpy();
            var ohce = new Ohce(spy);

            // ALORS \"Bonjour\" est écrit dans la console
            Assert.Contains("Bonjour", spy.ContentWritten);
        }
    }
}