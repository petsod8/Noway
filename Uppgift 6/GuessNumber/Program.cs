using System;

namespace GuessNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Gissa mitt nummer mellan 1-100: ");
			//int x = MyRandomNumber();
			
			var rand = new Random();
			int x = rand.Next(101);
			int varv = 0;

			int guess = 0;

			while (guess != x)
			{
				varv++;
				guess = Convert.ToInt32(Console.ReadLine());
				if (guess == x)
				{
					Console.WriteLine("Snyggt! Du svarade " + x + " som är rätt svar.");
					Console.WriteLine("Det tog " + varv + " försök att hitta mitt nummer!");
					Console.ReadLine();
					break;
				}

				else if (guess != x)
				{
					if (guess < x)
					{
						Console.WriteLine("Nej, " + guess + " är för lågt");
					}

					else if
						(guess > x)
					{
						Console.WriteLine("Nej, " + guess + " är för högt");
					}
					Console.WriteLine("Försök igen");
					//guess = Convert.ToInt32(Console.ReadLine());
				}
			}
		}
	}
}
