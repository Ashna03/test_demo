using log4net;
using log4net.Config;
using System;
using System.IO;
using System.Reflection;

namespace UsingLog4Net
{
    class Program
    {
        private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            // Load configuration
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

            logger.Debug("This is a debug log");
            logger.Error("This is an error log");
            logger.Warn("This is a warning log");
            logger.Info("This is just for information");


            Console.WriteLine("Hello World!");
        }
    }
}
