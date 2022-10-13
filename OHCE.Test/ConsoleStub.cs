using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OHCEB3Nantes;

namespace OHCE.Test
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
