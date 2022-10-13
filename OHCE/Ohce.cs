using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE
{
    public class Ohce
    {
        public string TraiterChaîne(string toto)
        {
            return new string(toto.Reverse().ToArray());
        }
    }
}
