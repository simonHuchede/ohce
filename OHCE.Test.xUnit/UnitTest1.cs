using OHCE.Test.xUnit.Utilities.TestDoubles;

namespace OHCE.Test.xUnit;

public class UnitTest1
{
    [Fact(DisplayName = 
        "QUAND on entre une chaîne de caractères " +
        "ALORS elle est renvoyée en miroir")]
    public void MiroirTest()
    {
        var ohce = new Ohce(new LangueStub());

        // QUAND on entre une chaîne de caractère
        var sortie = ohce.Palindrome("toto");

        // ALORS elle est renvoyée en miroir
        Assert.Contains("otot", sortie);
    }

    [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue" +
                          "QUAND on entre un palindrome " +
                          "ALORS il est renvoyé " +
                          "ET le <bienDit> de cette langue est envoyé")]
    [InlineData(Expressions.BienDit)]
    [InlineData("Well said")]
    public void PalindromeTest(string bienDit)
    {
        // ETANT DONNE un utilisateur parlant <langue>
        var ohce = new Ohce(new LangueMock(bienDit));

        // QUAND on entre un palindrome
        const string palindrome = "kayak";
        var sortie = ohce.Palindrome(palindrome);

        // ALORS il est renvoyé
        // ET <bienDit> en <langue> est envoyé
        Assert.Contains(
            palindrome + bienDit, 
            sortie);
    }

    [Theory(DisplayName = "ETANT DONNE un utilisateur parlant <langue>" +
                          "QUAND l'app démarre " +
                          "ALORS <bonjour> en <langue> est envoyé ")]
    [InlineData("fr_FR", "Bonjour")]
    [InlineData("en_GB", "Hello")]
    public void DémarrageTest(string langue, string bonjour)
    {
        var ohce = new Ohce(new LangueStub());

        // QUAND l'app démarre
        var sortie = ohce.Palindrome(string.Empty);

        // ALORS "Bonjour" est envoyé
        Assert.StartsWith(Expressions.Bonjour, sortie);
    }

    [Theory(DisplayName = "ETANT DONNE un utilisateur parlant <langue>" +
                          "QUAND l'app se ferme " +
                          "ALORS <auRevoir> en <langue> est envoyé ")]
    [InlineData("fr_FR", "Au revoir !")]
    [InlineData("en_GB", "Goodbye !")]
    public void FermetureTest(string langue, string auRevoir)
    {
        var ohce = new Ohce(new LangueStub());

        // QUAND l'app démarre
        var sortie = ohce.Palindrome(string.Empty);

        // ALORS "Au revoir" est envoyé
        Assert.EndsWith(Expressions.AuRevoir, sortie);
    }
}