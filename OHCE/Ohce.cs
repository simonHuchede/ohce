namespace OHCE
{
    public class Ohce
    {
        public static string Palindrome(string input)
        {
            return new string(input.Reverse().ToArray());
        }
    }
}
