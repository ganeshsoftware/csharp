// Invoking a Method Asynchronously.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Runtime.Remoting.Messaging;


namespace Ganesh.AsyncCallback
{

	public delegate string DoctorOps(Doctor doc);


	// class : Doctor
	public class Doctor	
	{
		public Int32 Iden {get; set;}
		public string Name {get; set;}
	}
	
	// class : Hospital 
	public class Hospital
	{
		public string PresentDoctorDetail(Doctor doct)
		{
			//Print the ID of the executing thread
			Console.WriteLine("PresentDoctorDetail method invoked on thread {0}", Thread.CurrentThread.ManagedThreadId);

			// A dummy for loop for steps.
			for(Int32 counter =0 ; counter<=100; counter++)
			{
				Thread.Sleep(100);	
				Console.WriteLine("Completed {0} operations.",counter);
			}
			return "Identification: " + doct.Iden + "  " + "Full Name:" + doct.Name;			
		}
	}
	
	
	// class : TestClass
	public class TestClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Main invoked on thread {0}", Thread.CurrentThread.ManagedThreadId);
			
			//Invoking PresentDoctorDetail() 
			DoctorOps docops = new DoctorOps(new Hospital().PresentDoctorDetail);
			
			//Call the BeginInvoke() of the delegate.
			IAsyncResult iasyncres = docops.BeginInvoke(new Doctor{Iden=1008, Name="Ganesh N"}, null, null);
			
			// Detecting the 'IsCompleted' property to check the completion.
			while(!iasyncres.IsCompleted)
			{
				Console.WriteLine("Work on the Main thread");
				Thread.Sleep(100);
			}
			
			// Call the EndInvoke() of the delegate once completed.
			string result = docops.EndInvoke(iasyncres);
			
			Console.WriteLine("The Doctor Details are {0}", result);
		}		
	}
}