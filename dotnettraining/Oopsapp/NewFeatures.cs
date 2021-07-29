using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsapp
{
    public class NewFeatures
    {
        #region Tuples
        public Tuple<int, string, bool> GetValues123_v1()
        {
            Tuple<int, string, bool> result = new Tuple<int, string, bool>(100,"Meena",true);
            return result; 
         }
        public (int, string, bool) GetValues123_v2() {
            return (100,"Meena",true);
        }
        public (int rValue, string name, bool isTrue) GetValues123_v3()
        {
            return (100,"Meena",true);
        }
        #endregion Tuples

        #region PatternMatching
        public void TestShapes(Shape s) {
            switch (s)
            {
                case Circle c when c.Radius == 0:
                case Triangle t when t.Base == 0 || t.Height == 0:
                    Console.WriteLine("Please specify shape dimension");
                    break;
                default:
                    break;
            }
        
        }
        #endregion PatternMatching 



    }
}
