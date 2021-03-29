using System;

namespace Palindrom
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Skriv ett ord: ");
			string text = Console.ReadLine();
			string text1 = text.ToLower();
			string revs = "";
			int numChar = text.Length;

			for (int i = numChar-1; i >= 0; i--)
			{
				revs += text[i].ToString();
			}
			string revs1 = revs.ToLower();

			if (revs1 == text1)
			{
				Console.WriteLine(text + " är ett palindrom.");
			}
			else 
			{
				Console.WriteLine(text + " är inte samma som");
				Console.WriteLine(revs + ".");
			}
			Console.ReadKey();
		}
	}
}