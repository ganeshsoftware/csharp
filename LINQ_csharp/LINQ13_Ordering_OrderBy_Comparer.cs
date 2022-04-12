using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

namespace Linq.OrderingOperators
{
	class Program
	{
		public static void Main()
		{
			LinqSamples samples = new LinqSamples();
			samples.Linq31();
		}
	}
	
	public class CaseInsensitiveComparer : IComparer<string>
	{
		public int Compare(string x, string y)
		{
			return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
		}
	}
	
	
	
    public class LinqSamples
	{
		private List<Product> products;
		private List<Product> productList;

		public void Linq31()
		{
			string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
			var sortedWords = words.OrderBy(a => a, new CaseInsensitiveComparer());
			ObjectDumper.Write(sortedWords);
		}
	}
	
	public void Linq31()
	{
		string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
	 
		var sortedWords = words.OrderBy(a => a, new CaseInsensitiveComparer());
	 
		ObjectDumper.Write(sortedWords);
	}
 
	public class CaseInsensitiveComparer : IComparer<string>
	{
		public int Compare(string x, string y)
		{	
			return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
		}
	}

}