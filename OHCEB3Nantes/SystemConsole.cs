namespace OHCEB3Nantes
{
    internal class SystemConsole : IConsole
    {
        /// <inheritdoc />
        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }

        /// <inheritdoc />
        public string ReadLine()
        {
            return Console.ReadLine() ?? "";
        }
    }
}
