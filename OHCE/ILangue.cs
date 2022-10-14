namespace OHCE
{
    public interface ILangue
    {
        string BienDit { get; }
        string DireBonjour(PériodeJournée période);
        string AuRevoir { get; }
    }
}
