using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second Number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1 + num2);
            Console.ReadLine();
        }
    }
}
