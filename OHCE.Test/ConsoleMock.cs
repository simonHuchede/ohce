using System.Text;
using OHCEB3Nantes;

namespace OHCE.Test
{
    internal class ConsoleMock : IConsole
    {
        private readonly Queue<string> _inputBuffer = new Queue<string>();
        private readonly StringBuilder _outputBuffer = new StringBuilder();

        /// <inheritdoc />
        public void WriteLine(string text)
        {
            _outputBuffer.AppendLine(text);
        }

        /// <inheritdoc />
        public string ReadLine()
        {
            return _inputBuffer.Dequeue();
        }

        public void SimulerEcriture(string input)
        {
            _inputBuffer.Enqueue(input);
        }

        public string Contenu => _outputBuffer.ToString();
    }
}
