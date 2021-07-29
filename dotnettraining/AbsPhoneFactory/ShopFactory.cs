using System;
using System.Collections.Generic;
using System.Text;

namespace AbsPhoneFactory
{
    public interface IAppleFranchise                //inside interface don't use access modifiers because it is public by default
    {
        Phone GetPhone(string name);              //'Phone GetPhone' because return type is phone
        Watch GetWatch(string name);
    }

    public class ApplePune : IAppleFranchise
    {
        public Phone GetPhone(string name)
        {
            switch (name.ToLower())
            {
                case "iphone":
                    return new IPhone();

                case "oneplus":
                    return new OnePlus();

                default:
                    throw new Exception("Phone not found");
            }
        }

        public Watch GetWatch(string name)
        {
            throw new NotImplementedException();
        }
    }
    public class ApplePcmc : IAppleFranchise
    {
        public Phone GetPhone(string name)
        {
            switch (name.ToLower())
            {
                case "iphone":
                    return new IPhone();

                case "oneplus":
                    return new OnePlus();

                default:
                    throw new Exception("Phone not found");
            }
        }

        public Watch GetWatch(string name)
        {
            throw new NotImplementedException();
        }
    }
}
