using System;
using System.Collections;
using System.Collections.Generic;





//Base abstract class
abstract class Professional
{
	public Int32 Id{get; set;}
	public string Name{get; set;}
	
	// abstract method. No defn but derived class need to define it.
	public abstract string DisplayProfessional();
}


class OpthoProfessional:Professional
{
	public string OpthoLicenseId{get; set;}
	
	// base class implementation of the derived class.
	public override string DisplayProfessional()
	{
		return Id + "  " + Name + "  " + OpthoLicenseId;
	}
}


class CardioProfessional:Professional
{
	public string CardioAssocRegNo{get; set;}
	
	// base class implementation of the derived class.
	public override string DisplayProfessional()
	{
		return Id + "  " + Name + "  " + CardioAssocRegNo;
	}
}


class Test
{
	public static void Main()
	{
	
	// List<T> where T = Professional (will have both OpthoProfessional & CardioProfessional)
	List<Professional> myprofessionals = new List<Professional>();
	
	// OpthoProfessional instance
	Professional ramesh = new OpthoProfessional
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
	
	foreach(Professional p in myprofessionals)
	{
		// The appropriate DisplayProfessional() is called.
		Console.WriteLine(p.DisplayProfessional());
	}
	

	}
}