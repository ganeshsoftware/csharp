using System;
using System.Collections.Generic;

class TestFunc
{
	public static void Main()
	{
		Predicate<string> isnumber = delegate(string,y){return y.isNan();};
		bool result = isNumber("425");
	}

}



