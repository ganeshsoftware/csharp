using System;
using System.Globalization;

namespace CurrentCulture
{
    class Program
    {
        static void Main(string[] args)
        {
			
			var now = DateTime.Now;

            // slovak culture.
			var skSk = new CultureInfo("sk-SK");
            CultureInfo.DefaultThreadCurrentCulture = skSk;

            
			// slovak FullDateTimePattern pattern
			Console.WriteLine(skSk.DateTimeFormat.FullDateTimePattern);
			// slovak current full date time format. 
            Console.WriteLine(now.ToString(skSk.DateTimeFormat.FullDateTimePattern));

            Console.WriteLine();

            Console.WriteLine(skSk.DateTimeFormat.LongDatePattern);
            Console.WriteLine(now.ToString(skSk.DateTimeFormat.LongDatePattern));

            Console.WriteLine();

            Console.WriteLine(skSk.DateTimeFormat.ShortTimePattern);
            Console.WriteLine(now.ToString(skSk.DateTimeFormat.ShortTimePattern));
			
			
			
			

        }
    }
}