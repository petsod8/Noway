using System;

namespace NameAge
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("First name: ");
			String firstname = Console.ReadLine();
			Console.Write("Surname: ");
			String lastname = Console.ReadLine();
			Console.Write("Age: ");
			String age = Console.ReadLine();
			Console.WriteLine("Hello " + firstname +" "+ lastname + " your age is " + age);
			Console.WriteLine("Enter a key to exit");
			Console.ReadKey();
		}
	}
}
