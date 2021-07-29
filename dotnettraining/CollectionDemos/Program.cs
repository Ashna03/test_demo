using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace CollectionDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCollection.WithArrayList();
            MyCollection.WithLists();
            MyCollection.WithDictionary();
            MyCollection.withNameValue();
            MyCollection.WithGenerics();
        }
    }

    class MyCollection
    {
        public static void WithGenerics() 
        {
            //Create a registry of schools
            Institution<School> schoolRegistry = new Institution<School>();
            schoolRegistry.Register(new School() { Name = "De Sales School " });
            schoolRegistry.Register(new School() { Name = "Loreto Convent " });

            //Print them
            foreach (var item in schoolRegistry._institutes)
            {
                Console.WriteLine($"{item.Name}");
            }



        }
        public static void WithArrayList() {          //used static so it can be called in main without creating object

            ArrayList multiTypeList = new ArrayList();          //ArrayList can contain any datatype
            multiTypeList.Add(1000);
            multiTypeList.Add("Meena");
            multiTypeList.Add(new MyCollection());
            multiTypeList.Add(null);

            int result = 0; //Add up all items
            foreach (var item in multiTypeList)
            {
                //result += Convert.ToInt32(item);   //item is an object type so its converted to int(similar to result)
                Console.WriteLine(item);              // addition doesnt work because all items are of diff datatype
            }
        }

        public static void WithLists() {

            List<string> lstString = new List<string>();
            List<Person> lstPersons = new List<Person>();    //Person class is created
            //adding items
            lstString.Add("Eena");
            lstString.Add("Meena");
            lstString.Add("Deeka");

            //remove item
            lstString.Remove("Eena");

            //Update item
            lstString[1] = "Teena";

            //Print
            lstString.ForEach((str) =>
            {
                Console.WriteLine(str);
            });

            lstPersons.Add(new Person() { Name = "Vishal", Aadhar = "AD5hgutiji4K", Age = 20 });
            lstPersons.Add(new Person() { Name = "Manikarnika", Aadhar = "AD5hgutiji4K", Age = 20 });
            lstPersons.Add(new Person() { Name = "Hardik", Aadhar = "AD5hgutiji4K", Age = 20 });

            //find and Remove
            Person personToRemove = lstPersons.Find((p) => p.Name == "Manikarnika");
            lstPersons.Remove(personToRemove);

            // find and Update
            Person personToUpdate = lstPersons.Find((p) => p.Name == "Vishal");
            personToUpdate.Name = "Aryan";

            //Print
            lstPersons.ForEach((p) =>
            {
                Console.WriteLine($"{nameof(p.Name)} : {p.Name} | {nameof(p.Age)} : {p.Age} | {nameof(p.Aadhar)} : {p.Aadhar}");
            
            });
        }
        public static void WithDictionary()
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            myDictionary.Add(1, "Name Property ");
            myDictionary.Add(2, "Age Property ");
            myDictionary.Add(3, "Aadhar Property ");

            //Find
            var result = myDictionary.Where((item) => item.Key == 1).ToList();
            //update
            myDictionary[1] = "Full Name Property";
            //Delete
            myDictionary.Remove(3);

            //Print
            foreach (var item in myDictionary)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

        }

        public static void withNameValue()
        {
            NameValueCollection myNameValue = new NameValueCollection();
            myNameValue.Add("one", "English");
            myNameValue.Add("two" , "Maths");
            myNameValue.Add("three", "Science");

            //update
            myNameValue.Set("one", "Hindi");

            //Remove
            myNameValue.Remove("two");

            //Find
            //var result = myNameValue.Where((item) => item.Key == "one").ToList();

            //Print
            foreach (var item in myNameValue.AllKeys)
            {
                Console.WriteLine($"The value are:{item}");       //for getting only key
            }

            //foreach (var item in myNameValue.AllKeys)
            //{
            //    string[] data = myNameValue.GetValues(item);               //for getting key value both
            //    foreach (var kvalue in item)
            //    {
            //        Console.WriteLine($"The keys are:{item}, The Values are: {kvalue} ");
            //    }
            //}
        }



        }

    }

