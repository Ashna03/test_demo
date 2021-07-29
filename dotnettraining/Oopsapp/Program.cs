using System;

namespace Oopsapp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create 2 persons
            //<datatype> <var-name> = new <datatype>();
            Person Mary = new Person();
            Person Rose = new Person();
            AssignProperties(ref Mary, "ADH456637856", "Mary Phils", 23, "Female", "Bangalore", "Wheatish");
            AssignProperties(ref Rose, "BDH456685856", "Rose Jos", 25, "Male", "Bangalore", "Wheatish");

            //call functions for Mary
            CallPersonFuctions(ref Mary);
            CallPersonFuctions(ref Rose);

            CallPersonsProperties(ref Mary);

            // demo for Inheritance OF CLASS
            Square sq = new Square(10);
            Console.WriteLine(sq.CalculatedArea());

            Rectangle rec = new Rectangle(10,5);
            Console.WriteLine(rec.CalculatedArea());

            //------demo sealed----
            sq.AccessingSealed();

            //---- Accessing static----
            ICannotBeInstantiated.CallMe();

            // calling static method in a non-static class
            OnlyStaticFunctions.AnotherMain();

            //Accessing non static method in a nonstatic class

            OnlyStaticFunctions objNonStaticClass = new OnlyStaticFunctions();
            objNonStaticClass.NormalMethod();

            //------ Singleton Pattern----

            SingletonProjectSettings mySettings = SingletonProjectSettings.GetInstance();   //cannot use new keyboard because only one instance is created
            mySettings.AssemblyName = "OopsApp";
            mySettings.DefaultNamespace = "OopsApp";
            mySettings.TargetFramework = ".Net Core 3.1";
            mySettings.OutputType = "Console App";

            Console.WriteLine("Printing values of object mySettings");
            Console.WriteLine(mySettings.AssemblyName);
            Console.WriteLine(mySettings.DefaultNamespace);
            Console.WriteLine(mySettings.TargetFramework);
            Console.WriteLine(mySettings.OutputType);

            SingletonProjectSettings mySettings2 = SingletonProjectSettings.GetInstance();     //same value will be printed because only one object/instantiation is created..so only value is stored
            Console.WriteLine("Printing values of object mySettings2");
            Console.WriteLine(mySettings2.AssemblyName);
            Console.WriteLine(mySettings2.DefaultNamespace);
            Console.WriteLine(mySettings2.TargetFramework);
            Console.WriteLine(mySettings2.OutputType);

            //changing values and verifying
            mySettings2.AssemblyName = "Changed value";            //changed value will be reflected in both mySettings and mySettings2 since only one object is created to hold value
            Console.WriteLine($"Value of mySettings.AssemblyName:{mySettings.AssemblyName}");
            Console.WriteLine($"Value of mySettings2.AssemblyName:{mySettings2.AssemblyName}");


            // Demo for Method Overiding(Runtime polymorphism)
            Console.WriteLine("Please type 'c' for circle and 't' for triangle");
            string shape = Console.ReadLine();
            Shape sh;     //cannot use 'new' keyword for creating object since its a abstract class
            switch (shape)
            {
                case "c": //Base Class object = new Derived Class()
                    sh = new Circle();
                    ((Circle)sh).Radius = 10;
                    Console.WriteLine(sh.Draw());
                    Console.WriteLine(sh.GetStatus()); //For virtual class

                    // Testing Interface
                    Circle c = new Circle();
                    c.Radius = 20;
                    Shape sResult = c.Clone();
                    Console.WriteLine($"A clone is created with value of property {nameof(c.Radius)} = {c.Radius}");
                    Console.WriteLine($"A clone of original with value of property {nameof(c.Radius)} = {((Circle)sh).Radius}");
                    break;
                case "t": //Base Class object = new Derived Class()
                    sh = new Triangle();
                    ((Triangle)sh).Base = 10;
                    ((Triangle)sh).Height = 5;
                    Console.WriteLine(sh.Draw());
                    Console.WriteLine(sh.GetStatus());
                    break;
                
                case "ex":
                    try
                    {
                        Shape s = null;     // s is null
                        Console.WriteLine(s.NormalProperty);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error occured: {ex.Message}");
                    }
                    break;
                default:
                    //Console.WriteLine("Invalid Shape cannot be drawn");
                    throw new Exception("Invalid Shape cannot be drawn");
                    break;
            }

            //------Accessing Tuples------
            NewFeatures features = new NewFeatures();
            Tuple<int,string,bool> result_v1= features.GetValues123_v1();
            Console.WriteLine($"Results of v1 are: {nameof(result_v1.Item1)}={result_v1.Item1}," +             //on pressing enter after a sentence it'll automatically come to next line with'+'
                $" {nameof(result_v1.Item2)}= {result_v1.Item2}," +
                $" {nameof(result_v1.Item3)}= {result_v1.Item3}");

            //----second method of accessing Tuple
            var result_v2 = features.GetValues123_v2();
            Console.WriteLine($"Results of v1 are: {nameof(result_v2.Item1)}={result_v2.Item1}," +
                $" {nameof(result_v2.Item2)}= {result_v2.Item2}, " +
                $"{nameof(result_v2.Item3)}= {result_v2.Item3}");

            var result_v3 = features.GetValues123_v3();
            Console.WriteLine($"Results of v1 are: {nameof(result_v3.rValue)}={result_v3.rValue}," +
                $" {nameof(result_v3.name)}= {result_v3.name}," +
                $" {nameof(result_v3.isTrue)}= {result_v3.isTrue}");


            //----Demo for Pattern Matching---
            features.TestShapes(new Circle());
        }

        private static void CallPersonsProperties(ref Person obj)
        {
            Console.WriteLine($"{obj.Name} has the aadhar no: {obj.Aadhar}, Address: {obj.Address}, Age: {obj.Age}, Complexion: {obj.Complexion}, Gender is: {obj.Gender}");
        }

        private static void CallPersonFuctions(ref Person obj)
        {
            string workStatus = string.Empty;
            bool isWorks = obj.Works("coding", out workStatus);
            Console.WriteLine($"{obj.Name} Completion status: {isWorks}. work status: {workStatus}");

            Console.WriteLine(obj.Eats());
            Console.WriteLine($"{obj.Name} has a sleep cycle of {obj.Sleep()}");
            Console.WriteLine(obj.Speaks("Good day"));
            
        }

        private static void AssignProperties(ref Person obj, string aadhar, string name, int age, string gender, string address, string complexion)
        {
            obj.Aadhar = aadhar;
            obj.Address = address;
            obj.Age = age;
            obj.Complexion = complexion;
            obj.Gender = gender;
            obj.Name = name;
        }
    }
}
