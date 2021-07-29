using System;

namespace Survey_OOP
{
    class Data
    {
        public string Name;
        public int Age;
        public string Month;

        public void display()
        {
            Console.WriteLine("Name is: {0}", Name);
            Console.WriteLine("Age is: {0}", Age);
            Console.WriteLine("Month is: {0}", Month);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Data();

            Console.WriteLine("Enter your Name");
            data.Name = Console.ReadLine();
            Console.WriteLine("Enter your Age");
            data.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Month");
            data.Month = Console.ReadLine();
            data.display();

        }
    }
}
