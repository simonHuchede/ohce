using OHCE.Langues;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE.Console
{
    internal class SystemLangProxy 
    {
        public ILangue _langue;

        public ILangue GetSystemLangProxy(string langueSysteme)
        {
            var langue = langueSysteme;
            if(langue == "fr")
            {
                _langue = new LangueFrançaise();
            }
            else
            {
                _langue = new LangueAnglaise();
            }
            return _langue;
        }

    }
}
