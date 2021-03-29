using System;

namespace TwoArrays
{
	class Program
	{
		static void Main(string[] args)
		{
			var rand = new Random();

			int slumpTal = rand.Next(101);
			int[] myNumbers = new int[6];// {65, 6, 3, 78};
			for (int i = 0; i < 5; i++)
			{
				myNumbers[i] = slumpTal;
				slumpTal = rand.Next(101);
			}

			int[] sortMyNum = myNumbers;

			Console.WriteLine("Random numbers: ");
			foreach (int rOund in myNumbers)
			{
				Console.WriteLine(rOund);
			}
			Console.ReadLine();

			Array.Sort(sortMyNum);
			Console.WriteLine("Sorted numbers: ");
			foreach (int rOund in sortMyNum)
			{
				Console.WriteLine(rOund);
			}
			Console.ReadLine();
		}
	}
}
