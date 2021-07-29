using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaMathCalc
{
    delegate int AddValues(int a, int b);
    class MathCalculator
    {
        public int LambdaAdd(int a, int b) 
        {
            AddValues valAdd = (a, b) => a + b;
            return valAdd(a ,b);
        }
        public int LambdaSub(int a, int b)
        {
            AddValues ValSub = (int a, int b) => a - b;
            return ValSub(a , b);
        }
        public int LambdaMul(int a, int b)
        {
            AddValues ValMul = (a, b) => a * b;
            return ValMul(a, b);
        }
        public int LambdaDiv(int a, int b)
        {
            AddValues ValDiv = (a, b) => a / b;
            return ValDiv(a, b);
        }


    }
}
