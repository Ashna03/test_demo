using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsapp
{
    class SingletonProjectSettings
    {
        private static readonly SingletonProjectSettings _instance = new SingletonProjectSettings();
        private SingletonProjectSettings() { }

        public static SingletonProjectSettings GetInstance()
        {
            return _instance;       
        }

        public string AssemblyName { get; set; }
        public string DefaultNamespace { get; set; }
        public string TargetFramework { get; set; }
        public string OutputType { get; set; }
    }
}
