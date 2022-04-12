using System;
using System.Globalization;

namespace CurrentCulture
{
    class Program
    {
		/*
			Cultures use decimal point (Israel, Japan, UK) or comma (Slovakia, France, Germany) as decimal separators. Persian uses a forward slash (/).
		*/

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double val = 1278.112;

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("sk-SK");
            Console.WriteLine($"{val}");

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            Console.WriteLine($"{val}");

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("");
            Console.WriteLine($"{val}");
        }
    }
}