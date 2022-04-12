using System;
using System.Text;
namespace Program 
{
   public class Student
   {
		public Int32 Id {get; set;}
	   	public string Name {get; set;}
   }
   
   
   public static class Demo 
   {
		public static string StudentDetails(this Student stud) 
		{
			return stud.Id + " " + stud.Name;
		}
   }
   
   
   
   class Program 
   {
		static void Main(string[] args) 
		{
			Student ganesh = new Student() 
			{
				Id = 108 , 
				Name= "ganesh"
			};
			
			// useage 
			string ganeshDetails = ganesh.StudentDetails();
			
			Console.WriteLine("Result: {0}", ganeshDetails);
			Console.ReadLine();
		}
   }
}