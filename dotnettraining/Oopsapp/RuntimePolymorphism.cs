using System;
using System.Collections.Generic;
using System.Text;

namespace Oopsapp
{
    public interface IClone   // Interface
    { 
      public Shape ClonedObject { get; set; }
      Shape Clone();
    }
    public abstract class Shape          // since fnctn is abstract,class should be abstract
    {
        public int NormalProperty { get; set; }
        public abstract string Draw();   // since its an abstract fnctn, no  curly braces(implementation)
        public virtual string GetStatus()
        {
            return "A sample shape status";
        }
    }

    // Cicle = Shape Class Features+ Extras
    //Hence, Shape c = new Circle(); [Base class = new Derived Class()]
    public class Circle : Shape,IClone
    {
        public int Radius { get; set; }
        public Shape ClonedObject { get; set; }

        public Shape Clone()
        {
            ClonedObject = new Circle();
            ((Circle)ClonedObject).Radius = this.Radius;
            return ClonedObject;
        }
        // end of IClone members
        public override string Draw()
        {
            NormalProperty = 100;
            return $"A circle is drawn with radius: {Radius}";
        }
        public override string GetStatus()
        {
            return base.GetStatus();
        }
    }
    //Triangle = Shape Class + Extras
    //Hence, Shape t = new Triangle();
    public class Triangle : Shape
    {
        public int Base { get; set; }
        public int Height { get; set; }
        public override string GetStatus()         // vitual class method
        {
            return "This is a Triangular disk";       
        } 
        public override string Draw()
        {
            return $"A triangle is drawn with: {Base} and Height: {Height}";
        }
    }
}
