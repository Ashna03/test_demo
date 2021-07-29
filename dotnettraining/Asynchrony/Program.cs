using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Asynchrony
{
    class Program
    {
        static void Main(string[] args)
        {
            //UseConcurrentBag();
            //UsingTaskCancellation();
            //ParallelLoop();
            UsingExceptionFilters((errorcode) => LogError(errorcode));
            Console.ReadLine();            //Readline is used to provide where the task can merge afterwards
        }
        public static async void M1M2()
        {
            // awaits for task
            Method1();
            Method2();
        }

        public static async void withAwaitM1M2() 
        {
            await Method1();
            Method2();
        }

        public static async Task Method1()          //async used to specify that method can be executed asynchronously
        {
            await Task.Run(() =>                    //to  merge back after asynchronous execution
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine($"M1-{i} Method 1");
                }            
            
            });
        
        }
        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine($"M2-{i} Method 2");
            }
        }
        public static void Method3(int count)
        {
            Console.WriteLine("Total count is" + count);
        }

        public static void ExecuteMultipleTasks() {
            TaskFactory factory = new TaskFactory();
            factory.StartNew(() => Method2());
            factory.StartNew(() => Method3(9999));
        }

        public static void UseConcurrentBag()
        {
            ConcurrentBag<Task> taskBag = new System.Collections.Concurrent.ConcurrentBag<Task>();           //concurrent bag is generic collection for storing multiple values/tasks
            Task t1 = new Task(() => Method1());
            Task t2 = new Task(() => Method2());

            taskBag.Add(t1);
            taskBag.Add(t2);

            foreach (var t in taskBag)
            {
                t.Start();                                 //Task t1,t2 and console are executing concurrently and can be executed in any order and inbetween each other except task1 is completed fully in one go without interruption since its method1 uses "await"
                Console.WriteLine($"Id: {t.Id}, Status: {t.Status}, IsCancellable: {t.IsCanceled}");
            }
        }

        public static async void UseConcurrentBagWithAwait()
        {
            ConcurrentBag<Task> taskBag = new ConcurrentBag<Task>();           //concurrent bag is generic collection for storing multiple values/tasks
            Task t1 = new Task(() => Method1());
            Task t2 = new Task(() => Method2());

            taskBag.Add(t1);
            taskBag.Add(t2);

            foreach (var t in taskBag)
            {
                await Task.Run(() => t.Start());                                 //"Await" is used so no random execution,so all Tasks are executed in one go
                Console.WriteLine($"Id: {t.Id}, Status: {t.Status}, IsCancellable: {t.IsCanceled}");
            }
        }

        public static void UsingTaskCancellation()
        {
            //step1: Initialize Cancellation token source to cancel a task
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;

            //Start a new task by passing the cancellation token
            Task t = Task.Factory.StartNew(() => {                          //selecting task from a pool of tasks(Factory) for method
                int counter = 1;
                while (!token.IsCancellationRequested)          //IsCancellationRequested is builtin property of token class
                {
                    Console.WriteLine(counter++);
                    Thread.Sleep(1000);                           // After each print pause of 1 sec
                }
             }, token);              

            //On any key pressed by user, cancel the task
            Console.WriteLine("======== Press any key to cancel this Task=======");
            Console.ReadKey();
            tokenSource.Cancel();      //cancels a running task
            Console.WriteLine("Task Cancelled");
        }

        public static void ParallelLoop()
        {
            List<int> ints = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> longerInts = Enumerable.Range(1, 1000).ToList();
            Parallel.ForEach(longerInts, (singleInt) =>
            {
                Console.WriteLine($"Parallel Printing {singleInt}");
            
            });
        
        }

        public static async void UsingExceptionFilters(Func<int, Task> onError)
        {
            try
            {
                string s = null;
                s.Contains("abc");   //NullReference exceptio
            }
            catch (Exception ex)
            {
                await onError(ex.GetHashCode());
                return;
            }
        
        }
        public static async Task LogError(int errorCode)
        {
            Console.WriteLine($"#### ERROR OCCURED: Error Code: {errorCode}");
        }


    }
}
