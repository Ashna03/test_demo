using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsapp
{
    // Base class
    public class Rectangle
    {
        public Rectangle(int length, int breadth)  //constructor
        {
            Length = length;
            Breadth = breadth;
             
        }
        protected int Length { get; set; }
        protected int Breadth { get; set; }
        public int CalculatedArea() {
            return Length * Breadth;
        }
    }
    public class Square : Rectangle
    {
        public Square(int side) : base(side,side)   //base is rectangle
        {
            
        }
        public string AccessRectangleProps()
        {
            return $"This square has a side of dimension {Length}cm. The area of this square is {CalculatedArea()} ";

        }
        // ---sealed class calling-----
        public void AccessingSealed()
        { 
         ICannotBeDerived sealedclass = new ICannotBeDerived();
         Console.WriteLine(sealedclass.CallMe());
        }
    }
    public sealed class ICannotBeDerived 
    {
      public string CallMe()
        { 
          return "Hi , I'm accessible.Don't try to change me ";
        }
    }

    public static class ICannotBeInstantiated
    { 
     // A non-static method cannot be created in a static class
      static ICannotBeDerived obj = new ICannotBeDerived();
      public static void CallMe() { 
           Console.WriteLine("A static method in astatic class");
        }
    }
    public class OnlyStaticFunctions
    { 
      public static void AnotherMain()
        { 
          Console.WriteLine("I'm A static fnction in a non-static class");
        }
        public void NormalMethod()
        { 
          Console.WriteLine("I'm A non-static fnction in a non-static class");
        }


    }


}
