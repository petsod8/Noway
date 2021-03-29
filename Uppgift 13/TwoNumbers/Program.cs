using System;

namespace TwoNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Skriv ett heltal : ");
			int tal1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Skriv ett heltal till : ");
			int tal2 = Convert.ToInt32(Console.ReadLine());

			if (tal1 == tal2)
			{
				Console.WriteLine("Du svarade med samma tal 2gånger.");
				Console.ReadKey();
			}
			else if (tal1 != tal2)
			{
				if (tal1 < tal2)
				{
					for (int i = tal1; i <= tal2; i++)
						Console.Write(" " + i + ", ");
				}

				else if
					(tal1 > tal2)
				{
					for (int i = tal2; i <= tal1; i++)
						Console.Write(" " + i + ", ");
				}
				Console.ReadKey();
			}
		}
	}
}

