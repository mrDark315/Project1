using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ВВедіть своє ім'я: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Привіт {name}");
        }
    }
}