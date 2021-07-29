using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelLambdas
{
    // declaration done outside class
    delegate int AddDel(int a, int b);
    public class Delegates
    {
        public int Start(int a, int b)
        {
            //Instantiate the delegate
            AddDel objDel = new AddDel(Add);
            //Invocation
            return objDel(a,b);
        }

        public int UsingAnonymousMethod(int a, int b)
        {
            //Instance using anonymous function
            AddDel objAnonDel = delegate (int a, int b) { return a + b; };              //instead of functions we use its declarations and function logic 
            objAnonDel += delegate (int a, int b) { return a - b; };
            return objAnonDel(a , b);                                // return -100 because the output of last fnctn is shown
        }

        public int UsingLambdas(int a, int b)
        {
            //Using Lambdas.Delegate object objLambda1 points to anonymous
            AddDel objLambdaDel = (int a, int b) => {                               // => is a lambda 
                int r = a + b;
                return r;
            };
            //The above can br represented in the following way
            AddDel objShortLambda = (a, b) => a + b;                              // => returns the value as well
            //Invoke
            return objShortLambda(a , b);

        }
        private int Add(int a, int b)
        {
            return a + b;
        }

        #region Generic Delegates

        public void F1()
        {
            Func<int, int, int> likeAddDel = (a, b) => a + b;
            Action<int, int> doesNotReturnValue = (a, b) => Console.WriteLine(a + b);
            Predicate<string> onlyReturnsBool = (str) => str == string.Empty;

            Console.WriteLine(likeAddDel(100,200));
            Console.WriteLine($"Predicate<> output: {onlyReturnsBool("abc")}");

        }

        public void DelParams(Func<string, string> fn)
        {
            Console.WriteLine(fn("Neeta"));
        }

        public void PrintSomething()   //lambda version of For-each
        {
            int[] ints = { 10, 20, 30, 40, 50 };
            ints.ToList().ForEach((item) =>
            {
                Console.WriteLine(item);
            });

            //foreach ( var item in ints )
            //{
            //    Console.WriteLine(item);
            //}
        }

        public void PrintMovies()
        {
            string[] movies = { "Star wars-James", "Run-Charles", "Lights out-Adam", "Predator-Smith" };
            movies.ToList().ForEach((movie) => {

                string[] splits = movie.Split('-');
                Console.WriteLine($"The movie name {splits[0]}");
                Console.WriteLine($"The director name {splits[1]}");
            });

            Func<string, bool> condition = (movie) => movie == "Star wars";
            movies.Where(condition);
            //Lambda
            Console.WriteLine($"Is this moviename 'Star wars'? {movies.Where((movie) => movie == "Star wars-James").FirstOrDefault()}");   //if movie matches given name first statement and the given movie name is printed
            //Linq
            var result = (from movie in movies
                          where movie == "Run-Charles"
                          select movie).FirstOrDefault();
            Console.WriteLine($"Result using LINQ: {result}");

            //"LINQ" => Language Integrated Query => Lambdas representes in a query format
            //SQL
            //select  * from movies where moviename = "PK"

            //LINQ
            //from movie in movies
            //where movie.moviename == "PK"


            //LAMBDAS
            //movies.where(movie=>movie.moviename == "PK")


        }
        #endregion Generic Delegates


    }
}
