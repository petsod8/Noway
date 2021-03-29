using System;

namespace BiggestNumber
{
	class Program
	{
		static void Main(string[] args)
		{

			//int[1] myNumbers = 1;
			int[] myNumbers = { };

			Console.Write("Skriv ett nummer: ");
			int myNumbers[0] = Convert.ToInt32(Console.ReadLine());
			//{ 8, 1, 3, 5 };
			Console.Write("Skriv ett nummer till: ");
			int myNumbers[1] = Convert.ToInt32(Console.ReadLine());

			Array.Sort(myNumbers);

			Console.WriteLine("Det största talet är : " + myNumbers[1]);

		}
	}
}