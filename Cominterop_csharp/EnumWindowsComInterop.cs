/*******************************************************************************************************************************************************

APPLICATION DESCRIPTION: 
1) This is a application that DLLImports() from 'user.dll'(Win32 dll) and uses one of the functions from it. 
-> EnumWindows() - used to display file handles of every process that is currently running in the system.

*******************************************************************************************************************************************************/

using System;
using System.Runtime.InteropServices;


namespace EnumReportApp
{

	public delegate bool CallBack(int hWnd, int lParam);

	public class EnumReportApp
	{
		[DllImport("User.dll", EntryPoint = "EnumWindows", SetLastError = true, CharSet = CharSet.Unicode, ThrowOnUnmappableChar = true)]		
		public static extern int EnumWindows(CallBack x, int y);

		public static void Main()
		{
			CallBack myCallBack = new CallBack(EnumReportApp.Report);
			EnumWindows(myCallBack,0);
		}
		public static bool Report(int hWnd, int lParam)
		{
			Console.WriteLine("Window Handle is: ");
			Console.WriteLine(hWnd);
			return true;		
		}
	} 	

}



       






