using System.Text;


namespace OHCE;

public class Ohce
{
    private readonly ILangue _langue;
    private readonly PériodeJournée _périodeJournée;
   

    public Ohce(ILangue langue, PériodeJournée périodeJournée)
    {
        _langue = langue;
        _périodeJournée = périodeJournée;
    }

    public string Saluer()
    {
        var stringBuilder = new StringBuilder(_langue.DireBonjour(_périodeJournée));
        return stringBuilder.ToString();
    }

    public string Palindrome(string input)
    {
        var stringBuilder = new StringBuilder();
        var reversed = new string(
            input.Reverse().ToArray()
        );
        stringBuilder.Append(reversed + " \n");
        if (reversed.Equals(input))
            stringBuilder.Append(_langue.BienDit + " \n");

        stringBuilder.Append(_langue.AuRevoir);

        return stringBuilder.ToString();
    }
}