#region Using directives
using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace ListDemo
{

    //Step - 3: Define PREDICATE.
    public class FindRacer
	{
        private string car;
		public FindRacer(string car)
		{
			this.car = car;
		}

		public bool DrivingCarPredicate(Racer racer)
		{
			return racer.Car == car;
		}
	}
    
    
    //Step - 7: Implementing the COMPARE method for comparison.
    public class RacerComparer : IComparer<Racer>
	{

		public enum CompareType
		{
			Name,
			Car
		}

		private CompareType compareType;

		public RacerComparer(CompareType compareType)
		{
			this.compareType = compareType;
		}


		#region IComparer<Racer> Members

		public int Compare(Racer x, Racer y)
		{
			int result = 0;
			switch (compareType)
			{
				case CompareType.Name:
					result = x.Name.CompareTo(y.Name);
					break;
				case CompareType.Car:
					result = x.Car.CompareTo(y.Car);
					break;
			}
			return result;
		}

		#endregion
	}



    //Step - 10: The Type to which the RACER has to be converted.
    public class Person
	{
		private string firstname;
		public string Firstname
		{
			get
			{
				return firstname;
			}

			set
			{
				firstname = value;
			}
		}

		private string lastname;
		public string Lastname
		{
			get
			{
				return lastname;
			}

			set
			{
				lastname = value;
			}
		}


		public Person(string firstname, string lastname)
		{
			this.firstname = firstname;
			this.lastname = lastname;
		}


		public override string ToString()
		{
			return firstname + " " + lastname;
		}

	}



    // Step - 1: The Racer class that will be the Enumerator. 
	public class Racer
	{
		private string name;
		public string Name
		{
			get
			{
				return name;
			}
		}
    	private string car;
		public string Car
		{
			get
			{
				return car;
			}
		}

        public Racer(string name, string car)
		{
			this.name = name;
			this.car = car;
		}
               
		public override string ToString()
		{
			return name;
		}
	}


    

	class Program
	{
		static void Main(string[] args)
		{

            //Step - 2: The creation of the Generic collection.
            List<Racer> racers = new List<Racer>();

            racers.Add(new Racer("Michael Schumacher", "Ferrari"));
			racers.Add(new Racer("Juan Pablo Montoya", "McLaren-Mercedes"));
			racers.Add(new Racer("Kimi Raikkonen", "McLaren-Mercedes"));
			racers.Add(new Racer("Mark Webber", "Williams-BMW"));
			racers.Add(new Racer("Rubens Barichello", "Ferrari"));


			FindRacer finder = new FindRacer("Ferrari");





            
            
            //Step - 4: USE the Defined PREDICATE.

            foreach (Racer racer in racers.FindAll(new Predicate<Racer>(finder.DrivingCarPredicate)))
            {
                Console.WriteLine(racer);
            }


            
            //          //Step - 5: Performing an ACTION.
            //			racers.ForEach(delegate(Racer r) { Console.WriteLine(r); });

            racers.FindAll(new Predicate<Racer>(finder.DrivingCarPredicate)).
				ForEach(delegate(Racer r) { Console.WriteLine(r); });

            
            //Step - 6: Performing a SORTING
            racers.Sort(delegate(Racer r1, Racer r2) { return r1.Name.CompareTo(r2.Name); });

            
            //Step - 8: Using the Comparer method to sort - sort done by the car.
            racers.Sort(new RacerComparer(RacerComparer.CompareType.Car));

			Console.WriteLine("\nSorted");
			racers.ForEach(delegate(Racer r) { Console.WriteLine(r); });

            //Step - 9: Type conversion delegate.
            //public sealed delegate TOutput Converter<TInput, TOutput>(TInput from);

            //Step - 11: Application of the conversion operation.
            List<Person> persons = racers.ConvertAll<Person>(delegate(Racer r) {
				int ixSeperator = r.Name.LastIndexOf(' ') + 1;
				string lastname = r.Name.Substring(ixSeperator, r.Name.Length - ixSeperator);
				string firstname = r.Name.Substring(0, ixSeperator - 1);
				return new Person(firstname, lastname); 
			});

			Console.WriteLine("Persons");
			persons.ForEach(delegate(Person p) { Console.WriteLine(p); });

            Console.ReadLine();
		}
	}








}
