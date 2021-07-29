using System;

namespace Survey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Name");
            var name = Console.ReadLine();
            Console.WriteLine("What is your Age");
            var age = Console.ReadLine();
            Console.WriteLine("What is your Birth month");
            var month = Console.ReadLine();
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Month: {0}", month);
        }
    }
}
