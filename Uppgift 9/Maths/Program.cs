using System;
namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett decimaltal: ");
            double value = double.Parse(Console.ReadLine());

            //Roten ur
            Console.WriteLine("Roten ur blir: " + Math.Sqrt(value) + ".");

            //upphöjt till 2
            Console.Write("Upphöjt till 2 blir svaret: ");
            Console.WriteLine($"{value}^2 = {(long)Math.Pow(value, 2):N0}");


            //upphöjt till 10
            Console.Write("Upphöjt till 10 blir svaret: "); 
            Console.WriteLine($"{value}^10 = {(long)Math.Pow(value, 10):N0}");

            Console.ReadKey();
        }
    }
}