using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string colour, flowers, Celeberity;
            Console.Write("Enter a colour");
            colour = Console.ReadLine();
            Console.Write("Enter a flowers");
            flowers= Console.ReadLine();
            Console.Write("Enter a Celeberity");
            Celeberity = Console.ReadLine();



            Console.WriteLine("Roses are "+ colour);
            Console.WriteLine( flowers + " are blue");
            Console.WriteLine("I love " + Celeberity);
            Console.ReadLine();
        }
    }
}
