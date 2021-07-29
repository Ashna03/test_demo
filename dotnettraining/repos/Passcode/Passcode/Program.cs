using System;

namespace Passcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Passcode");
            var a = Console.ReadLine();
            if (a == "secret")
            {
                Console.WriteLine("You are an authenticated user");
            }
            else if (a != "secret")
            {
                Console.WriteLine("You are not an authenticated user");
            }
        }
    }
}
