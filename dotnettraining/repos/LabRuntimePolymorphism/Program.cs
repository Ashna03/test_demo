using System;

namespace LabRuntimePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter 'M' for Maruti Alto 800 , 'F' for Ferrari and 'B' for Benz");
            string model = Console.ReadLine(); 
            Cars car;
            switch (model)
            {
                case "M":
                    car = new MarutiAlto800();
                    ((MarutiAlto800)car).Price = 500000;
                    ((MarutiAlto800)car).Color = "Red";
                    ((MarutiAlto800)car).Year_of_Manufacture =2002;
                    Console.WriteLine(car.Purchase());
                    break;
                case "F":
                    car = new Ferrari();
                    ((Ferrari)car).Price = 85000000;
                    ((Ferrari)car).Color = "Blue";
                    Console.WriteLine(car.Purchase());
                    break;
                case "B":
                    car = new Benz();
                    ((Benz)car).Price = 40000000;
                    ((Benz)car).Color = "Silver";
                    ((Benz)car).Speed = 45;
                    Console.WriteLine(car.Purchase());
                    break;
                default:
                    Console.WriteLine("Invalid Car Model");
                    break;
            }
        }
    }
}
