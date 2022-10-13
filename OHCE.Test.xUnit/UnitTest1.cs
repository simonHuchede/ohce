namespace OHCE.Test.xUnit;

public class UnitTest1
{
    [Fact(DisplayName = 
        "QUAND on entre une chaîne de caractères " +
        "ALORS elle est renvoyée en miroir")]
    public void MiroirTest()
    {
        var ohce = new Ohce();

        // QUAND on entre une chaîne de caractère
        var sortie = Ohce.Palindrome("toto");

        // ALORS elle est renvoyée en miroir
        Assert.Equal("otot", sortie);
    }

    //[Fact(DisplayName = "QUAND on entre un palindrome " +
    //                    "ALORS il est renvoyé " +
    //                    "ET \"Bien dit\" est envoyé")]
    //public void PalindromeTest()
    //{
    //    // QUAND on entre un palindrome

    //    // ALORS il est renvoyé

    //    // ET "Bien dit" est envoyé
    //}
}