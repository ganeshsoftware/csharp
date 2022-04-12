#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace CollectionDemo
{
	class Team
	{
		private string name;

		public Team(string name)
		{
			this.name = name;
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
			Collection<Team> teams = new Collection<Team>();
			teams.Add(new Team("Ferrari"));
			teams.Add(new Team("Williams-BMW"));
			teams.Add(new Team("Bar-Honda"));
			teams.Add(new Team("McLaren-Mercedes"));

			foreach (Team t in teams)
			{
				Console.WriteLine(t);
			}

			Console.ReadLine();

		}
	}
}
