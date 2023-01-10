namespace OHCE.Langues
{
    public class LangueFrançaise : ILangue
    {
        /// <inheritdoc />
        public string BienDit => Expressions.Français.BienDit;

        /// <inheritdoc />
        public string DireBonjour(PériodeJournée période)
        {
            switch(période)
            {
                case PériodeJournée.Defaut:
                    return Expressions.Français.Bonjour;

                case PériodeJournée.Matin:
                    return Expressions.Français.Bonjour;

                case PériodeJournée.AprèsMidi:
                    return Expressions.Français.BonAprèsMidi;

                case PériodeJournée.Soir:
                    return Expressions.Français.Bonsoir;

                case PériodeJournée.Nuit:
                    return Expressions.Français.BonneNuit;

                default :  return Expressions.Français.Bonjour;
            } 
        }

        /// <inheritdoc />
        public string AuRevoir => Expressions.Français.AuRevoir;
    }
}
