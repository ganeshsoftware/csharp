#region Using directives

using System;
using System.Runtime.InteropServices;

#endregion

namespace Wrox.ProCSharp.COMInterop.Server
{
	[InterfaceType(ComInterfaceType.InterfaceIsDual)]
	public interface IWelcome
	{
		string Greeting(string name);
	}

	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IMath
	{
		int Add(int val1, int val2);
		int Sub(int val1, int val2);
	}

	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
	public interface IMathEvents
	{
		[DispId(46200)]
		void CalculationCompleted();
	}

	[ComVisible(false)]
	public delegate void CalculationCompletedDelegate();


	[ClassInterface(ClassInterfaceType.None)]
	[ProgId("Wrox.DotnetComponent")]
	[Guid("77839717-40DD-4876-8297-35B98A8402C7")]
	[ComSourceInterfaces(typeof(IMathEvents))]
	public class DotnetComponent : IWelcome, IMath
	{
		public DotnetComponent()
		{
		}

		public event CalculationCompletedDelegate CalculationCompleted;

		public string Greeting(string name)
		{
			return "Hello " + name;
		}

		public int Add(int val1, int val2)
		{
			int result = val1 + val2;
			if (CalculationCompleted != null)
				CalculationCompleted();
			return result;
		}

		public int Sub(int val1, int val2)
		{
			int result = val1 - val2;
			if (CalculationCompleted != null)
				CalculationCompleted();
			return result;
		}
	}
}

