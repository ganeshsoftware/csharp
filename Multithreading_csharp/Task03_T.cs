using System;
using System.Threading.Tasks;


public class Doctor
{
	public Int32 Id {get; set;}
	public string Name {get; set;}
	
	public override string ToString()
	{
		return this.Id + "  "  + this.Name; 		
	}
}



public class TaskRun
{
   public static void Main()
   {
	  
      var t = Task<Doctor>.Run(() => { Doctor ramesh = new Doctor {Id= 100, Name="Ramesh Talwar"}; 		
												
                                    }return ramesh;);
      Console.WriteLine(t.ToString());
   }
}
// The example displays output like the following: Finished 1,000,001 loop iterations.