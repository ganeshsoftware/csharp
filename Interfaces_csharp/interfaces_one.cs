class Professional
{
	
}

interface IProfessional
{
	string AddProfessional(Professional p);
	string RemoveProfessional(Professional p);
}


class GeneralSpecialist:IProfessional
{
	public string AddProfessional(Professional p)
	{
		return "Professional successfully added!";
		
	}
	public string RemoveProfessional(Professional p)
	{
		return "Professional successfully remioved from the list!";
	}
}

class GeneralSurgeon
{


}


class Test
{
	public static void Main()
	{
		IProfessional prof1 = new GeneralSpecialist();
		
		
		
	}
}