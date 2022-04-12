using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ParallelLinq
{
	class City  
	{  
	   public int Id { get; set; }  
	   public string   CityName { get; set; }  
	   public string Country { get; set; }  
	} 	
	
	class Test
	{
		public static void Main()
		{
				var cities = new[] 
				{  
					new City { Id = 1,  CityName = "Turku"  , Country = "Finland" },  
					new City { Id = 2,  CityName = "Paris"  , Country = "France" },  
					new City { Id = 3,  CityName = "Oslo"    ,  Country = "Norway" } ,  
					new City { Id = 4,  CityName = "Helsinki"     , Country = "Finland" },  
	  
					new City { Id = 5,  CityName = "Turku"  , Country = "Finland" },  
					new City { Id = 6,  CityName = "Paris"  , Country = "France" },  
					new City { Id = 7,  CityName = "Oslo"    ,  Country = "Norway" } ,  
					new City { Id = 8,  CityName = "Helsinki"     , Country = "Finland" } ,  
	  
					new City { Id = 9,  CityName = "Turku"  , Country = "Finland" },  
					new City { Id = 10,  CityName = "Paris"  , Country = "France" },  
					new City { Id = 11,  CityName = "Oslo"    ,  Country = "Norway" } ,  
					new City { Id = 12,  CityName = "Helsinki"     , Country = "Finland"},  
	  
					new City { Id = 13,  CityName = "Turku"  , Country = "Finland" },  
					new City { Id = 14,  CityName = "Paris"  , Country = "France" },  
					new City { Id = 15,  CityName = "Oslo"    ,  Country = "Norway" } ,  
					new City { Id = 16,  CityName = "Helsinki"     , Country = "Finland"},  
	  
					new City { Id = 17,  CityName = "Turku"  , Country = "Finland" },  
					new City { Id = 18,  CityName = "Paris"  , Country = "France" },  
					new City { Id = 19,  CityName = "Oslo"    ,  Country = "Norway" } ,  
					new City { Id = 20,  CityName = "Helsinki"     , Country = "Finland"}  
				}; 

				
				//var finCities = cities.Where(c => c.Country == "Finland"); 
				var finCities = cities.AsParallel().Where(c => c.Country == "Finland");				
                                          
				foreach (City city in finCities)  
					Console.WriteLine(city.CityName); 
				
				
 		}
	}
}