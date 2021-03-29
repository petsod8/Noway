using System;

namespace UserAvatar
{

	class Avatar 
	{
		public string userName;
		public int health;
		public int strenght;
		public int luck;
		public int GetForce() 
		{
			return (strenght * health)/10;
		}

		public void Display() 
		{
			Console.WriteLine("Namn: {0}", userName);
			Console.WriteLine("Din hälsa är: {0}", health);
			Console.WriteLine("Din styrka är: {0}", strenght);
			Console.WriteLine("Din tur är: {0}", luck);
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			var rand = new Random();
			Console.Write("Skriv ditt namn på en avatar:");
			string userName = Console.ReadLine();
			
			Avatar player = new Avatar();
			player.userName = userName;
			player.health = rand.Next(101);
			player.strenght = rand.Next(101);
			player.luck = rand.Next(11);

			Console.Write("Skriv namnet på en motståndare: ");
			string oppName = Console.ReadLine();

			Avatar opponent = new Avatar();
			opponent.userName = oppName;
			opponent.health = rand.Next(101);
			opponent.strenght = rand.Next(101);
			opponent.luck = rand.Next(11);

			player.Display();
			Console.ReadLine();

			opponent.Display();
			Console.ReadLine();
		}
	}
}
