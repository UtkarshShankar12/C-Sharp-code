using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            Console.Write("Enter your age:");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you are " + age );
            Console.ReadLine();
        }
    }
}
