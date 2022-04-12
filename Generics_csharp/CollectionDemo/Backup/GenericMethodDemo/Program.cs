#region Using directives

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

#endregion

namespace GenericMethodDemo
{
	public static class Algorithm
	{
	// 1. no operators with generics
//		public static T Max<T>(T x, T y)
//		{
//			if (x > y)
//				return x;
//			else
//				return y;
//		}


		public static T Max<T>(T x, T y, Comparison<T> comparer)
		{
			int result = comparer(x, y);

			return result > 0 ? x : y;
		}

		public static decimal AccumulateSimple(IEnumerable e)
		{
			decimal sum = 0;
			foreach (Account a in e)
			{
				sum += a.Balance;
			}
			return sum;
		}

		public static decimal Accumulate<T, U>(U coll)
			where U : IEnumerable<T>
			where T : IAccount
		{
			decimal sum = 0;

			foreach (T a in coll)
			{
				sum += a.Balance;
			}

			return sum;
		}

		public static decimal Accumulate<TAccount>(IEnumerable<TAccount> coll)
			where TAccount : IAccount
		{
			decimal sum = 0;

			foreach (TAccount a in coll)
			{
				sum += a.Balance;
			}

			return sum;
		}


		public delegate U Adder<T, U>(T t, U u);


		public static U Accumulate<T, U>(IEnumerable<T> coll, Adder<T, U> adder)
		{
			U sum = default(U);

			foreach (T a in coll)
			{
				sum = adder(a, sum);
			}

			return sum;
		}

		public static U AccumulateIf<T, U>(IEnumerable<T> coll, Adder<T, U> adder, Predicate<T> match)
		{
			U sum = default(U);

			foreach (T a in coll)
			{
				if (match(a))
				{
					sum = adder(a, sum);
				}
			}

			return sum;
		}
	}

	public class Account : IAccount
	{
		private string name;
		public string Name
		{
			get
			{
				return name;
			}
		}

		private decimal balance;
		public decimal Balance
		{
			get
			{
				return balance;
			}
		}


		public Account(string name, Decimal balance)
		{
			this.name = name;
			this.balance = balance;
		}
	}

	class Program
	{
		static int Compare(int x, int y)
		{
			if (x == y)
				return 0;
			else if (x < y)
				return -1;
			else
				return 1;
		}

	

		static decimal AccountAdder(Account a, decimal d)
		{
			return a.Balance + d;
		}

		static void Main(string[] args)
		{
			int i = 3;
			int j = 4;
			int result = Algorithm.Max<int>(i, j, new Comparison<int>(Program.Compare));



			List<Account> accounts = new List<Account>();
			accounts.Add(new Account("Christian", 1500));
			accounts.Add(new Account("Sharon", 2200));
			accounts.Add(new Account("Katie", 1800));

			foreach (Account a in accounts)
			{
				Console.WriteLine(a.Name);
			}

			decimal sum1 = Algorithm.AccumulateSimple(accounts);
			Console.WriteLine(sum1);

			decimal sum2 = Algorithm.Accumulate(accounts);

			Console.WriteLine("sum of all accounts {0}", Algorithm.Accumulate<Account>(accounts));


			decimal sum3 = Algorithm.Accumulate<Account, decimal>(accounts, new Algorithm.Adder<Account, decimal>(AccountAdder));
			Console.WriteLine(sum3);

			decimal sum3b = Algorithm.Accumulate<Account, decimal>(accounts, AccountAdder);
			Console.WriteLine("3b " + sum3b);

			decimal sum4 = Algorithm.Accumulate<Account, decimal>(accounts,
				delegate(Account a, decimal d) { return a.Balance + d; });
			Console.WriteLine(sum4);


			decimal sum5 = Algorithm.AccumulateIf<Account, decimal>(
				accounts, 
				delegate(Account a, decimal d) { return a.Balance + d; },
				delegate(Account a) {return a.Balance > 1800 ? true : false; });

			Console.WriteLine(sum5);




			Console.ReadLine();

		}
	}
}
