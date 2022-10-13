using OHCEB3Nantes;

namespace MSTest
{
    internal class ConsoleStub : IConsole
    {
        /// <inheritdoc />
        public void WriteLine(string text)
        {
        }

        /// <inheritdoc />
        public string ReadLine() => string.Empty;
    }
}
