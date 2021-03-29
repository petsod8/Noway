using System;

namespace FontColor
{
	class Program
	{
		static void Main()
		{
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine("Hello World!");
			Console.ReadKey();
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine("Hello World!");
		}
	}
}