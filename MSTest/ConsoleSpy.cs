using System.Text;
using OHCEB3Nantes;

namespace MSTest
{
    internal class ConsoleSpy : IConsole
    {
        private readonly StringBuilder _content = new StringBuilder();

        public string ContentWritten => _content.ToString();

        /// <inheritdoc />
        public void WriteLine(string text)
        {
            _content.AppendLine(text);
        }

        /// <inheritdoc />
        public string ReadLine()
        {
            throw new NotImplementedException();
        }
    }
}
