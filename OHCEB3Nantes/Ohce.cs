using System.Text;

namespace OHCEB3Nantes
{
    public class Ohce
    {
        private readonly IConsole _console;

        public Ohce(IConsole console)
        {
            _console = console;
            console.WriteLine("Bonjour");
        }

        public string SaisirChaîne(string input)
        {
            var result = new string(input.Reverse().ToArray());

            var builder = new StringBuilder(result);
            if (result.Equals(input))
            {
                builder.AppendLine();
                builder.Append("Bien dit !");
            }

            return builder.ToString();
        }

        public void Start(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                var input = _console.ReadLine();
                if(!string.IsNullOrWhiteSpace(input))
                {
                    _console.WriteLine(SaisirChaîne(input));
                }
            }
        }
    }
}
