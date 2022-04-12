using System;
using System.Globalization;

namespace CurrentCulture
{
    class Program
    {
        static void Main(string[] args)
        {
            double val = 1235.56;

            Console.WriteLine($"Current culture: {CultureInfo.CurrentCulture.Name}");
            Console.WriteLine(val);

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("de-DE");

            Console.WriteLine($"Current culture: {CultureInfo.CurrentCulture.Name}");
            Console.WriteLine(val);
        }
    }
}