using System;

namespace DelLambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            Delegates obj = new Delegates();
            Console.WriteLine($"using Delegate output: {obj.Start(100,200)}");

            //Using anonymous functions
            Console.WriteLine($"Using Anonymous Delegate output: {obj.UsingAnonymousMethod(100, 200)}");

            //Using Lambdas
            Console.WriteLine($"Using Lambdas Delegate output: {obj.UsingLambdas(100, 200)}");

            //Creating fnctns inside a class as Lambdas
            DoSomething();
            Console.WriteLine(CanIUseLambdas);

            //Generic Delegates func
            obj.F1();

            //Passing Func<> as parameter
            Func<string, string> f1 = (str) => $"Welcome {str}";
            obj.DelParams(f1);

            // lambda for for-each
            obj.PrintSomething();

            obj.PrintMovies();
           
        
        }

        public static void DoSomething() => Console.WriteLine("Did Something!!!");  //Using lambda writing a fnctn

        //Read-only property
        public static bool CanIUseLambdas { get => true; }
    }
}
