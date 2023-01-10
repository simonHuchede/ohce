using OHCE;
using OHCE.Console;
using OHCE.Langues;
using System.Globalization;

var ohce = new Ohce(new SystemLangProxy().GetSystemLangProxy(CultureInfo.InstalledUICulture.TwoLetterISOLanguageName), new SystemTimePériodeJournéeAdapter().GetPériode(DateTime.Now.Hour));


Console.WriteLine(ohce.Saluer());

Console.WriteLine("Entrez un mot pour savoir si c'est un palindrome");

Console.WriteLine(ohce.Palindrome(Console.ReadLine() ?? String.Empty));