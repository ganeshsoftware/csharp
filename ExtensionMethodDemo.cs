using System;
using System.Text;
namespace Program 
{
   public static class Demo 
   {
		public static int myExtensionMethod(this string str) 
		{
			return Int32.Parse(str);
		}
   }
   class Program 
   {
		static void Main(string[] args) 
		{
			string str1 = "565";
			int n = str1.myExtensionMethod();
			Console.WriteLine("Result: {0}", n);
			Console.ReadLine();
		}
   }
}