using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    public class Sample
    {
        //constructor
        public Sample() { }
        
        //destructor
        ~Sample() { }

        //Field
        public Sample s = null;
        public Int32 i = 0;
        public String str = string.Empty;

        //Property
        public string strProp { get; set; }

        //Function
        public string DoSomething()
        {
            return $"Value of strProp is: {strProp}";        
        }



    }
}
