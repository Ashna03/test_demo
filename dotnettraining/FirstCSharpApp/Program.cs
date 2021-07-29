using System;   //import {System} from 'System'

namespace FirstCSharpApp    //exports.FirstCSharpApp = Program
{
    class Program
    {

        /// <summary>
        /// Create Property AppName
        /// </summary>
        public static string AppName { get; set; }        


        static int number = 1030; //private int number => private variable
        static string name = "Nitor .Net Group";

        static string[] arrMenu = {"Seema", "Reema", "Neema"};
        
        enum Menu { Option1, Option2, Option3 };    //Helps create a custom datatype having a string array
        static int i;
        static Menu m;
       
        static void Main(string[] args)
        {
            
            m = Menu.Option1;
            Console.WriteLine("Integer value: {0} = {1} + {2}", number, 1000, 30);
            Console.WriteLine("String value: We are a part of {0} ", name);
            Console.WriteLine("Value of Enum is: {0}", m);

            string readline = Console.ReadLine();
            Console.WriteLine("Value entered by user: {0}", readline);

            int read = Console.Read();
            Console.WriteLine("Value entered by user: {0}", read);

            ConsoleKeyInfo readkey = Console.ReadKey();
            Console.WriteLine("Value entered by user: {0}", readkey.KeyChar);

            //Getting value inside the property
            AppName = Console.ReadLine();
            Console.WriteLine("Value in AppName: {0}", AppName);

            Console.WriteLine("Enter an option .... ");       
            Menu myMenu = (Menu)Enum.Parse(typeof(Menu),Console.ReadLine());

            switch (myMenu)
            {
                case Menu.Option1:
                    Console.WriteLine("Option 1 Group consists of the following members");
                    foreach (string item in arrMenu)
                    {
                        Console.WriteLine("# "+item);
                    }
                    break;

                case Menu.Option2:
                    break;

                case Menu.Option3:
                    break;
                default:
                    break;
            }

            Console.Write("This is to output a single string");
            Console.WriteLine("This is to output a line of data");
            //Calling function with parameter
            string callResult = SayHello("Pratibha");
            Console.WriteLine(callResult);
            Console.ReadKey();
            Console.WriteLine("##### Interpreting user data ######");
            string userData = ReadUserData();
            bool isDataValid = IsUserDataValid(userData);
            if (isDataValid)
            {
                Console.WriteLine("Entered Data is valid");
            }
            else
            {
                Console.WriteLine("Entered Data is invalid");
            }
            //Call switch
            int result = SwitchCaseExample();
            //Call switch in do while loop
            CallSwitchCaseInLoop();
            Console.ReadKey();
        }

        static string SayHello(string pName)
        {
            string result = "Hello " + pName;
            return result;
        }

        static string ReadUserData()
        {
            string result = Console.ReadLine();
            return result;
        }

        static bool IsUserDataValid(string pData)
        {
            if (pData == "Yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int SwitchCaseExample()
        {
            //Example as Math operations
            Console.WriteLine("Select operation: /nAdd /nSub /nMul /nDiv ");
            string operationType = Console.ReadLine();
            Console.WriteLine("Enter a number");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int num2 = Convert.ToInt16(Console.ReadLine());
            int result = 0;
            switch (operationType)
            {
                case "Add":
                    result = num1 + num2;
                    break;
                case "Sub":
                    result = num1 - num2;
                    break;

                case "Mul":
                    return (num1 * num2);

                case "Div":
                    return num1 / num2;

                default:
                    break;
            }
            return result;
        }

        static void CallSwitchCaseInLoop()
        {
            string isContinue;
            int result;
            do
            {
                //logic to execute math operations
                result = SwitchCaseExample();
                Console.WriteLine("Answer: " + result.ToString());
                Console.WriteLine("Do you want to continue? Y/N");
                //Ask user if her wants to continue
                isContinue = Console.ReadLine();

            } while (isContinue == "Y");
        }

    }
}
