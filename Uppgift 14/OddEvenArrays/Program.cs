using System;
namespace OddEvenArrays
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Skriv flera heltal och avskilj talen sinsemellan med komma (,): ");
			string values = Console.ReadLine();
			//int[] values = new int[] {8,9,26,13};
			var valArr = values
				.Split(new[] { ','})
				.Select(values => int.Parse(values))
				.ToArray();

			//	.Select(values => int.Parse(values)) // get the "list" of integers
			//.Select(values => Convert.ToInt32(values))
			//	.ToArray();

			foreach (int tal in valArr)
			{
				var a=0;
				bool ret_val = Int32.TryParse(values, out a);
				int raknEven = 0; 
				int raknOdd = 0;
				int[] arrEven=null; 
				int[] arrOdd=null;
				if (ret_val == true)
				{
					if (tal % 2 == 0)
					{
						arrEven[raknEven] = tal;
						raknEven++;
					}
					else
					{
						arrOdd[raknOdd] = tal;
						raknOdd++;
					}
				}

				else
				{
					Console.WriteLine("An invalid string!");
				}

				Console.Write("Jämna nummer är: ");
				for (int i = 0; i < raknEven; i++) { Console.WriteLine(arrEven[i]); }

				Console.Write("Udda nummer är: ");
				for (int i = 0; i < raknOdd; i++) { Console.WriteLine(arrOdd[i]); }
				Console.ReadKey();
			}
		}
	}
}