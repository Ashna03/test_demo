using AbsPhoneFactory;        //To use MobileClient here
using AdapterPattern;
using System;


namespace UsingDesignPatterns
{
    class Program
    {
        static ILogger myLogger;
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your logger: ('c' : Console | 'f' : File)");
            string userInput = Console.ReadLine();
            myLogger = GetCorrectLogger(userInput);
            //Start Logging //

            myLogger.Log(new LogEntry() { LogTime = DateTime.Now, Message = "Working with Choosing the Apple store" });
            MobileClient client = new MobileClient(new ApplePcmc(), "Iphone");             //main call code for AbsPhonefactory

            myLogger.Log(new LogEntry() { LogTime = DateTime.Now, Message = $"Mobile Client Chosen: {client.GetType().Name}" });
            Console.WriteLine(client.GetPhoneDetails());                                    //main call code for AbsPhoneFactory
            myLogger.Log(new LogEntry() { LogTime = DateTime.Now, Message = "Phone Details printed Successfully" });

        }

        private static ILogger GetCorrectLogger(string userInput)
        {
            switch (userInput.ToLower())
            {
                case "f":
                    return new DbAdapter();
                case "c":
                default:
                    return new ConsoleLogger();
            }
        }
    }
}
