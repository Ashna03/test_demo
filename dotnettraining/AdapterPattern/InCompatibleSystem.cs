using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdapterPattern
{
    public class FileLogger
    {
        public void CreateLog(string text)
        {
            FileStream fs = new FileStream(@"D:\dotnettraining\FileLog.txt", FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write);
            fs.Write(Encoding.UTF8.GetBytes(text));
            fs.Close();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"FileLog created at C:\FileLog.txt");
            Console.ResetColor();
        
        }
    }
}
