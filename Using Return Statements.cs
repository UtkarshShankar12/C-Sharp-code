using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(cube (5));
            Console.ReadLine();
        }

        static int cube(int num)
        {
            int results = num * num * num;
            return results;
        }
    }
}
