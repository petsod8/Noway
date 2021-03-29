using System;

namespace BiggestNumber
{
	class Program
	{
		static void Main(string[] args)
		{	
			Console.Write("Skriv ett nummer: ");
			int tal1 = Convert.ToInt32(Console.ReadLine());
			//{ 8, 1, 3, 5 };
			Console.Write("Skriv ett nummer till: ");
			int tal2 = Convert.ToInt32(Console.ReadLine());

			if (tal1 < tal2) 
			{ 
				Console.WriteLine("Det största talet är : " + tal2); 
			} 
			else if(tal2 < tal1) 
			{ 
				Console.WriteLine("Det största talet är : " + tal1); 
			} 
			else 
			{ 
				Console.WriteLine("De är samma tal : " + tal2+ " " +tal1); 
			}

			Console.ReadKey();

		}
	}
}