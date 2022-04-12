using System;


class Pyramid
{
	public void ConstructTriangle()
	{
	  string str="";
	  for(Int32 i=1;i<=5;i++)
	  {
		str = str + " " + i; 
		Console.WriteLine("{0} ",str);

	  }
	}
	
	public void ConstructPyramid()
	{
		
		
	}
	
	public void ReverseNumbers()
	{
	  string str="";
	  for(Int32 i=5;i>=1;i--)
	  {
		str = str + " " + i; 
		Console.WriteLine("{0} ",str);

	  }		
		
	}
	
	
	
}

class TheTestClass
{
	public static void Main()
	{
	   Pyramid p1 = new Pyramid();
	   p1.ConstructTriangle();
	   p1.ReverseNumbers();
	
	}
}