/*
	A method getting executed at specific time intervals.
*/
using System;
using System.Threading;


public class TestClass
{
	private Timer _timer;
	private TimeSpan _updateInterval = TimeSpan.FromMilliseconds(5000);
	
	
	public void PrintMessage(object state)
	{
		Console.WriteLine("Today is {0}",DateTime.Now);			
	}
	
	public void Ticker()
	{
		for (Int32 counter=
		0; counter<=10;counter++)
		{
			_timer = new Timer(this.PrintMessage,null,_updateInterval,_updateInterval);			
		}
		
	}
}


public class TimerDemo
{
	public static void Main()
	{
		TestClass m_TestClass = new TestClass();
		m_TestClass.Ticker();
	}
}







