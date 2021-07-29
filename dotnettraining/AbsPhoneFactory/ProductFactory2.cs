using System;
using System.Collections.Generic;
using System.Text;

namespace AbsPhoneFactory
{
    public abstract class Watch
    {
        public abstract string GetDetails();
    }

    public class OnePlusW : Watch
    {
        public override string GetDetails()
        {
            return "This is a OnePlus Smart Watch";
        }
    }

    public class AppleW : Watch
    {
        public override string GetDetails()
        {
            return "This is an smart IWatch from Apple";
        }
    }
}
