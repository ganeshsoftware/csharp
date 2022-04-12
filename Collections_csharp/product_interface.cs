








class Product
{
	public Int32 Id{get; set;}
	public string Name{get; set;}
	public DateTime MfgDate{get; set;}
	
	
	public void ReadProductdetails(Int32 Id,string Name,DateTime MfgDate)
	{
		this.Id = Id;
		this.Name. = Name
		this.MfgDate = MfgDate;
	}

	public void DisplayProductdetails()
	{
		Console.WriteLine(this.Id + " " + this.Name + "  " + this.MfgDate);
	}


}