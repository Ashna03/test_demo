using Newtonsoft.Json;
using System;
using System.Dynamic;
using System.Reflection;

namespace UsingReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello".GetType());                  // gives System.string
            Console.WriteLine($"Fully qualified name for type 'Program': {typeof(haha)}");
            GetPropsAndMethods();
            VarVsDynamic();
            JsonParsing();
            Instantiate();
            

        }

        static void VarVsDynamic()
        {
            dynamic sampleObject = new ExpandoObject();          // creates an object of ExpandoObject, An empty object- can be done anything to it
            Console.WriteLine(sampleObject);
            sampleObject.Prop = "This propert is created in dynamic object";          //own property created
            Console.WriteLine($"Value of Prop: {sampleObject.Prop} ");

            sampleObject.Increment = new Action<int>((i) => Console.WriteLine(i + 1));            //own function created
            sampleObject.Increment(10);

        }

        //Serialization and Deserialization
        static void JsonParsing()
        {
            /* JSON Object
             * {
             *  "a" : "Robert"
             *  "b" : {"b1" : 100,
             *         "b2" : 'abc'}
             *  }
             */
            //var dynObj = JsonConvert.DeserializeObject<ExpandoObject>("{\"a\":1,\"b\":1\"}") as dynamic
            dynamic json = JsonConvert.DeserializeObject<ExpandoObject>("{\"a\":\"Robert\",\"b\":{\"b1\":100, \"b2\": 'abc'}}");          // \"a\"  -escape characters used to  specify "" within another ""
            Console.WriteLine($"json.b = {json?.b.b1}, type of {json?.b.b1.GetType()}");                            //json? used to check whether that json object is null or not, if we dont check null before it might give exception error
        }
        static void GetPropsAndMethods() {
            //Get properties of a type
            Type datatype = "Hello".GetType();  //system.string
            foreach (var property in datatype.GetProperties())
            {
                Console.WriteLine($"PropertyName: {property.Name}");    //nameof()
            }
            foreach (var method in datatype.GetMethods())
            {
                Console.WriteLine($"MethodName: {method.Name}");    //nameof()
            }

        }

        // Get a type and print its methods and property
        public static void Instantiate()
        {
            Console.WriteLine("Give us atype & we will instantiate it!");
            string s = Console.ReadLine();                        //input as - UsingReflection.classname

            //Discover the real datatype
            Type t = Type.GetType(s);

            //Instantiate it!
            var instance = Activator.CreateInstance(t);
            GetMembersByType(t);
        }

        public static void GetMembersByType(Type o)
        {
            foreach (var property in o.GetProperties())
            {
                Console.WriteLine($"PropertyName : {property.Name} ");
            }
            foreach (var method in o.GetMethods())
            {
                Console.WriteLine($"MethodName : {method.Name} ");
            }
        
        }
    }
    

    class haha {
        public int Id { get; set; }
        public string Sound { get; set; }

        public int TimesOfHaha { get; set; }
    }
}
