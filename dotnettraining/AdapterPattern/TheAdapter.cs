using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class DbAdapter : ILogger
    {
        private FileLogger _fileLoggerSystem = new FileLogger();
        public void Log(LogEntry entry)
        {
            string text = $"Log Entry at {entry.LogTime} : {entry.Message}";
            _fileLoggerSystem.CreateLog(text);
        }
    }
}
