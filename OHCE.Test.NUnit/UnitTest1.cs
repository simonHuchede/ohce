namespace OHCE.Test.NUnit
{
    public class Tests
    {
        [TestCase(TestName = 
            "QUAND on entre une chaîne de caractères " +
            "ALORS elle est renvoyée en miroir")]
        public void MiroirTest()
        {
            var ohce = new Ohce();

            // QUAND on entre une chaîne de caractère
            var sortie = ohce.TraiterChaîne("toto");

            // ALORS elle est renvoyée en miroir
            Assert.That(sortie, Is.EqualTo("otot"));
        }
    }
}