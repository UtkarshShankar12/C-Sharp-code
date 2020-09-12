using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = ("UVGameCompany" + "This is my company");
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase.Contains("company"));
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase.IndexOf("company"));
            Console.WriteLine(phrase.Substring(9,3));
            Console.ReadLine();
        }
    }
}
