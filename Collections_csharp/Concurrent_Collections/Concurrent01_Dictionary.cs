using System;
using System.Collections;
using System.Collections.Concurrent;

namespace Ganesh.ConcurrentCollections
{
	public class DemoConcurretDictionary
	{
		
		public static void Main()
		{
			ConcurrentDictionary<Int32,string> doctors = new ConcurrentDictionary<Int32,string>();
			
			// TryAdd()
			bool flag = doctors.TryAdd(108,"Ganesh N");
			doctors.TryAdd(109,"Suresh Kumar");
			doctors.TryAdd(110,"Ramesh Singh");
			
			Console.WriteLine(flag);
			
			DemoConcurretDictionary.DisplayCollectionValue(doctors);
			
			bool flag1 = doctors.TryAdd(108,"Ganesh N");
			Console.WriteLine(flag1);
			DemoConcurretDictionary.DisplayCollectionValue(doctors);
			
			
			// TryGetValue()
			// a present key.
			string keyvalue_01;
			bool keyIsPresent_01 = doctors.TryGetValue(108, out keyvalue_01);
			Console.WriteLine("Present = " + keyIsPresent_01);
			Console.WriteLine("The value corresponding to {0} is {1}",108,keyvalue_01);
			
			
			// TryGetValue()
			// an absent key.
			string keyvalue_02;
			bool keyIsPresent_02 = doctors.TryGetValue(111, out keyvalue_02);
			Console.WriteLine(keyIsPresent_02);
			Console.WriteLine("The value corresponding to {0} is {1}",111,keyvalue_02);
			// key is not present but NO EXCEPTION RAISED.
			
			
			// TryRemove()
			string value_03;
			bool bool_value_03 = doctors.TryRemove(110, out value_03);
			Console.WriteLine("Removed = " + bool_value_03);
			DemoConcurretDictionary.DisplayCollectionValue(doctors);
			
		}
		
		
		public static void DisplayCollectionValue(IEnumerable myenum)
		{
			foreach(var item in myenum)
			{
				Console.WriteLine(item.ToString());
			}
		}
	
	}
}
