using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsapp
{
    class Person
    {
        public Person()
        {

        }
        // banking purpose
        public Person(string aadhar): this() //inheriting from const with no parameter 
        {
            Aadhar = aadhar;
        }
        //for filling form
        public Person(string name, int age, string address):this()
        {
            Name = name;
            Age = age;
            Address = address;
        }
        //filling a form for bank purpose or mobile connection
        public Person(string aadhar, string name, int age, string address, string gender)
           :this(name, age, address)
        {
            Aadhar = aadhar;
            Gender = gender;
        }

        public string Aadhar { get; set; }      //Features of a person
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Complexion { get; set; }

        public bool Works(string pTask, out string msg )
        {
            msg=$"{Name} has completed the task:{pTask}";
            return true;
        }
        public string Eats() 
        {
            return $"{Name} has had a sumptuous meal";

        }
        public float Sleep()
        {
            return 8f;          //return 8 as float
        }
        public string Speaks(string words)
        {
            switch (words.ToLower())
            {
                case "good day":
                    return $"{Name}:{words} {Environment.NewLine} Alexa : Good day to you too!";
                case "how are you":
                    return $"{Name}:{words} {Environment.NewLine} Alexa : I'm doing good, how about you?";
                default:
                    return $"{Name}:{words} {Environment.NewLine} Alexa:Sorry couldn't get that";
                    
            }
        }

        ~Person() 
        {
        }

    }
}
