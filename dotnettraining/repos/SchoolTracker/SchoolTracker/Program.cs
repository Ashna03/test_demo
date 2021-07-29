using System;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No. of Students in class");
            var StudCount = int.Parse(Console.ReadLine());
            var StudName = new string[StudCount];
            var StudGrade = new int[StudCount];
            for (int i = 0; i < StudCount; i++)
            {
                Console.WriteLine("Enter Student Name");
                StudName[i] = Console.ReadLine();
                Console.WriteLine("Enter Student Grade");
                StudGrade[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < StudCount; i++)
            {
                Console.WriteLine("Name :{0}, Grade: {1}",StudName[i],StudGrade[i]);
            }
        }
    }
}
