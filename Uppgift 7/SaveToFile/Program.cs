using System;
using System.IO;
using System.Threading.Tasks;


namespace SaveToFile
{
    class WriteAllText
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett ord och avluta med ENTER.");
            string text = Console.ReadLine();

            File.WriteAllText("Text i konsolen.txt", text);

            string readText = File.ReadAllText("Text i konsolen.txt");
            Console.WriteLine(readText);
        }     
    }
}
