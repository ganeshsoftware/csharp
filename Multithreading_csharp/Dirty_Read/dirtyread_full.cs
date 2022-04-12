using System;
using System.Threading;



namespace ArrayApplication 
{

	class ThreadDirtyReadDemo
	{
		
		// n is an array of 1000 integers
		int[]  n = new int[1000]; 
		
		int i,j;
		
				
		//Initialize elements of array n.
		public void InitializeArray()
		{
			
			for (i = 0; i < 1000; i++) 
			{
				n[i] = i + 4551;
			}
		}

				
		// Change the contents of the array.
		public void ChangeArray()
		{
			for (i = 0; i < 1000; i++) 
			{
				n[i] = i + 1000;
				Thread.Sleep(500);
			}
		}
			
		
		//Display the contents of the array n
		public void DisplayArray()
		{
			//display elements of the array
			 for (j = 0; j < 1000; j++) 
			 {
				Console.WriteLine("A[{0}] = {1}", j, n[j]);
				Thread.Sleep(1000);
			 }
		}
	}


   class MyArray
	{
   
      static void Main(string[] args)
		{
		
			ThreadDirtyReadDemo m_ThreadDirtyReadDemo = new ThreadDirtyReadDemo();
			
			m_ThreadDirtyReadDemo.InitializeArray();
			
			Thread t1 = new Thread(m_ThreadDirtyReadDemo.ChangeArray);
			Thread t2 = new Thread(m_ThreadDirtyReadDemo.DisplayArray);
			
			t1.Start();
			t2.Start();
						
			Console.ReadKey();
		}
	}
}