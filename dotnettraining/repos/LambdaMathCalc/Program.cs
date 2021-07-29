using System;

namespace LambdaMathCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            MathCalculator obj = new MathCalculator();
            Console.WriteLine("Math Calculator");
            Console.WriteLine("1.Addition 2.Subtraction 3.Multiplication 4.Division");
            int Operator = Convert.ToInt32(Console.ReadLine());
            switch (Operator) 
            {
                case 1:
                    Console.WriteLine($"The sum is {obj.LambdaAdd(30, 40)}");
                    break;
                case 2:
                    Console.WriteLine($"The difference is {obj.LambdaSub(30, 40)}");
                    break;
                case 3:
                    Console.WriteLine($"The product is {obj.LambdaMul(30, 40)}");
                    break;
                case 4:
                    Console.WriteLine($"The division gives {obj.LambdaDiv(30, 40)}");
                    break;
                default:
                    Console.WriteLine("Invalid Operation");
                    break;

            }
            //MathCalculator obj = new MathCalculator();
            //Console.WriteLine($"The sum is {obj.LambdaAdd(30,40)}");
            //Console.WriteLine($"The difference is {obj.LambdaSub(30, 40)}");
            //Console.WriteLine($"The product is {obj.LambdaMul(30, 40)}");
            //Console.WriteLine($"The division gives {obj.LambdaDiv(30, 40)}");
        }
    }
}
