using System;

namespace MultiplicationMatrix
{
	class Program
	{
		static void Main(string[] args)
		{
			int i = 1;
			int j = 1;
			while (i < 11)
			{
				while (j < 11)
				{
					Console.WriteLine("" + i + " * " + j + " = " + i

* j);
					j++;
				}
				Console.WriteLine();
				i++;
				j = 1;
			}
		}
	}
}