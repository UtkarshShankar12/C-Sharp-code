using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("Harsh",20);
            SayHi("Utkarsh",15);
            SayHi("Tanya",18);
            Console.ReadLine();
        }

        static void SayHi( string name , int age  )
        {
            Console.WriteLine("Hello " + name + " your age is " + age);
        }
    }
}
