using System;
using System.Collections.Generic;
using System.Text;

namespace AbsPhoneFactory
{
    public abstract class Phone
    {
       public abstract string GetDetails();
    }

    public class IPhone : Phone
    {
        public override string GetDetails()
        {
            return "This is an IPhone series 12x from Apple";
        }
    }

    public class OnePlus : Phone
    {
        public override string GetDetails()
        {
            return "This is OnePlus smart phone from BBK Electronics";
        }
    }
}
