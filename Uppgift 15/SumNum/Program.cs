using System;
namespace OddEvenArrays
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Skriv flera heltal och avskilj talen sinsemellan med komma (,): ");
			//string values = Console.ReadLine();
			int[] values = new int[] {8,9,26,13};
			var valArr = values
				.Split(new[] { ',' })
				.Select(values => int.Parse(values))
				.Sum();

			Console.ReadKey();
		}
	}
}

