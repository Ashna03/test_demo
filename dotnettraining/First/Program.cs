using System;

namespace First
{
    class Program
    {
        public static Int32 aInt = 100;
        public static string aStr = "Ash";
        static void Main(string[] args)
        {
            bool inMain = true;
            Console.WriteLine("Hello World!");
            Console.WriteLine("this is c# app");

            Console.WriteLine(First.Program.aInt);
            Console.WriteLine(First.Program.aStr);
            Console.WriteLine(inMain);
            
            //Start of Demo2 (calling function)
            TypeChanges();

            //demo3
            CreateSimpleArray();
            CreateArrayofThree(25,35,45);
            ReadInputToArray();

            // demo 4 - Parameter
            
            //Passing by value
            int arg = 4;
            squareVal(arg);
            Console.WriteLine($"The value of arg, after passing by value is:{arg}");
            //Passing by reference
            squareRef(ref arg);
            Console.WriteLine($"The value of arg, after passing by ref is:{arg}");
            //passing by In
            squareIn(in arg);
            // passing usin IN and OUT
            Guid licenseKey = Guid.NewGuid();
            string outStatus = String.Empty; // same as null ""
            bool isVerified = VerifyLicense(in licenseKey, out outStatus);
            Console.WriteLine($"The License Key supplied is: {licenseKey}");
            Console.WriteLine($"The license verification returnned {isVerified}.The status message is:{outStatus}");
            //passing using param
            UseParams(10,20,30,40,50);
            UseParams(111);
            UseParams(222,555,666);
            //DEFAULT PARAMETER
            UseDefault(1001);
            UseDefault(9001, "HP");
            //DEMO FOR CLASS LIBRARY
            Sample objSample = new Sample(); // datatype name = new datatype(memory)
            objSample.strProp = "Hello OOPs";
            Console.WriteLine($"Value of strProp is ; {objSample.DoSomething()}");

        }
        static void TypeChanges() { 
            //TypeCasting
            int changedInt = 0; //==> struct Int32
            short shortInt = 100; //==> struct Int16
            
            changedInt = (int)shortInt;

            //TypeConversion
            string str ="100";
            Convert.ToInt32(str); //The algo fist changes memory mgmt strategy from struct to class and then converts the data
            
            //print
            Console.WriteLine(changedInt);
            Console.WriteLine(Convert.ToInt32(str));

            Console.WriteLine(changedInt.GetType().Name);
            Console.WriteLine(typeof(int).Name);
            Console.WriteLine(typeof(float).Name);
        }

        static void CreateSimpleArray()
        {
            int[] ints;
            ints = new int[3];
            ints[0]=111;
            ints[1]=222;
            ints[2]=333;

            ints = new int[] {100,200,300,400,500};
            //Looping
            foreach (int item in ints)
            { 
               //STRING INTERPOLATION WITH console.WriteLine
               Console.WriteLine(item);
               Console.WriteLine($"Current Item: {item}");
            }

        }

        static void CreateArrayofThree(int n1, int n2, int n3) { 
          int[] result = new int[] {n1, n2, n3};
          Console.WriteLine($"The value at position 1 is {result[1]}");

        }
        static void ReadInputToArray()
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(',');
            foreach (string item in arr)
            {
                Console.WriteLine($"Value of Item: {item}");
            }

        }
        static void squareVal(int valParameter)
        {
            valParameter = valParameter * valParameter;
        }
        // Passing by reference
        static void squareRef(ref int refParameter)
        {
            refParameter = refParameter * refParameter;
        }
        static void squareIn(in int inParameter)
        {
            //inParameter = 100; --not allowed
            int result = inParameter * inParameter;
            Console.WriteLine($"The result of square usin IN parameter: {result}");
            Console.WriteLine($"The result of square usin IN parameter: {inParameter * inParameter}");
        }
        static bool VerifyLicense(in Guid key, out string status)
        {
            if (key != null)
            {
                status = "The key is validated successfully";
                return true;
            }
            else
            {
                status = "Invalid key";
                return false;
            }
        
        }
        static void UseParams(params int[] ints)
        {
            int result = 0;
            foreach (int item in ints)
            {
                //result = result + item;
                result += item;
            }
            Console.WriteLine($"The grand total is: {result}");

        }
        static void UseDefault(int id, string empPrefix = "SAPI")    // param and default parameters should be at end
        {
            string empId = $"{empPrefix}--{id}--{Guid.NewGuid()}";
            Console.WriteLine($"The generated EmpId is: {empId}");
        }

       
    }
}


