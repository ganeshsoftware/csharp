using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mimsys.CSTraining2021.Classes
{
	
	public partial class HealthcareProfessional
	{
		public void WelcomeSophia()
		{
			Console.WriteLine("Good morning Nur.Sophia ");
		}
	}
	
	
	public partial class HealthcareProfessional
	{
		public void WelcomeRamesh()
		{
			Console.WriteLine("Good morning Pharmacist.Ramesh ");
		}
	}
	
	public partial class HealthcareProfessional
	{
		public void WelcomeJayesh()
		{
			Console.WriteLine("Good morning Dr.Jayesh ");
		}
	}
	
	public class Test
	{
		public static void Main()
		{
			HealthcareProfessional team = new HealthcareProfessional();
			team.WelcomeSophia();
			team.WelcomeRamesh();
			team.WelcomeJayesh();
		}
	}
}