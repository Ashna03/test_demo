using System;
using System.Collections.Generic;
using System.Text;

namespace LabRuntimePolymorphism
{
    public abstract class Cars
    {
        public int Price { get; set; }
        public string Color { get; set; }
        public abstract string Purchase();
    }
    public class MarutiAlto800 : Cars
    {
        public int Year_of_Manufacture { get; set; }
        public override string Purchase()
        {
            return $"The model is available in {Color} color produced in {Year_of_Manufacture} and Price: {Price}";
        }
    }
        public class Ferrari : Cars
        {
            public override string Purchase()
            {
                return $"The model is available in {Color} color and Price: {Price}";
            }
        }
    public class Benz : Cars
    {
        public int Speed { get; set; }
        public override string Purchase()
        {
            return $"The model is available in {Color} color and Price: {Price} with speed {Speed} kmph";
        }
    }
    }
