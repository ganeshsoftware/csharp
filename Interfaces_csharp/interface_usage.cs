using System;
using System.Collections;
using System.Collections.Generic;

interface IProfessional
{
	string DisplayProfessional();
} 


abstract class Professional:IProfessional
{
	public Int32 Id{get; set;}
	public string Name{get; set;}
	
	public abstract string DisplayProfessional();

}


class CardioProfessional:Professional
{
	public string CardioAssocRegNo{get; set;}
	public string ReadProfessional()
	{
		return Id + " " +  Name + " " + CardioAssocRegNo;
	}	
	// base class implementation of the derived class.
	public override string DisplayProfessional()
	{
		return Id + "  " + Name + "  " + CardioAssocRegNo;
	}
}

class OpthalProfessional:Professional
{
	public string OpthoLicenseId{get; set;}
	public string ReadProfessional()
	{
		return Id + " " +  Name + " " + OpthoLicenseId;
	}
	public override string DisplayProfessional()
	{
		return Id + "  " + Name + "  " + OpthoLicenseId;
	}	
}


class Test
{
	public static void Main()
	{
	
	List<Professional> myprofessionals = new List<Professional>();
	
	// OpthoProfessional instance
	Professional ramesh = new OpthalProfessional
	{
		Id = 100, 
		Name="Ramesh Kumar",
		OpthoLicenseId = "Ortho3245272"
	};
	
	// CardioProfessional instance
	Professional sebastian = new CardioProfessional
	{
		Id = 101, 
		Name="Sebastian", 
		CardioAssocRegNo = "Cardio7186423"
	};
	
	myprofessionals.Add(ramesh);
	myprofessionals.Add(sebastian);
	
	foreach(IProfessional p in myprofessionals)
	{
		Console.WriteLine(p.DisplayProfessional());		
	}
	

	}
	
}
