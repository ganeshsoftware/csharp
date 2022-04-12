using System;
using System.Globalization;

namespace CurrentCulture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Int32 val = 12156320;

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("sk-SK");
            Console.WriteLine($"{val:N}");

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            Console.WriteLine($"{val:N}");

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("de-CH");
            Console.WriteLine($"{val:N}");

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("hi-IN");
            Console.WriteLine($"{val:N}");

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("es-ES");
            Console.WriteLine($"{val:N}");
        }
    }
}