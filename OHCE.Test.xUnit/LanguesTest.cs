using OHCE.Langues;

namespace OHCE.Test.xUnit
{
    public class LanguesTest
    {
        [Theory]
        [InlineData(PériodeJournée.Soir, Expressions.Français.Bonsoir)]
        [InlineData(PériodeJournée.Matin, Expressions.Français.Bonjour)]
        [InlineData(PériodeJournée.AprèsMidi, Expressions.Français.BonAprèsMidi)]
        [InlineData(PériodeJournée.Nuit, Expressions.Français.BonneNuit)]
        [InlineData(PériodeJournée.Defaut, Expressions.Français.Bonjour)]
        public void DireBonjourTest(PériodeJournée période, string salutationAttendue)
        {
            // ETANT DONNE la langue française
            // ET une période de la journée <période>
            var langue = new LangueFrançaise();

            // QUAND je dis bonjour
            var salutation = langue.DireBonjour(période);

            // ALORS on me répond <salutationAttendue>
            Assert.Equal(salutationAttendue, salutation);
        }

        [Theory]
        [InlineData(PériodeJournée.Soir, Expressions.English.GoodEvening)]
        [InlineData(PériodeJournée.Matin, Expressions.English.GoodMorning)]
        [InlineData(PériodeJournée.AprèsMidi, Expressions.English.GoodAfternoon)]
        [InlineData(PériodeJournée.Nuit, Expressions.English.GoodNight)]
        [InlineData(PériodeJournée.Defaut, Expressions.English.Hello)]
        public void SayHelloTest(PériodeJournée période, string salutationAttendue)
        {
            // ETANT DONNE la langue française
            // ET une période de la journée <période>
            var langue = new LangueAnglaise();

            // QUAND je dis bonjour
            var salutation = langue.DireBonjour(période);

            // ALORS on me répond <salutationAttendue>
            Assert.Equal(salutationAttendue, salutation);
        }
    }
}
