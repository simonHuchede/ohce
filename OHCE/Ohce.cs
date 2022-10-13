using System.Text;

namespace OHCE;

public class Ohce
{
    public static string Palindrome(string input)
    {
        var reversed = new string(
            input.Reverse().ToArray()
        );

        var stringBuilder = new StringBuilder(reversed);

        if (reversed.Equals(input))
            stringBuilder.Append(Expressions.BienDit);

        return stringBuilder.ToString();
    }
}